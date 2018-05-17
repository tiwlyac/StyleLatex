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
    public partial class TitleTab : UserControl
    {
        private DbService db { get; set; }

        private List<string> fontList { get; set; }
        private string fontColor { get; set; }
        private string colorR { get; set; }
        private string colorG { get; set; }
        private string colorB { get; set; }

        private string titleColorName { get; set; }
        private string titleFontName { get; set; }
        private string titleName { get; set; }

        private List<DocOption> alignData { get; set; }

        private DocStyleForm parentForm { get; set; }
        private string pathTexFile { get; set; }
        private string titleType { get; set; }
        private bool isFormLoad { get; set; } = true;

        private string PreOption { get; set; }
        private string PostOption { get; set; }

        private bool isInit { get; set; } = true;

        public TitleTab()
        {
            InitializeComponent();
        }

        public TitleTab(string pathfile, string titletype) : this()
        {
            pathTexFile = pathfile;
            titleType = titletype;
            SetTitleType();
        }

        private void SetTitleType()
        {
            switch (titleType)
            {
                case "Title":
                    titleName = "title";
                    titleColorName = "{titlecolor}";
                    titleFontName = @"\titlefont";
                    cbCustom.Text = "Custom Title Format";
                    break;
                case "Author":
                    titleName = "author";
                    titleColorName = "{authercolor}";
                    titleFontName = @"\authorfont";
                    cbCustom.Text = "Custom Author Format";
                    break;
                case "Date":
                    titleName = "date";
                    titleColorName = "{datecolor}";
                    titleFontName = @"\datefont";
                    cbCustom.Text = "Custom Date Format";
                    break;
            }
        }

        private void TitleTab_Load(object sender, EventArgs e)
        {
            db = new DbService();

            fontList = new List<string>();
            fontList = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
            cboFont.DataSource = fontList;

            alignData = db.GetDocOptionData("Title Align");
            cboAlign.DataSource = alignData;
            cboAlign.DisplayMember = Constants.Name;
            cboAlign.ValueMember = Constants.Option;
            cboAlign.SelectedIndex = 0;

            nudFsize.Value = 16;

            MainService.ChangeControlsEnable(false,
               cboAlign, cboFont, nudFsize,
               bnColor, cbUnderline, cbItalic, cbBold);

            PreOption = "";
            PostOption = "";

            colorDialog1.Color = Color.Black;
            colorR = colorDialog1.Color.R.ToString();
            colorG = colorDialog1.Color.G.ToString();
            colorB = colorDialog1.Color.B.ToString();
            fontColor = String.Format("{0},{1},{2}", colorR, colorG, colorB);

            parentForm = this.ParentForm as DocStyleForm;

            isFormLoad = false;


        }

        public void RunTitlePreview()
        {
            try
            {
                string path = pathTexFile + Constants.DocClsName + ".cls";
                string txt = "";
                List<string> lst = new List<string>();
                string fontSize = String.Format("{0}pt", nudFsize.Value.ToString());
                string fontSpace = String.Format("{0}pt", ((nudFsize.Value * 120) / 100).ToString());
                string alignOption = cboAlign.SelectedValue.ToString();
                string fontSizeOption = String.Format(@"\fontsize{0}{1}\selectfont", "{" + fontSize + "}", "{" + fontSpace + "}");

                string fontColorDefine = String.Format(Constants.DefineColorCommand, titleColorName, "{" + fontColor + "}");
                string fontColorOption = String.Format(@"\color{0}", titleColorName);

                string fontFamilyValue = "{" + cboFont.SelectedValue.ToString() + "}";
                string fontFamilyDefine = String.Format(Constants.NewFontCommand, titleFontName, fontFamilyValue);

                PreOption = String.Format(@"\pre{0}",titleName) + "{" + String.Format(@"\begin{0}",alignOption) + titleFontName + fontColorOption + fontSizeOption;
                if (cbBold.Checked)
                    PreOption += @"\bfseries";
                if (cbItalic.Checked)
                    PreOption += @"\itshape";
                if (cbUnderline.Checked)
                    PreOption += @"\underline";
                PreOption += "}";
                PostOption = String.Format(@"\post{0}{{ \par\end{1} }}",titleName,alignOption);

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

                            else if (lst[i].Contains(Constants.PreTitleBegin))
                            {
                                lst.Insert(i + 1, PostOption);
                                lst.Insert(i + 1, PreOption);
                            }
                        }
                        else
                        {
                            if (lst[i].Contains(String.Format(@"\definecolor{0}", titleColorName)))
                            {
                                lst[i] = fontColorDefine;
                            }

                            else if (lst[i].Contains(String.Format(@"\newfontfamily{0}", titleFontName)))
                            {
                                lst[i] = fontFamilyDefine;
                            }

                            else if (lst[i].Contains(String.Format(@"\pre{0}", titleName)))
                            {
                                lst[i] = PreOption;
                            }
                            else if (lst[i].Contains(String.Format(@"\post{0}", titleName)))
                            {
                                lst[i] = PostOption;
                            }
                        }
                    }
                    isInit = false;

                }
                else
                {
                    for (var i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Contains(String.Format(@"\definecolor{0}", titleColorName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }

                        else if (lst[i].Contains(String.Format(@"\newfontfamily{0}", titleFontName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }

                        else if (lst[i].Contains(String.Format(@"\pre{0}", titleName)))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }
                        else if (lst[i].Contains(String.Format(@"\post{0}", titleName)))
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
                RunTitlePreview();
            }


        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbCustom.Checked;
            MainService.ChangeControlsEnable(isChecked,
               cboAlign, cboFont, nudFsize,
               bnColor, cbUnderline, cbItalic, cbBold);
            RunTitlePreview();
        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RunTitlePreview();
        }

        private void nudFsize_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunTitlePreview();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RunTitlePreview();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

