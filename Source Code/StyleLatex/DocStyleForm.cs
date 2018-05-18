using PdfiumViewer;
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
using System.Runtime.InteropServices;

namespace StyleLatex
{
    public partial class DocStyleForm : Form
    {
        #region Members
        private string pathTexFile { get; set; }

        private DbService db { get; set; }
        private bool _reloadPdf;

        public string cls { get; set; } = "article";

        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ReloadPdf
        {
            get
            {
                return _reloadPdf;
            }
            set
            {
                _reloadPdf = value;
                if (_reloadPdf)
                    OpenPdfFile();
            }

        }

        private UserControl layoutTab { get; set; }
        private UserControl chapterTab { get; set; }
        private UserControl sectionTab { get; set; }
        private UserControl subSectionTab { get; set; }
        private UserControl subSubSectionTab { get; set; }
        private UserControl paragraphTab { get; set; }
        private UserControl subParagraphTab { get; set; }

        private UserControl titleTab { get; set; }
        private UserControl authorTab { get; set; }
        private UserControl dateTab { get; set; }

        private UserControl tocTab { get; set; }
        private UserControl lofTab { get; set; }
        private UserControl lotTab { get; set; }

        private UserControl abstactTab { get; set; }
        private UserControl allTocTab { get; set; }

        private UserControl figureTab { get; set; }
        private UserControl tableTab { get; set; }

        private string initText { get; set; }
        private bool isInit { get; set; } = true;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        #region Constructor
        public DocStyleForm()
        {
            InitializeComponent();
            pathTexFile = AppDomain.CurrentDomain.BaseDirectory + Constants.PathDocFile;
            DocPdfViewer.ShowBookmarks = false;
            OpenPdfFile();
            isInit = false;
        }
        #endregion

        #region Loader
        private void DocStyleForm_Load(object sender, EventArgs e)
        {
            db = new DbService();
            initText = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);
            NewLoad();

        }
        #endregion

        #region Functions
        private void NewLoad()
        {

            layoutTab = new LayoutTab(pathTexFile);
            layoutTab.Dock = DockStyle.Fill;

            chapterTab = new SectionTab(pathTexFile, "Chapter");
            chapterTab.Dock = DockStyle.Fill;

            sectionTab = new SectionTab(pathTexFile, "Section");
            sectionTab.Dock = DockStyle.Fill;

            subSectionTab = new SectionTab(pathTexFile, "Subsection");
            subSectionTab.Dock = DockStyle.Fill;

            subSubSectionTab = new SectionTab(pathTexFile, "Subsubsection");
            subSubSectionTab.Dock = DockStyle.Fill;

            paragraphTab = new SectionTab(pathTexFile, "Paragraph");
            paragraphTab.Dock = DockStyle.Fill;

            subParagraphTab = new SectionTab(pathTexFile, "Subparagraph");
            subParagraphTab.Dock = DockStyle.Fill;

            titleTab = new TitleTab(pathTexFile, "Title");
            titleTab.Dock = DockStyle.Fill;

            authorTab = new TitleTab(pathTexFile, "Author");
            authorTab.Dock = DockStyle.Fill;

            dateTab = new TitleTab(pathTexFile, "Date");
            dateTab.Dock = DockStyle.Fill;

            tocTab = new TocTab(pathTexFile, "toc");
            tocTab.Dock = DockStyle.Fill;

            lofTab = new TocTab(pathTexFile, "lof");
            lofTab.Dock = DockStyle.Fill;

            lotTab = new TocTab(pathTexFile, "lot");
            lotTab.Dock = DockStyle.Fill;

            abstactTab = new AbstractTab(pathTexFile);
            abstactTab.Dock = DockStyle.Fill;

            allTocTab = new AllTocTab(pathTexFile);
            allTocTab.Dock = DockStyle.Fill;

            figureTab = new FigureTab(pathTexFile, "figure");
            figureTab.Dock = DockStyle.Fill;

            tableTab = new FigureTab(pathTexFile, "table");
            tableTab.Dock = DockStyle.Fill;

            tvMenu.SelectedNode = null;
        }

        [STAThread]
        private void OpenPdfFile()
        {
            if (!isInit)
            {
                Cursor.Hide();
                Cursor.Position = new Point(800, 400);
                LoadingForm.ShowSplashScreen();
            }
            DocPdfViewer.Document?.Dispose();
            MainService.ExecuteLatexCommand(pathTexFile, cls);
            DocPdfViewer.Document = OpenDocument(pathTexFile + cls + "_preview" + ".pdf");
            ReloadPdf = false;
            if (!isInit)
            {
                LoadingForm.CloseForm();
                Cursor.Show();
            }
        }

        public string GetCls()
        {
            return cls;
        }

        public void ChangeBaseClass(string baseCls)
        {
            try
            {
                TreeNode chapterNode = new TreeNode();
                chapterNode.Name = "tnChapter";
                chapterNode.Text = "Chapter Style";
                List<string> lst = new List<string>();
                string txt = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);
                lst = txt.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                int findIndex = -1;

                if (baseCls == "article")
                {
                    cls = "article";

                    if (tvMenu.Nodes["tnChapter"] != null)
                        tvMenu.Nodes["tnChapter"].Remove();

                    findIndex = lst.FindIndex(x => x.StartsWith(@"\renewcommand\abstractname"));
                    if (findIndex >= 0)
                    {
                        if (lst[findIndex].Contains(@"\flushleft"))
                        {
                            lst[findIndex] = lst[findIndex].Replace(@"}}", @"}\hfill}");
                            lst[findIndex] = lst[findIndex].Replace(@"\flushleft", "");
                        }
                        else if (lst[findIndex].Contains(@"\flushright)"))
                        {
                            lst[findIndex] = lst[findIndex].Replace(@"\flushright", @"\hfill");
                        }
                        else
                        {
                            lst[findIndex] = lst[findIndex].Replace(@"}}", @"}\hfill}");
                            lst[findIndex] = lst[findIndex].Replace(@"\renewcommand\abstractname{", @"\renewcommand\abstractname{\hfill");
                        }

                    }

                }
                else if (baseCls == "report")
                {
                    cls = "report";

                    if (tvMenu.Nodes["tnChapter"] == null)
                    {
                        chapterTab = new SectionTab(pathTexFile, "Chapter");
                        tvMenu.Nodes.Insert(4, chapterNode);
                    }

                    findIndex = lst.FindIndex(x => x.StartsWith(@"\renewcommand\abstractname"));
                    if (findIndex >= 0)
                    {
                        if (lst[findIndex].Contains(@"{\hfill") && lst[findIndex].Contains(@"\hfill}"))
                            lst[findIndex] = lst[findIndex].Replace(@"\hfill", "");
                        else if (lst[findIndex].Contains(@"{\hfill"))
                            lst[findIndex] = lst[findIndex].Replace(@"\hfill", @"\flushright");
                        else if (lst[findIndex].Contains(@"\hfill}"))
                        {
                            lst[findIndex] = lst[findIndex].Replace(@"\hfill}", "}");
                            lst[findIndex] = lst[findIndex].Replace(@"\renewcommand\abstractname{", @"\renewcommand\abstractname{\flushleft");
                        }

                    }
                }

                txt = String.Join(Environment.NewLine, lst);
                MainService.WriteLatexFile(Constants.DocClsName, ".cls", pathTexFile, txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Control Events
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.Equals("tnLayout"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(layoutTab);
                pnlDocTabMenu.AutoScroll = true;
                layoutTab.Show();
                return;
            }

            if (e.Node.Name.Equals("tnAbstract"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(abstactTab);
                pnlDocTabMenu.AutoScroll = true;
                abstactTab.Show();
                return;
            }

            if (e.Node.Name.Equals("tnChapter"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(chapterTab);
                pnlDocTabMenu.AutoScroll = true;
                chapterTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndSec"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(sectionTab);
                pnlDocTabMenu.AutoScroll = true;
                sectionTab.Show();
                return;
            }


            if (e.Node.Name.Equals("ndSubSec"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(subSectionTab);
                pnlDocTabMenu.AutoScroll = true;
                subSectionTab.Show();
                return;
            }


            if (e.Node.Name.Equals("ndSubSubSec"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(subSubSectionTab);
                pnlDocTabMenu.AutoScroll = true;
                subSubSectionTab.Show();
                return;
            }


            if (e.Node.Name.Equals("ndPar"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(paragraphTab);
                pnlDocTabMenu.AutoScroll = true;
                paragraphTab.Show();
                return;
            }


            if (e.Node.Name.Equals("ndSubPar"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(subParagraphTab);
                pnlDocTabMenu.AutoScroll = true;
                subParagraphTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndTitle"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(titleTab);
                pnlDocTabMenu.AutoScroll = true;
                titleTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndAuthor"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(authorTab);
                pnlDocTabMenu.AutoScroll = true;
                authorTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndDate"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(dateTab);
                pnlDocTabMenu.AutoScroll = true;
                dateTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndToc"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(tocTab);
                pnlDocTabMenu.AutoScroll = true;
                tocTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndLof"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(lofTab);
                pnlDocTabMenu.AutoScroll = true;
                lofTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndLot"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(lotTab);
                pnlDocTabMenu.AutoScroll = true;
                lotTab.Show();
                return;
            }

            if (e.Node.Name.Equals("ndAllToc"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(allTocTab);
                pnlDocTabMenu.AutoScroll = true;
                allTocTab.Show();
                return;
            }

            if (e.Node.Name.Equals("tnFigure"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(figureTab);
                pnlDocTabMenu.AutoScroll = true;
                figureTab.Show();
                return;
            }

            if (e.Node.Name.Equals("tnTable"))
            {
                pnlDocTabMenu.Controls.Clear();
                pnlDocTabMenu.Controls.Add(tableTab);
                pnlDocTabMenu.AutoScroll = true;
                tableTab.Show();
                return;
            }
        }

        private void bnSaveCls_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.cls";
            saveFileDialog.DefaultExt = "cls";
            saveFileDialog.Filter = "LaTeX class file (*.cls) | *.cls";
            DialogResult saveResult = saveFileDialog.ShowDialog();

            if (saveResult == DialogResult.OK)
            {
                string filename = Path.GetFileName(saveFileDialog.FileName);
                string path = pathTexFile + Constants.DocClsName + ".cls";
                string txtCls = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    txtCls = sr.ReadToEnd();
                }
                List<string> lst = new List<string>();
                lst = txtCls.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                for (var i = 0; i < lst.Count; i++)
                {
                    if (lst[i].StartsWith(@"\ProvidesClass"))
                    {
                        lst[i] = String.Format(@"\ProvidesClass{{{0}}}", filename);
                        break;
                    }
                }

                txtCls = String.Join(Environment.NewLine, lst);

                using (Stream fileStream = saveFileDialog.OpenFile())
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(txtCls);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start the new document style ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pnlDocTabMenu.Controls.Clear();
                MainService.WriteLatexFile(Constants.DocClsName, ".cls", pathTexFile, initText);
                OpenPdfFile();
                NewLoad();
                //do something
            }
        }

        #endregion
    }
}
