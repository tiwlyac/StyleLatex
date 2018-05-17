using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleLatex.Helper;
using StyleLatex.Models;
using StyleLatex.DocTabMenu;
using System.IO;
using PdfiumViewer;

namespace StyleLatex.DocTabMenu
{
    public partial class LayoutTab : UserControl
    {
        #region Members
        private DbService db { get; set; }
        private string clsText { get; set; }

        private List<DocOption> pageSizeData { get; set; }
        private List<DocOption> orientationData { get; set; }
        private List<DocOption> columnData { get; set; }
        private List<DocOption> clsData { get; set; }
        private List<LengthUnit> unitData { get; set; }

        private List<string> fontList { get; set; }
        private string fontColor { get; set; }
        private string colorR { get; set; }
        private string colorG { get; set; }
        private string colorB { get; set; }

        private string geometryOption { get; set; }
        private string clsOption { get; set; }

        private string pathTexFile { get; set; }
        private DocStyleForm parentForm { get; set; }

        private bool isFormLoad { get; set; } = true;
        private bool isInit { get; set; } = true;
        #endregion

        #region Constructor
        public LayoutTab()
        {
            InitializeComponent();
        }

        public LayoutTab(string pathfile) : this()
        {
            pathTexFile = pathfile;
        }
        #endregion

        #region Loader
        private void LayoutTab_Load(object sender, EventArgs e)
        {
            db = new DbService();

            pageSizeData = db.GetDocOptionData(lbPageSize.Text);
            cboPageSize.DataSource = pageSizeData;
            cboPageSize.DisplayMember = Constants.Name;
            cboPageSize.ValueMember = Constants.Option;
            cboPageSize.SelectedIndex = 0;

            orientationData = db.GetDocOptionData(lbOrientation.Text); ;
            cboOrientation.DataSource = orientationData;
            cboOrientation.DisplayMember = Constants.Name;
            cboOrientation.ValueMember = Constants.Option;
            cboOrientation.SelectedIndex = 0;

            columnData = db.GetDocOptionData(lbColumn.Text);
            cboColumn.DataSource = columnData;
            cboColumn.DisplayMember = Constants.Name;
            cboColumn.ValueMember = Constants.Option;
            cboColumn.SelectedIndex = 0;

            clsData = db.GetDocOptionData(lbCls.Text);
            cboCls.DataSource = clsData;
            cboCls.DisplayMember = Constants.Name;
            cboCls.ValueMember = Constants.Option;
            cboCls.SelectedIndex = 0;

            fontList = new List<string>();
            fontList = FontFamily.Families.Select(x => x.Name).Where(x => !x.Contains("Bahnschrift")).ToList();
            cboFont.DataSource = fontList;

            unitData = new List<LengthUnit>() {
                new LengthUnit {name = "inch" , unit = "in" },
                new LengthUnit {name = "cm" , unit = "cm" },
                new LengthUnit {name = "mm" , unit = "mm" }
            };

            BindingSource topData = new BindingSource();
            BindingSource bottomData = new BindingSource();
            BindingSource leftData = new BindingSource();
            BindingSource rightData = new BindingSource();

            topData.DataSource = unitData;
            bottomData.DataSource = unitData;
            leftData.DataSource = unitData;
            rightData.DataSource = unitData;

            cboTop.DataSource = topData;
            cboTop.DisplayMember = Constants.Name;
            cboTop.ValueMember = Constants.Unit;
            cboTop.SelectedIndex = 0;

            cboLeft.DataSource = leftData;
            cboLeft.DisplayMember = Constants.Name;
            cboLeft.ValueMember = Constants.Unit;
            cboLeft.SelectedIndex = 0;

            cboRight.DataSource = rightData;
            cboRight.DisplayMember = Constants.Name;
            cboRight.ValueMember = Constants.Unit;
            cboRight.SelectedIndex = 0;

            cboBottom.DataSource = bottomData;
            cboBottom.DisplayMember = Constants.Name;
            cboBottom.ValueMember = Constants.Unit;
            cboBottom.SelectedIndex = 0;


            nudTop.Value = 1;
            nudBottom.Value = 1;
            nudLeft.Value = 1;
            nudRight.Value = 1;

            nudFsize.Value = 16;

            cbCustom.Checked = false;
            cbSetFont.Checked = false;

            MainService.ChangeControlsEnable(false,
                 cboTop, cboRight, cboLeft, cboBottom,
                nudTop, nudLeft, nudRight, nudBottom,
                cboFont, nudFsize, bnColor);


            geometryOption = "";
            clsOption = "";

            colorDialog1.Color = Color.Black;
            colorR = colorDialog1.Color.R.ToString();
            colorG = colorDialog1.Color.G.ToString();
            colorB = colorDialog1.Color.B.ToString();
            fontColor = String.Format("{0},{1},{2}", colorR, colorG, colorB);

            parentForm = this.ParentForm as DocStyleForm;
            isFormLoad = false;

            RunLayoutPreview();

        }
        #endregion

        #region Functions
        public void RunLayoutPreview()
        {
            try
            {

                string path = pathTexFile + Constants.DocClsName + ".cls";
                string txt = "";
               
                string strSize = cboPageSize.SelectedValue.ToString();
                string strOrientation = cboOrientation.SelectedValue.ToString() != "" ? "," + cboOrientation.SelectedValue.ToString() : cboOrientation.SelectedValue.ToString();
                string strColumn = cboColumn.SelectedValue.ToString();
                string valTop, valLeft, valRight, valBottom, strMargin = "";
                string unitTop, unitLeft, unitRight, unitBottom = "";
                string fontSize = nudFsize.Value.ToString();
                string baseSkip = (nudFsize.Value * 120 / 100).ToString();

                string fontColorDefine = String.Format(Constants.DefineColorCommand, "{maincolor}", "{" + fontColor + "}");
                string fontColorOption = String.Format(@"\color{0}", "{maincolor}");

                string fontFamilyValue = "{" + cboFont.SelectedValue.ToString() + "}";
                


                if (cbCustom.Checked)
                {

                    unitTop = cboTop.SelectedValue.ToString();
                    unitLeft = cboLeft.SelectedValue.ToString();
                    unitRight = cboRight.SelectedValue.ToString();
                    unitBottom = cboBottom.SelectedValue.ToString();

                    valTop = nudTop.Value.ToString();
                    valLeft = nudLeft.Value.ToString();
                    valRight = nudRight.Value.ToString();
                    valBottom = nudBottom.Value.ToString();

                    strMargin = String.Format(",top={0}{1},left={2}{3},right={4}{5},bottom={6}{7}"
                        , valTop, unitTop
                        , valLeft, unitLeft
                        , valRight, unitRight
                        , valBottom, unitBottom);
                }
                geometryOption = String.Format("[{0}{1}{2}]", strSize, strOrientation, strMargin);
                clsOption = strColumn != "" ? String.Format("[{0}]", strColumn) : strColumn;
                List<string> lst = new List<string>();

                string clsValue = cboCls.SelectedValue.ToString();

                using (StreamReader sr = new StreamReader(path))
                {
                    txt = sr.ReadToEnd();
                }

                lst = txt.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                for (var i = 0; i < lst.Count; i++)
                {
                    if (lst[i].StartsWith("\\" + Constants.LoadClass))
                    {
                        lst[i] = String.Format("\\LoadClass{0}{{{1}}}", clsOption, clsValue);
                    }

                    else if (lst[i].EndsWith(Constants.Geometry))
                    {
                        lst[i] = String.Format("\\RequirePackage{0}{1}", geometryOption, Constants.Geometry);
                    }

                    if (cbSetFont.Checked)
                    {
                        if (isInit)
                        {
                            if (lst[i].Contains(Constants.DefineColorBegin))
                            {
                                lst.Insert(i + 1, String.Format(Constants.DefineColorCommand, "{maincolor}", "{" + fontColor + "}"));
                            }

                            else if (lst[i].Contains(Constants.MainFontBegin))
                            {
                                lst.Insert(i + 1, String.Format(Constants.ColorCommand, "{maincolor}"));
                                lst.Insert(i + 1, String.Format(Constants.MainFontCommand, fontFamilyValue , fontSize));
                                lst.Insert(i + 1, String.Format(Constants.FontSizeSecTocCommand, fontSize, baseSkip));
                            }
                        }
                        else
                        {
                            if (lst[i].Contains(String.Format(@"\definecolor{0}", "{maincolor}")))
                            {
                                lst[i] = String.Format(Constants.DefineColorCommand, "{maincolor}", "{" + fontColor + "}");
                            }
                            else if (lst[i].Contains(@"\setmainfont"))
                            {
                                lst[i] = String.Format(Constants.MainFontCommand, fontFamilyValue , fontSize);
                            }
                            else if (lst[i].Contains(@"%mainfont.size"))
                            {
                                lst[i] = String.Format(Constants.FontSizeSecTocCommand, fontSize, baseSkip);
                            }
                        }
                    }
                    else
                    {
                        if (lst[i].Contains(String.Format(@"\definecolor{0}", "{maincolor}")))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }
                        else if (lst[i].Contains(@"\setmainfont"))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }
                        else if (lst[i].StartsWith(@"\color"))
                        {
                            lst.RemoveAt(i);
                            i--;
                        }
                        else if (lst[i].Contains(@"%mainfont.size"))
                        {
                            lst.RemoveAt(i);
                            i--; ;
                        }

                    }
                }
                isInit = !cbSetFont.Checked;

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
        #endregion

        #region Control Events
        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RunLayoutPreview();
        }

        private void UnitComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NumericUpDown[] nudList = new NumericUpDown[] { nudTop, nudLeft, nudRight, nudBottom };
            ComboBox[] cboList = new ComboBox[] { cboTop, cboLeft, cboRight, cboBottom };

            for (int i = 0; i < nudList.Length; i++)
            {
                if (cboList[i].SelectedValue.Equals("in"))
                {
                    nudList[i].Maximum = 4;
                }
                else if (cboList[i].SelectedValue.Equals("cm"))
                {
                    nudList[i].Maximum = 10;
                }
                else if (cboList[i].SelectedValue.Equals("mm"))
                {
                    nudList[i].Maximum = 100;
                }
            }
            RunLayoutPreview();
        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbCustom.Checked;
            MainService.ChangeControlsEnable(isChecked,
                cboTop, cboRight, cboLeft, cboBottom,
                nudTop, nudLeft, nudRight, nudBottom);

            RunLayoutPreview();
        }

        private void LengthValues_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunLayoutPreview();
        }
        #endregion

        private void nudFsize_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunLayoutPreview();
        }

        private void cbSetFont_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbSetFont.Checked;
            MainService.ChangeControlsEnable(isChecked,
            cboFont, nudFsize, bnColor);

            RunLayoutPreview();
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
                RunLayoutPreview();
            }
        }

        private void cboCls_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void cboCls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                clsText = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);

                int findIndex = -1;
                List<string> lst = new List<string>();
                lst = clsText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                findIndex = lst.FindIndex(x => x.Contains(@"\definecolor{chapcolor}"));

                if (findIndex >= 0)
                    lst.RemoveAt(findIndex);

                findIndex = lst.FindIndex(x => x.Contains(@"\newfontfamily{chapfont}"));

                if (findIndex >= 0)
                    lst.RemoveAt(findIndex);

                findIndex = lst.FindIndex(x => x.Contains(@"\titleformat{\chapter}"));

                if (findIndex >= 0)
                    lst.RemoveAt(findIndex);

                clsText = String.Join(Environment.NewLine, lst);

                MainService.WriteLatexFile(Constants.DocClsName, ".cls", pathTexFile, clsText);

                string cls = cboCls.SelectedValue.ToString();
                parentForm.ChangeBaseClass(cls);
                RunLayoutPreview();
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunLayoutPreview();
        }

        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
                RunLayoutPreview();
        }
    }
}
