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
    public partial class AbstractTab : UserControl
    {
        #region Members
        private DbService db { get; set; }
        private string clsText { get; set; }

        private string pathTexFile { get; set; }

        private string absName { get; set; }
        private string absColorName { get; set; }
        private string absFontName { get; set; }

        private List<string> fontList { get; set; }
        private string fontColor { get; set; }
        private string colorR { get; set; }
        private string colorG { get; set; }
        private string colorB { get; set; }

        private string tmpLeftText { get; set; } = "";
        private string tmpRightText { get; set; } = "";

        private List<DocOption> alignData { get; set; }

        private DocStyleForm parentForm { get; set; }

        private bool isFormLoad { get; set; } = true;

        private bool isInit { get; set; } = true;

        private string tmpText { get; set; }
        #endregion

        #region Constructors
        public AbstractTab()
        {
            InitializeComponent();
        }

        public AbstractTab(string path) : this()
        {
            pathTexFile = path;
        }
        #endregion

        private string SetAlignText(string headText)
        {
            string cls = parentForm.GetCls();

            if (cls == "report")
            {
                if (cboAlign.SelectedIndex == 1)
                {
                    headText = @"\flushleft" + headText;
                }
                else if (cboAlign.SelectedIndex == 2)
                {
                    headText = @"\flushright" + headText;
                }
            }
            else
            {
                if (cboAlign.SelectedIndex == 0)
                {
                    headText = @"\hfill" + headText + @"\hfill";
                }
                else if (cboAlign.SelectedIndex == 1)
                {
                    headText = headText + @"\hfill";
                }
                else
                {
                    headText = @"\hfill" + headText;
                }
            }
            return headText;
        }

        private string SetSpecialFormat(string txt)
        {
            if (cbUnderline.Checked)
            {
                txt = @"\underline" + txt;
            }
            if (cbBold.Checked)
            {
                txt = @"\bfseries" + txt;
            }
            if (cbItalic.Checked)
            {
                txt = @"\itshape" + txt;
            }

            return txt;
        }

        private void RunPreview()
        {
            try
            {
                //Heading Tab
                string txt = "";
                string resultTxt = "";
                List<string> lst = new List<string>();
                string fontSize = String.Format("{0}pt", nudFsize.Value.ToString());
                string backskip = String.Format("{0}pt", ((nudFsize.Value * 120) / 100).ToString());
                string alignOption = cboAlign.SelectedValue.ToString();
                string fontSizeOption = String.Format(@"\fontsize{0}{1}\selectfont", "{" + fontSize + "}", "{" + backskip + "}");

                string fontColorDefine = String.Format(Constants.DefineColorCommand, absColorName, "{" + fontColor + "}");
                string fontColorOption = String.Format(@"\color{0}", absColorName);

                string fontFamilyValue = "{" + cboFont.SelectedValue.ToString() + "}";
                string fontFamilyDefine = String.Format(Constants.NewFontCommand, absFontName, fontFamilyValue);

                int findIndex = -1;

                clsText = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);

                lst = clsText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                if (cbCustom.Checked)
                {
                    txt = "{" + txtHead.Text + "}";
                    txt = SetSpecialFormat(txt);
                    txt = absFontName + fontColorOption + fontSizeOption + txt;
                    txt = SetAlignText(txt);
                    resultTxt = String.Format(Constants.ContentNameFormat, absName, txt);

                    if (isInit)
                    {
                        findIndex = lst.FindIndex(x => x.Contains(Constants.NewFontBegin));
                        lst.Insert(findIndex + 1, fontFamilyDefine);
                    }
                    else
                    {
                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", absColorName)));
                        lst[findIndex] = fontColorDefine;

                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", absFontName)));
                        lst[findIndex] = fontFamilyDefine;
                    }

                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewcommand{0}", absName)));
                    lst[findIndex] = resultTxt;

                    isInit = false;
                }
                else
                {
                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", absColorName)));
                    lst[findIndex] = @"\definecolor{abscolor}{RGB}{0, 0, 0}";

                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", absFontName)));
                    lst.RemoveAt(findIndex);

                    resultTxt = String.Format(Constants.AbstractNameDefault, absName, absColorName, tmpText);
                    if (parentForm.cls == "report")
                    {
                        resultTxt = resultTxt.Replace(@"\hfill", "");
                    }
                    findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewcommand{0}", absName)));
                    lst[findIndex] = resultTxt;
                    txtHead.Text = tmpText;

                    isInit = true;
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

        private void AbstractTab_Load(object sender, EventArgs e)
        {
            db = new DbService();

            absName = @"\abstractname";
            absColorName = "{abscolor}";
            absFontName = @"\absfont";
            tmpText = "Abstract";
            txtHead.Text = "Abstract";

            fontList = new List<string>();
            fontList = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
            cboFont.DataSource = fontList;

            alignData = db.GetDocOptionData("Title Align");
            cboAlign.DataSource = alignData;
            cboAlign.DisplayMember = Constants.Name;
            cboAlign.ValueMember = Constants.Name;
            cboAlign.SelectedIndex = 1;

            nudFsize.Value = 16;

            MainService.ChangeControlsEnable(false,
               cboFont, nudFsize, txtHead, btnHead, cboAlign,
                bnColor, cbUnderline, cbItalic, cbBold);

            colorDialog1.Color = Color.Black;
            colorR = colorDialog1.Color.R.ToString();
            colorG = colorDialog1.Color.G.ToString();
            colorB = colorDialog1.Color.B.ToString();
            fontColor = String.Format("{0},{1},{2}", colorR, colorG, colorB);



            parentForm = this.ParentForm as DocStyleForm;
            isFormLoad = false;
        }

        private void bnColor_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();

            if (colorResult == DialogResult.OK)
            {
                colorR = colorDialog1.Color.R.ToString();
                colorG = colorDialog1.Color.G.ToString();
                colorB = colorDialog1.Color.B.ToString();
                fontColor = String.Format("{0},{1},{2}", colorR, colorG, colorB);
                bnColor.BackColor = colorDialog1.Color;
            }
        }

        private void cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            tmpText = txtHead.Text;
            RunPreview();

            if (String.IsNullOrEmpty(txtHead.Text) || String.IsNullOrWhiteSpace(txtHead.Text))
            {
                MainService.ChangeControlsEnable(false,
              cboFont, nudFsize, cboAlign,
               bnColor, cbUnderline, cbItalic, cbBold);
            }
            else
            {
                MainService.ChangeControlsEnable(true,
              cboFont, nudFsize, cboAlign,
               bnColor, cbUnderline, cbItalic, cbBold);
            }
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunPreview();
        }

        private void nudFsize_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunPreview();
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            RunPreview();
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            RunPreview();
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            RunPreview();
        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbCustom.Checked;
            MainService.ChangeControlsEnable(isChecked,
               btnHead, txtHead, cboFont, nudFsize, cboAlign,
               bnColor, cbUnderline, cbItalic, cbBold);

            RunPreview();
        }
    }
}
