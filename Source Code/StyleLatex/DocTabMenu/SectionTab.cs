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
using PdfiumViewer;
using StyleLatex.Helper;
using System.IO;

namespace StyleLatex.DocTabMenu
{
    public partial class SectionTab : UserControl
    {
        private DbService db { get; set; }

        private List<string> fontList { get; set; }
        private string fontColor { get; set; }
        private string colorR { get; set; }
        private string colorG { get; set; }
        private string colorB { get; set; }

        private string seccolorName { get; set; }
        private string secfontName { get; set; }
        private string sectionName { get; set; }
        private string secNumName { get; set; }

        private List<DocOption> alignData { get; set; }
        private List<DocOption> caseData { get; set; }
        private List<DocOption> formatData { get; set; }

        private DocStyleForm parentForm { get; set; }
        private string pathTexFile { get; set; }
        private string sectionType { get; set; }
        private bool isFormLoad { get; set; } = true;

        private string tfFrontOption { get; set; }
        private string tfBackOption { get; set; }

        private bool isInit { get; set; } = true;

        public SectionTab()
        {
            InitializeComponent();
        }

        public SectionTab(string pathfile, string sectype) : this()
        {
            pathTexFile = pathfile;
            sectionType = sectype;
            SetSectionType();
        }

        private void SetSectionType()
        {
            switch (sectionType)
            {
                case "Chapter":
                    sectionName = @"{\chapter}";
                    seccolorName = "{chapcolor}";
                    secfontName = @"\chapfont";
                    secNumName = @"\thechapter";
                    cbCustom.Text = "Custom Chapter Format";
                    break;
                case "Section":
                    sectionName = @"{\section}";
                    seccolorName = "{seccolor}";
                    secfontName = @"\secfont";
                    secNumName = @"\thesection";
                    cbCustom.Text = "Custom Section Format";
                    break;
                case "Subsection":
                    sectionName = @"{\subsection}";
                    seccolorName = "{sseccolor}";
                    secfontName = @"\ssecfont";
                    secNumName = @"\thesubsection";
                    cbCustom.Text = "Custom Subsection Format";
                    break;
                case "Subsubsection":
                    sectionName = @"{\subsubsection}";
                    seccolorName = "{ssseccolor}";
                    secfontName = @"\sssecfont";
                    secNumName = @"\thesubsubsection";
                    cbCustom.Text = "Custom Subsubsection Format";
                    break;
                case "Paragraph":
                    sectionName = @"{\paragraph}";
                    seccolorName = "{parcolor}";
                    secfontName = @"\parfont";
                    secNumName = @"\theparagraph";
                    cbCustom.Text = "Custom Paragraph Format";
                    break;
                case "Subparagraph":
                    sectionName = @"{\subparagraph}";
                    seccolorName = "{sparcolor}";
                    secfontName = @"\sparfont";
                    secNumName = @"\thesubparagraph";
                    cbCustom.Text = "Custom Subparagraph Format";
                    break;
            }
        }

        private void SectionTab_Load(object sender, EventArgs e)
        {
            db = new DbService();

            fontList = new List<string>();
            fontList = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
            cboFont.DataSource = fontList;

            alignData = db.GetDocOptionData(lbAlign.Text);
            cboAlign.DataSource = alignData;
            cboAlign.DisplayMember = Constants.Name;
            cboAlign.ValueMember = Constants.Option;
            cboAlign.SelectedIndex = 0;

            caseData = db.GetDocOptionData(lbCase.Text);
            cboCase.DataSource = caseData;
            cboCase.DisplayMember = Constants.Name;
            cboCase.ValueMember = Constants.Option;
            cboCase.SelectedIndex = 0;

            formatData = db.GetDocOptionData(lbFormat.Text);
            cboFormat.DataSource = formatData;
            cboFormat.DisplayMember = Constants.Name;
            cboFormat.ValueMember = Constants.Option;
            cboFormat.SelectedIndex = 0;

            nudFsize.Value = 16;

            MainService.ChangeControlsEnable(false,
               cboAlign, cboCase, cboFont, nudFsize,
               bnColor, cbUnderline, cbItalic, cbBold, cboFormat);

            tfFrontOption = "";

            colorDialog1.Color = Color.Black;
            colorR = colorDialog1.Color.R.ToString();
            colorG = colorDialog1.Color.G.ToString();
            colorB = colorDialog1.Color.B.ToString();
            fontColor = String.Format("{0},{1},{2}", colorR, colorG, colorB);

            parentForm = this.ParentForm as DocStyleForm;

            isFormLoad = false;


        }

        public void RunSectionPreview()
        {
            try
            {
                string path = pathTexFile + Constants.DocClsName + ".cls";
                string txt = "";
                List<string> lst = new List<string>();
                string fontSize = String.Format("{0}pt", nudFsize.Value.ToString());
                string backskip = String.Format("{0}pt", ((nudFsize.Value * 120) / 100).ToString());
                string alignOption = cboAlign.SelectedValue.ToString();
                string caseOption = cboCase.SelectedValue.ToString();
                string formatOption = "[" + cboFormat.SelectedValue.ToString() + "]";
                string fontSizeOption = String.Format(@"\fontsize{0}{1}\selectfont", "{" + fontSize + "}", "{" + backskip + "}");

                string fontColorDefine = String.Format(Constants.DefineColorCommand, seccolorName, "{" + fontColor + "}");
                string fontColorOption = String.Format(@"\color{0}", seccolorName);

                string fontFamilyValue = "{" + cboFont.SelectedValue.ToString() + "}";
                string fontFamilyDefine = String.Format(Constants.NewFontCommand, secfontName, fontFamilyValue);

                string underlineValue = cbUnderline.Checked ? "[" + @"\titlerule" + "]" : "";

                tfFrontOption = "{" + alignOption + secfontName + fontColorOption + fontSizeOption;
                if (cbBold.Checked)
                    tfFrontOption += @"\bfseries";
                if (cbItalic.Checked)
                    tfFrontOption += @"\itshape";
                tfFrontOption += "}";
                tfBackOption = "{" + caseOption + "}";

                string tfFullOption = String.Format(Constants.TitleFormatCommand, sectionName, formatOption, tfFrontOption, secNumName, tfBackOption, underlineValue);

                using (StreamReader sr = new StreamReader(path))
                {
                    txt = sr.ReadToEnd();
                }

                lst = txt.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                if (cbCustom.Checked)
                {
                    for (var i = 0; i < lst.Count; i++)
                    {
                        if (isInit)
                        {
                            if (lst[i].Contains(Constants.DefineColorBegin))
                            {
                                lst.Insert(i + 1, fontColorDefine);
                            }

                            else if (lst[i].Contains(Constants.NewFontBegin))
                            {
                                lst.Insert(i + 1, fontFamilyDefine);
                            }

                            else if (lst[i].Contains(Constants.TitleFormatBegin))
                            {
                                lst.Insert(i + 1, tfFullOption);
                            }
                        }
                        else
                        {
                            if (lst[i].Contains(String.Format(@"\definecolor{0}", seccolorName)))
                            {
                                lst[i] = fontColorDefine;
                            }

                            else if (lst[i].Contains(String.Format(@"\newfontfamily{0}", secfontName)))
                            {
                                lst[i] = fontFamilyDefine;
                            }

                            else if (lst[i].Contains(String.Format(@"\titleformat{0}", sectionName)))
                            {
                                lst[i] = tfFullOption;
                            }
                        }
                    }
                    isInit = false;

                }
                else
                {
                    for (var i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Contains(String.Format(@"\definecolor{0}", seccolorName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }

                        else if (lst[i].Contains(String.Format(@"\newfontfamily{0}", secfontName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }

                        else if (lst[i].Contains(String.Format(@"\titleformat{0}", sectionName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }
                    }
                    isInit = true;
                }

                txt = String.Join(Environment.NewLine, lst);

                using (var fileStream = new FileStream(path, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(txt);
                }
                parentForm.ReloadPdf = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
                RunSectionPreview();
            }


        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbCustom.Checked;
            MainService.ChangeControlsEnable(isChecked,
               cboAlign, cboCase, cboFont, nudFsize, cboFormat,
               bnColor, cbUnderline, cbItalic, cbBold);
            RunSectionPreview();
        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RunSectionPreview();
        }

        private void nudFsize_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunSectionPreview();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RunSectionPreview();
        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunSectionPreview();
        }
    }
}
