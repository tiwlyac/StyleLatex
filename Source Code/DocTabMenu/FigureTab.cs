using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleLatex.Models;
using StyleLatex.Helper;
using System.IO;

namespace StyleLatex.DocTabMenu
{
    public partial class FigureTab : UserControl
    {
        private DbService db { get; set; }
        private string clsText { get; set; }

        private DocStyleForm parentForm { get; set; }
        private string pathTexFile { get; set; }
        private string figType { get; set; }
        private bool isFormLoad { get; set; } = true;

        private List<DocOption> figAlignData { get; set; }
        private List<DocOption> capAlignData { get; set; }
        private List<DocOption> lbSepData { get; set; }
        private List<DocOption> numberingData { get; set; }

        private string commdName { get; set; }
        private string tmpText { get; set; }

        public FigureTab()
        {
            InitializeComponent();
        }

        public FigureTab(string path, string type) : this()
        {
            pathTexFile = path;
            figType = type;
            SetFigType();
        }

        private void SetFigType()
        {
            switch (figType)
            {
                case "figure":
                    lbFigAlign.Text = "Figure Align";
                    commdName = @"\thefigure";
                    txtLabel.Text = "Figure";
                    tmpText = "Figure";
                    break;
                case "table":
                    lbFigAlign.Text = "Table Align";
                    commdName = @"\thetable";
                    txtLabel.Text = "Table";
                    tmpText = "Table";
                    break;
            }
        }

        private void FigureTab_Load(object sender, EventArgs e)
        {
            db = new DbService();

            figAlignData = db.GetDocOptionData("Text Align");
            cboFigAlign.DataSource = figAlignData;
            cboFigAlign.DisplayMember = Constants.Name;
            cboFigAlign.ValueMember = Constants.Option;
            cboFigAlign.SelectedIndex = 2;

            capAlignData = db.GetDocOptionData(lbCapAlign.Text);
            cboCapAlign.DataSource = capAlignData;
            cboCapAlign.DisplayMember = Constants.Name;
            cboCapAlign.ValueMember = Constants.Option;
            cboCapAlign.SelectedIndex = 2;

            lbSepData = db.GetDocOptionData(lbSep.Text);
            cboSep.DataSource = lbSepData;
            cboSep.DisplayMember = Constants.Name;
            cboSep.ValueMember = Constants.Option;
            cboSep.SelectedIndex = 0;

            numberingData = db.GetDocOptionData(lbNumbering.Text);
            cboNumbering.DataSource = numberingData;
            cboNumbering.DisplayMember = Constants.Name;
            cboNumbering.ValueMember = Constants.Option;
            cboNumbering.SelectedIndex = 0;

            cbEnableLabel.Checked = true;

            parentForm = this.ParentForm as DocStyleForm;

            isFormLoad = false;
        }

        private string SetSpecialFormat()
        {
            string txt = "";
            if (cbBold.Checked && !cbItalic.Checked)
            {
                txt = "bf";
            }
            else if (cbItalic.Checked && !cbBold.Checked)
            {
                txt = "it";
            }
            else if (cbItalic.Checked && cbBold.Checked)
            {
                txt = "bf,it";
            }
            return txt;
        }

        private void RunPreview(string mode)
        {
            try
            {
                List<string> lst = new List<string>();
                int findIndex = -1;

                //Figure Align
                string figAlignValue = cboFigAlign.SelectedValue.ToString();
                string figAlignFormat = @"\renewenvironment{{{0}}}[1][\fps@{0}]" + Environment.NewLine +
                                        @"  {{\edef\@tempa{{\noexpand\@float{{{0}}}[#1]}}\@tempa{1}}}" + Environment.NewLine +
                                        @"  {{\end@float}}";

                //Label
                string capAlignValue = cboCapAlign.SelectedValue.ToString();
                string formatTxt = SetSpecialFormat();
                string sepTxt = cboSep.SelectedValue.ToString();
                string numValue = String.Format(cboNumbering.SelectedValue.ToString(), figType);
                string numTxt = String.Format(Constants.NumberingFormat, commdName, numValue);

                clsText = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);

                lst = clsText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();


                if (mode == lbFigAlign.Text)
                {
                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewenvironment{{{0}}}", figType)));
                    for (int i = 0; i < 3; i++)
                    {
                        lst.RemoveAt(findIndex);
                    }
                    lst.Insert(findIndex, String.Format(figAlignFormat, figType, figAlignValue));
                }
                else if (mode == "Label")
                {
                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\captionsetup[{0}]", figType)));

                    if (cbEnableLabel.Checked)
                    {
                        lst[findIndex] = String.Format(@"\captionsetup[{0}]{{labelformat=default, name={1}, labelfont={{{2}}}, labelsep={3}, justification={4}, singlelinecheck=false}}",
                            figType, tmpText, formatTxt, sepTxt, capAlignValue);
                    }
                    else
                    {
                        lst[findIndex] = String.Format(@"\captionsetup[{0}]{{labelformat=empty, justification={1}, singlelinecheck=false}}", figType, capAlignValue);
                    }
                }
                else
                {
                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewcommand{{{0}}}", commdName)));
                    lst[findIndex] = numTxt;
                }

                clsText = String.Join(Environment.NewLine, lst);

                MainService.WriteLatexFile(Constants.DocClsName, ".cls", pathTexFile, clsText);

                parentForm.ReloadPdf = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbEnableLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableLabel.Checked)
            {
                MainService.ChangeControlsEnable(true,
                    txtLabel, btnName, cbBold, cbItalic,
                    cboSep, cboNumbering);
            }
            else
            {
                MainService.ChangeControlsEnable(false,
                    txtLabel, btnName, cbBold, cbItalic,
                    cboSep, cboNumbering);
            }

            if (!isFormLoad)
                RunPreview("Label");
        }

        private void cboFigAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview(lbFigAlign.Text);
        }

        private void cboCapAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview("Label");
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            tmpText = txtLabel.Text;
            RunPreview("Label");

            if (String.IsNullOrEmpty(txtLabel.Text) || String.IsNullOrWhiteSpace(txtLabel.Text))
            {
                MainService.ChangeControlsEnable(false,
                    cbBold, cbItalic);
            }
            else
            {
                MainService.ChangeControlsEnable(true,
                    cbBold, cbItalic);
            }
        }

        private void cboSep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview("Label");
        }

        private void cboNumbering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview("Numbering");
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            RunPreview("Label");
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            RunPreview("Label");
        }
    }
}
