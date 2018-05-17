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
    public partial class TocTab : UserControl
    {
        private DbService db { get; set; }
        private string clsText { get; set; }

        private string pathTexFile { get; set; }
        private string tocType { get; set; }

        private string tocName { get; set; }
        private string tocColorName { get; set; }
        private string tocFontName { get; set; }

        private List<string> fontList { get; set; }
        private List<string> fontListL { get; set; }
        private List<string> fontListR { get; set; }

        private string fontColor { get; set; }
        private string fontColorLeft { get; set; }
        private string fontColorRight { get; set; }

        private string colorR { get; set; }
        private string colorG { get; set; }
        private string colorB { get; set; }

        private string colorLeftR { get; set; }
        private string colorLeftG { get; set; }
        private string colorLeftB { get; set; }

        private string colorRightR { get; set; }
        private string colorRightG { get; set; }
        private string colorRightB { get; set; }

        private string tmpLeftText { get; set; } = "";
        private string tmpRightText { get; set; } = "";

        private List<DocOption> alignData { get; set; }

        private DocStyleForm parentForm { get; set; }

        private bool isFormLoad { get; set; } = true;

        private bool isInit { get; set; } = true;

        private string tmpText { get; set; }

        public TocTab()
        {
            InitializeComponent();
        }

        private void setTocType()
        {
            switch (tocType)
            {
                case "toc":
                    tocName = @"\contentsname";
                    tocColorName = "{toccolor}";
                    tocFontName = @"\tocfont";
                    tmpText = "Contents";
                    txtHead.Text = "Contents";
                    grpToc.Text = "Text above a table of contents";
                    break;
                case "lof":
                    tocName = @"\listfigurename";
                    tocColorName = "{lofcolor}";
                    tocFontName = @"\loffont";
                    tmpText = "Figures";
                    txtHead.Text = "Figures";
                    grpToc.Text = "Text above a list of figures";
                    lbDepth.Visible = false;
                    nudDepth.Enabled = false;
                    nudDepth.Visible = false;
                    break;
                case "lot":
                    tocName = @"\listtablename";
                    tocColorName = "{lotcolor}";
                    tocFontName = @"\lotfont";
                    tmpText = "Tables";
                    txtHead.Text = "Tables";
                    grpToc.Text = "Text above a list of tables";
                    lbDepth.Visible = false;
                    nudDepth.Enabled = false;
                    nudDepth.Visible = false;
                    break;
            }
        }

        private void readClsFile()
        {
            string path = pathTexFile + Constants.DocClsName + ".cls";

            using (StreamReader sr = new StreamReader(path))
            {
                clsText = sr.ReadToEnd();
            }

        }

        private void writeClsFile()
        {
            string path = pathTexFile + Constants.DocClsName + ".cls";

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(clsText);
            }
        }

        private string setAlignText(string headText)
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
            return headText;
        }

        private string setSpecialFormat(string txt)
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

        private string setFormatLeft(string txt)
        {
            if (cbUnderlineLeft.Checked)
            {
                txt = @"\underline" + txt;
            }
            if (cbBoldLeft.Checked)
            {
                txt = @"\bfseries" + txt;
            }
            if (cbItalicLeft.Checked)
            {
                txt = @"\itshape" + txt;
            }

            string fontSize = "{" + nudLeft.Value.ToString() + "}";
            string backSkip = "{" + (nudLeft.Value * 120 / 100).ToString() + "}";

            txt = String.Format(@"\fontsize{0}{1}\selectfont\leftfont\color{{leftcolor}}",
                fontSize, backSkip) + txt;

            return "{" + txt + "}";
        }

        private string setFormatRight(string txt)
        {
            if (cbUnderlineRight.Checked)
            {
                txt = @"\underline" + txt;
            }
            if (cbBoldRight.Checked)
            {
                txt = @"\bfseries" + txt;
            }
            if (cbItalicRight.Checked)
            {
                txt = @"\itshape" + txt;
            }

            string fontSize = "{" + nudRight.Value.ToString() + "}";
            string backSkip = "{" + (nudRight.Value * 120 / 100).ToString() + "}";

            txt = String.Format(@"\fontsize{0}{1}\selectfont\rightfont\color{{rightcolor}}",
                fontSize, backSkip) + txt;

            return "{" + txt + "}";
        }

        private void runPreview(string mode)
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

                string fontColorDefine = String.Format(Constants.DefineColorCommand, tocColorName, "{" + fontColor + "}");
                string fontColorOption = String.Format(@"\color{0}", tocColorName);

                string fontFamilyValue = "{" + cboFont.SelectedValue.ToString() + "}";
                string fontFamilyDefine = String.Format(Constants.NewFontCommand, tocFontName, fontFamilyValue);

                //Text Above
                bool checkLeft = String.IsNullOrEmpty(tmpLeftText) || String.IsNullOrWhiteSpace(tmpLeftText);
                bool checkRight = String.IsNullOrEmpty(tmpRightText) && String.IsNullOrWhiteSpace(tmpRightText);
                string leftText = "";
                string rightText = "";
                string leftColorName = "{leftcolor}";
                string rightColorName = "{rightcolor}";
                string leftFontName = @"\leftfont";
                string rightFontName = @"\rightfont";

                string fontColorLeftDefine = String.Format(Constants.DefineColorCommand, leftColorName, "{" + fontColorLeft + "}");
                string fontColorRightDefine = String.Format(Constants.DefineColorCommand, rightColorName, "{" + fontColorRight + "}");

                string fontFamilyLeftValue = "{" + cboLeftFont.SelectedValue.ToString() + "}";
                string fontFamilyLeftDefine = String.Format(Constants.NewFontCommand, leftFontName, fontFamilyLeftValue);
                string fontFamilyRightValue = "{" + cboRightFont.SelectedValue.ToString() + "}";
                string fontFamilyRightDefine = String.Format(Constants.NewFontCommand, rightFontName, fontFamilyRightValue);

                int findIndex = -1;

                readClsFile();

                lst = clsText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                if (mode == lbHead.Text)
                {
                    if (cbCustom.Checked)
                    {
                        txt = "{" + tmpText + "}";
                        txt = setSpecialFormat(txt);
                        txt = tocFontName + fontColorOption + fontSizeOption + txt;
                        txt = setAlignText(txt);
                        resultTxt = String.Format(Constants.ContentNameFormat, tocName, txt);

                        if (isInit)
                        {
                            findIndex = lst.FindIndex(x => x.Contains(Constants.NewFontBegin));
                            lst.Insert(findIndex + 1, fontFamilyDefine);
                        }
                        else
                        {
                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", tocColorName)));
                            lst[findIndex] = fontColorDefine;

                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", tocFontName)));
                            lst[findIndex] = fontFamilyDefine;
                        }

                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewcommand{0}", tocName)));
                        lst[findIndex] = resultTxt;

                        isInit = false;
                    }
                    else
                    {
                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", tocColorName)));
                        lst[findIndex] = String.Format(Constants.ContentColorDefault, tocColorName);

                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", tocFontName)));
                        lst.RemoveAt(findIndex);

                        resultTxt = String.Format(Constants.ContentNameDefault, tocName, tocColorName, tmpText);
                        findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\renewcommand{0}", tocName)));
                        lst[findIndex] = resultTxt;
                        txtHead.Text = tmpText;

                        isInit = true;
                    }
                    txtHead.Text = tmpText;
                }
                else if (mode == "Text Above")
                {

                    if (checkLeft)
                    {
                        findIndex = lst.FindIndex(x => x.Contains(@"\definecolor{leftcolor}"));
                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                        findIndex = lst.FindIndex(x => x.Contains(@"\newfontfamily\leftfont"));
                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                    }

                    if (checkRight)
                    {
                        findIndex = lst.FindIndex(x => x.Contains(@"\definecolor{rightcolor}"));
                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                        findIndex = lst.FindIndex(x => x.Contains(@"\newfontfamily\rightfont"));
                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                    }

                    if (checkLeft && checkRight)
                    {
                        findIndex = lst.FindIndex(x => x.Contains(String.Format("%text.above.{0}", tocType)));

                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                    }
                    else
                    {
                        if (!checkLeft)
                        {
                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", leftColorName)));
                            if (findIndex >= 0)
                            {
                                lst[findIndex] = fontColorLeftDefine;
                            }
                            else
                            {
                                findIndex = lst.FindIndex(x => x.Contains(Constants.DefineColorBegin));
                                lst.Insert(findIndex + 1, fontColorLeftDefine);
                            }

                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", leftFontName)));
                            if (findIndex >= 0)
                            {
                                lst[findIndex] = fontFamilyLeftDefine;
                            }
                            else
                            {
                                findIndex = lst.FindIndex(x => x.Contains(Constants.NewFontBegin));
                                lst.Insert(findIndex + 1, fontFamilyLeftDefine);
                            }


                            leftText = setFormatLeft("{" + tmpLeftText + "}");
                        }

                        if (!checkRight)
                        {
                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\definecolor{0}", rightColorName)));
                            if (findIndex >= 0)
                            {
                                lst[findIndex] = fontColorRightDefine;
                            }
                            else
                            {
                                findIndex = lst.FindIndex(x => x.Contains(Constants.DefineColorBegin));
                                lst.Insert(findIndex + 1, fontColorRightDefine);
                            }

                            findIndex = lst.FindIndex(x => x.Contains(String.Format(@"\newfontfamily{0}", rightFontName)));
                            if (findIndex >= 0)
                            {
                                lst[findIndex] = fontFamilyRightDefine;
                            }
                            else
                            {
                                findIndex = lst.FindIndex(x => x.Contains(Constants.NewFontBegin));
                                lst.Insert(findIndex + 1, fontFamilyRightDefine);
                            }

                            rightText = setFormatRight("{" + tmpRightText + "}");
                        }

                        findIndex = lst.FindIndex(x => x.Contains(String.Format("%text.above.{0}", tocType)));

                        if (findIndex >= 0)
                        {
                            lst[findIndex] = String.Format(Constants.TextAboveFormat, tocType, leftText, rightText);
                        }
                        else
                        {
                            findIndex = lst.FindIndex(x => x.Contains("%textabovetoc"));
                            lst.Insert(findIndex + 1, String.Format(Constants.TextAboveFormat, tocType, leftText, rightText));
                        }
                    }

                    txtLeft.Text = tmpLeftText;
                    txtRight.Text = tmpRightText;
                }
                else if (mode == "Depth")
                {
                    findIndex = lst.FindIndex(x => x.Contains(@"\setcounter{tocdepth}"));
                    lst[findIndex] = String.Format(@"\setcounter{{tocdepth}}{{{0}}}", nudDepth.Value.ToString());
                }

                clsText = String.Join(Environment.NewLine, lst);

                writeClsFile();

                parentForm.ReloadPdf = true;
            }catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public TocTab(string path, string toc) : this()
        {
            pathTexFile = path;
            tocType = toc;
            setTocType();
        }

        private void TocTab_Load(object sender, EventArgs e)
            {
                db = new DbService();

                fontList = new List<string>();
                fontList = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
                cboFont.DataSource = fontList;

                fontListL = new List<string>();
                fontListL = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
                cboLeftFont.DataSource = fontListL;

                fontListR = new List<string>();
                fontListR = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
                cboRightFont.DataSource = fontListR;

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
                    bnColor, cbUnderline, cbItalic, cbBold,
                    cboLeftFont, btnColorLeft, nudLeft,
                    cbBoldLeft, cbUnderlineLeft, cbItalicLeft,
                    cboRightFont, btnColorRight, nudRight,
                    cbBoldRight, cbUnderlineRight, cbItalicRight);

                colorDialog1.Color = Color.Black;
                colorR = colorDialog1.Color.R.ToString();
                colorG = colorDialog1.Color.G.ToString();
                colorB = colorDialog1.Color.B.ToString();

                cdLeft.Color = Color.Black;
                colorLeftR = cdLeft.Color.R.ToString();
                colorLeftG = cdLeft.Color.G.ToString();
                colorLeftB = cdLeft.Color.B.ToString();

                cdRight.Color = Color.Black;
                colorRightR = cdRight.Color.R.ToString();
                colorRightG = cdRight.Color.G.ToString();
                colorRightB = cdRight.Color.B.ToString();

                fontColor = String.Format("{0} ,{1} ,{2}", colorR, colorG, colorB);
                fontColorLeft = String.Format("{0} ,{1} ,{2}", colorLeftR, colorLeftG, colorLeftB);
                fontColorRight = String.Format("{0} ,{1} ,{2}", colorRightR, colorRightG, colorRightB);

                nudDepth.Value = 3;
                nudDepth.Minimum = 1;
                nudDepth.Maximum = 5;

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

        private void nudFsize_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview(lbHead.Text);
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            runPreview(lbHead.Text);
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            runPreview(lbHead.Text);
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            runPreview(lbHead.Text);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            runPreview(lbHead.Text);
        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbCustom.Checked;
            MainService.ChangeControlsEnable(isChecked,
               btnHead, txtHead, cboFont, nudFsize, cboAlign,
               bnColor, cbUnderline, cbItalic, cbBold);
            runPreview(lbHead.Text);
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            tmpText = txtHead.Text;
            runPreview(lbHead.Text);

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

        private void txtHead_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview(lbHead.Text);
        }

        private void txtLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLeft.Text) || String.IsNullOrWhiteSpace(txtLeft.Text))
            {
                MainService.ChangeControlsEnable(false, cbBoldLeft, cbItalicLeft, cbUnderlineLeft, cboLeftFont, btnColorLeft, nudLeft);
            }
            else
            {
                MainService.ChangeControlsEnable(true, cbBoldLeft, cbItalicLeft, cbUnderlineLeft, cboLeftFont, btnColorLeft, nudLeft);
            }

            tmpLeftText = txtLeft.Text;
            runPreview("Text Above");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tmpRightText = txtRight.Text;
            runPreview("Text Above");

            if (String.IsNullOrEmpty(txtRight.Text) || String.IsNullOrWhiteSpace(txtRight.Text))
            {
                MainService.ChangeControlsEnable(false, cbBoldRight, cbItalicRight, cbUnderlineRight, cboRightFont, btnColorRight, nudRight);
            }
            else
            {
                MainService.ChangeControlsEnable(true, cbBoldRight, cbItalicRight, cbUnderlineRight, cboRightFont, btnColorRight, nudRight);
            }
        }

        private void Left_CheckedChanged(object sender, EventArgs e)
        {
            runPreview("Text Above");
        }

        private void Right_CheckedChanged(object sender, EventArgs e)
        {
            runPreview("Text Above");
        }

        private void cbHyperlink_CheckedChanged(object sender, EventArgs e)
        {
            runPreview("Hyperlink");
        }

        private void nudDepth_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview("Depth");
        }

        private void nudLeft_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview("Text Above");
        }

        private void nudRight_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview("Text Above");
        }

        private void btnColorLeft_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = cdLeft.ShowDialog();

            if (colorResult == DialogResult.OK)
            {
                colorLeftR = cdLeft.Color.R.ToString();
                colorLeftG = cdLeft.Color.G.ToString();
                colorLeftB = cdLeft.Color.B.ToString();
                fontColorLeft = String.Format("{0},{1},{2}", colorLeftR, colorLeftG, colorLeftB);
                btnColorLeft.BackColor = cdLeft.Color;
            }

            runPreview("Text Above");
        }

        private void btnColorRight_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = cdRight.ShowDialog();

            if (colorResult == DialogResult.OK)
            {
                colorRightR = cdRight.Color.R.ToString();
                colorRightG = cdRight.Color.G.ToString();
                colorRightB = cdRight.Color.B.ToString();
                fontColorRight = String.Format("{0},{1},{2}", colorRightR, colorRightG, colorRightB);
                btnColorRight.BackColor = cdRight.Color;
            }

            runPreview("Text Above");
        }

        private void cboRightFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview("Text Above");
        }

        private void cboLeftFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                runPreview("Text Above");
        }
    }
}
