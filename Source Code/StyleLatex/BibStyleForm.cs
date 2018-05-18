using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleLatex.Helper;
using System.IO;
using StyleLatex.Models;
using StyleLatex.BibTabMenu;
using System.Data.SQLite;

namespace StyleLatex
{
    public partial class BibStyleForm : Form
    {
        private string pathTexFile { get; set; }
        private string pathBibFile { get; set; }

        private string bstText { get; set; }

        private List<BibEntry> entryList { get; set; }

        private List<EntryMenu> entryMenu { get; set; }

        private UserControl authorTab { get; set; }
        private UserControl editorTab { get; set; }
        private UserControl citationTab { get; set; }

        private bool isEntryChange { get; set; } = false;
        private bool _reloadPdf;

        private bool isLoad { get; set; } = true;
        private bool isInit { get; set; } = true;

        private string initText { get; set; }
        private string initBib { get; set; }

        private DbService db { get; set; }

        private string formatFunction =
                "FUNCTION {{format.{0}.{1}}}" + Environment.NewLine +
                "{{ {1} empty$" + Environment.NewLine +
                "    {{ \"\" }}" + Environment.NewLine +
                "    {{" + Environment.NewLine +
                "       %prefix.{0}.{1}" + Environment.NewLine +
                "       {2} %field.{0}.{1}" + Environment.NewLine +
                "       %suffix.{0}.{1}" + Environment.NewLine +
                "       \". \" %end.{0}.{1}" + Environment.NewLine +
                "       * %concat.{0}.{1}" + Environment.NewLine +
                "    }}" + Environment.NewLine +
                "  if$" + Environment.NewLine +
                "}}";

        private string entryFunction =
                "FUNCTION {{{0}}}" + Environment.NewLine +
                "{{" + Environment.NewLine +
                " output.bibitem" + Environment.NewLine +
                " {1}" +
                " %{0}.new.write" + Environment.NewLine +
                " fin.entry" + Environment.NewLine +
                "}}";

        public BibStyleForm()
        {
            InitializeComponent();
            pathBibFile = AppDomain.CurrentDomain.BaseDirectory + Constants.PathBibFile;

            db = new DbService();
            entryList = new List<BibEntry>();

            SetEntryList();
            WriteBstInitFunctions();
            OpenPdfFile();
            ReadBstFile();
            ReadInitBstFile();
            ReadInitBibFile();

            entryMenu = new List<EntryMenu>();

            authorTab = new AuthorTab("Author", pathBibFile);
            authorTab.Dock = DockStyle.Fill;

            editorTab = new AuthorTab("Editor", pathBibFile);
            editorTab.Dock = DockStyle.Fill;

            citationTab = new CitationTab(pathBibFile);
            citationTab.Dock = DockStyle.Fill;

            initialEntryMenu();
            isInit = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

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

        private void OpenPdfFile()
        {
            if (!isInit)
            {
                Cursor.Hide();
                Cursor.Position = new Point(800, 400);
                LoadingForm.ShowSplashScreen();
            }
            BibPdfViewer.Document?.Dispose();
            MainService.ExecuteLatexCommand(pathBibFile, "Bibtex", true);
            BibPdfViewer.Document = OpenDocument(pathBibFile + Constants.BibTexName + ".pdf");
            ReloadPdf = false;
            if (!isInit)
            {
                LoadingForm.CloseForm();
                Cursor.Show();
            }
        }

        private void SetEntryList()
        {
            List<string> entrys = db.GetEntryData();
            List<string> tmpList = new List<string>();

            foreach (string entry in entrys)
            {
                tmpList = db.GetEntryFieldData(entry);
                entryList.Add(new BibEntry() { entry = entry, field = tmpList });
            }
        }

        private void WriteBstInitFunctions()
        {
            string txtWriteFunction = "";
            string txtWriteField = "";
            string bstTxt = "";
            string fieldTxt = "";

            for (int i = 0; i < entryList.Count; i++)
            {
                for (int j = 0; j < entryList[i].field.Count; j++)
                {
                    if (entryList[i].field[j].Equals("author"))
                    {
                        fieldTxt = entryList[i].field[j] + " format.names.author";
                    }
                    else if (entryList[i].field[j].Equals("editor"))
                    {
                        fieldTxt = entryList[i].field[j] + " format.names.editor";
                    }
                    else
                    {
                        fieldTxt = entryList[i].field[j];
                    }

                    txtWriteFunction += String.Format(formatFunction, entryList[i].entry, entryList[i].field[j], fieldTxt);
                    txtWriteFunction += Environment.NewLine + Environment.NewLine;

                    fieldTxt = "";
                }

                txtWriteFunction += String.Format("%end.{0}.function", entryList[i].entry) + Environment.NewLine + Environment.NewLine;
            }

            for (int i = 0; i < entryList.Count; i++)
            {
                for (int j = 0; j < entryList[i].field.Count; j++)
                {
                    txtWriteField += String.Format(Constants.WriteField, entryList[i].entry, entryList[i].field[j]);
                    txtWriteField += Environment.NewLine + " ";
                }

                txtWriteFunction += String.Format(entryFunction, entryList[i].entry, txtWriteField);
                txtWriteFunction += Environment.NewLine + Environment.NewLine;

                txtWriteField = "";
            }

            string path = pathBibFile + Constants.BstName + ".bst";

            using (StreamReader sr = new StreamReader(path))
            {
                bstTxt = sr.ReadToEnd();
            }

            bstTxt = bstTxt.Replace(Constants.BstInitFunction, txtWriteFunction);

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(bstTxt);
            }
        }

        private void ReadBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (StreamReader sr = new StreamReader(path))
            {
                bstText = sr.ReadToEnd();
            }
        }

        private void ReadInitBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (StreamReader sr = new StreamReader(path))
            {
                initText = sr.ReadToEnd();
            }
        }

        private void WriteInitBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(initText);
            }
        }

        private void WriteBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(bstText);
            }
        }

        private void ReadInitBibFile()
        {
            string path = pathBibFile + Constants.BibName + ".bib";

            using (StreamReader sr = new StreamReader(path))
            {
                initBib = sr.ReadToEnd();
            }
        }

        private void WriteInitBibFile()
        {
            string path = pathBibFile + Constants.BibName + ".bib";

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(initBib);
            }
        }

        private void initialEntryMenu()
        {
            EntryMenu tmpMenu;
            FieldTab tmpTab;
            List<FieldTab> tmpTabList = new List<FieldTab>();

            for (int i = 0; i < entryList.Count; i++)
            {
                tmpMenu = new EntryMenu();
                tmpTabList = new List<FieldTab>();
                tmpMenu.entryName = entryList[i].entry;

                for (int j = 0; j < entryList[i].field.Count; j++)
                {
                    tmpTab = new FieldTab();
                    tmpTab.fieldName = entryList[i].field[j];

                    tmpTab.fieldTab = new FieldStyleTab(entryList[i].entry, entryList[i].field[j], pathBibFile);
                    tmpTab.fieldTab.Dock = DockStyle.Fill;

                    tmpTabList.Add(tmpTab);
                }

                tmpMenu.tabList = tmpTabList;

                tmpMenu.fieldListTab = new FieldListTab(entryList[i].entry, entryList[i].field, pathBibFile);
                tmpMenu.fieldListTab.Dock = DockStyle.Fill;

                entryMenu.Add(tmpMenu);
            }
        }

        private void loadFieldList()
        {
            isEntryChange = true;
            string entry = cboEntry.SelectedValue.ToString();
            EntryMenu menuTab = entryMenu.Where(x => x.entryName == entry).FirstOrDefault();
            List<FieldTab> tmpTab = menuTab.tabList;

            for (int i = tvMenu.Nodes["Node1"].Nodes.Count - 1; i >= 0; i--)
            {
                tvMenu.Nodes["Node1"].Nodes[i].Remove();
            }

            var tmp = tvMenu.Nodes["Node1"].Nodes;

            for (int i = 0; i < tmpTab.Count; i++)
            {
                tvMenu.Nodes["Node1"].Nodes.Add(tmpTab[i].fieldName);
            }

            tvMenu.ExpandAll();
            isEntryChange = false;


        }

        public void addNewField(string entry, string field)
        {
            //Check All List
            FieldTab tmpTab = null;
            bool addEntry = false;

            for (int i = 0; i < entryMenu.Count; i++)
            {
                tmpTab = entryMenu[i].tabList.Where(x => x.fieldName == field).FirstOrDefault();
                if (tmpTab != null)
                {
                    break;
                }
            }

            if (tmpTab == null)
            {
                addEntry = true;
            }

            AddFieldInBst(entry, field, addEntry);

            //Add in List
            EntryMenu menuTab = entryMenu.Where(x => x.entryName == entry).FirstOrDefault();
            int addInd = entryMenu.IndexOf(menuTab);

            FieldTab newField = new FieldTab();
            newField.fieldName = field;
            newField.fieldTab = new FieldStyleTab(entry, field, pathBibFile);
            newField.fieldTab.Dock = DockStyle.Fill;

            entryMenu[addInd].tabList.Add(newField);

            //Add in TreeNode
            tvMenu.Nodes["Node1"].Nodes.Add(field);
        }

        public void removeFieldSelected(string entry, string field)
        {
            //Remove in List
            EntryMenu menuTab = entryMenu.Where(x => x.entryName == entry).FirstOrDefault();
            FieldTab tmpTab = menuTab.tabList.Where(x => x.fieldName == field).FirstOrDefault();
            int removeInd = entryMenu.IndexOf(menuTab);
            entryMenu[removeInd].tabList.Remove(tmpTab);

            //Remove in TreeNode
            TreeNode removeField = tvMenu.Nodes["Node1"].Nodes.Cast<TreeNode>().Where(x => x.Text == field).FirstOrDefault();
            tvMenu.Nodes["Node1"].Nodes.Remove(removeField);

            //Check All List
            tmpTab = null;
            bool rmvEntry = false;
            for (int i = 0; i < entryMenu.Count; i++)
            {
                tmpTab = entryMenu[i].tabList.Where(x => x.fieldName == field).FirstOrDefault();
                if (tmpTab != null)
                {
                    break;
                }
            }

            if (tmpTab == null)
            {
                rmvEntry = true;
            }

            RemoveFieldInBst(entry, field, rmvEntry);
        }

        private void AddFieldInBst(string entry, string field, bool addEntry)
        {
            ReadBstFile();

            string formatField = field == "author" || field == "editor" ? field + String.Format(" format.names.{0}", field) : field;

            string newEntry = String.Format(Constants.NewEntryFormat, field);
            string newFunction = String.Format(formatFunction, entry, field, formatField);
            string newWrite = String.Format(Constants.WriteField, entry, field);

            List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            int newIndex = lst.FindIndex(x => x.Contains(Constants.AddEntryCheck));

            if (addEntry)
                lst.Insert(newIndex, newEntry);

            int functionIndex = lst.FindIndex(x => x.Contains(String.Format("%end.{0}.function", entry)));
            lst.Insert(functionIndex, newFunction + Environment.NewLine);

            int writeIndex = lst.FindIndex(x => x.Contains(String.Format(" %{0}.new.write", entry)));
            lst.Insert(writeIndex, " " + newWrite);

            bstText = String.Join(Environment.NewLine, lst);

            WriteBstFile();
        }

        private void RemoveFieldInBst(string entry ,string field, bool rmvEntry)
        {
            ReadBstFile();

            string entryCheck = String.Format(Constants.EntryCheck, field);

            List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            int entryIndex = lst.FindIndex(x => x.Contains(entryCheck));

            if(rmvEntry)
                lst.RemoveAt(entryIndex);

            int functionIndex = lst.FindIndex(x => x.Contains(String.Format("FUNCTION {{format.{0}.{1}}}", entry, field)));

            for (int i = 0; i < 13; i++)
            {
                lst.RemoveAt(functionIndex);
            }

            int writeIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.WriteField, entry, field)));
            lst.RemoveAt(writeIndex);


            bstText = String.Join(Environment.NewLine, lst);

            WriteBstFile();
        }

        private void BibStyleForm_Load(object sender, EventArgs e)
        {
            cboEntry.DisplayMember = "entry";
            cboEntry.ValueMember = "entry";
            cboEntry.DataSource = entryList;
            cboEntry.SelectedIndex = 0;
            isLoad = false;
            loadFieldList();
        }

        private void cboEntry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadFieldList();
            pnlBibTabMenu.Controls.Clear();
            tvMenu.SelectedNode = null;
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvFormat.SelectedNode = null;

            if (!isEntryChange)
            {
                string entry = cboEntry.SelectedValue.ToString();
                EntryMenu menuTab = entryMenu.Where(x => x.entryName == entry).FirstOrDefault();
                List<FieldTab> tmpTab = menuTab.tabList;

                if (e.Node.Name.Equals("Node0"))
                {
                    pnlBibTabMenu.Controls.Clear();
                    pnlBibTabMenu.Controls.Add(menuTab.fieldListTab);
                    pnlBibTabMenu.AutoScroll = true;
                    menuTab.fieldListTab.Show();
                }
                else
                {
                    for (int i = 0; i < tmpTab.Count; i++)
                    {
                        if (e.Node.Text.Equals(tmpTab[i].fieldName))
                        {
                            pnlBibTabMenu.Controls.Clear();
                            pnlBibTabMenu.Controls.Add(tmpTab[i].fieldTab);
                            pnlBibTabMenu.AutoScroll = true;
                            tmpTab[i].fieldTab.Show();
                            break;
                        }
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.bst";
            saveFileDialog.DefaultExt = "bst";
            saveFileDialog.Filter = "BibTex Style file (*.bst) | *.bst";
            DialogResult saveResult = saveFileDialog.ShowDialog();

            ReadBstFile();

            if (saveResult == DialogResult.OK)
            {
                using (Stream fileStream = saveFileDialog.OpenFile())
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(bstText);
                }
            }
        }

        private void tvFormat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvMenu.SelectedNode = null;

            if (e.Node.Name.Equals("rnAuthor"))
            {
                pnlBibTabMenu.Controls.Clear();
                pnlBibTabMenu.Controls.Add(authorTab);
                pnlBibTabMenu.AutoScroll = true;
                authorTab.Show();
            }
            else if (e.Node.Name.Equals("rnEditor"))
            {
                pnlBibTabMenu.Controls.Clear();
                pnlBibTabMenu.Controls.Add(editorTab);
                pnlBibTabMenu.AutoScroll = true;
                editorTab.Show();
            }
            else if (e.Node.Name.Equals("rnCitation"))
            {
                pnlBibTabMenu.Controls.Clear();
                pnlBibTabMenu.Controls.Add(citationTab);
                pnlBibTabMenu.AutoScroll = true;
                citationTab.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start the new bibliology style ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                entryList = new List<BibEntry>();
                entryMenu = new List<EntryMenu>();

                pnlBibTabMenu.Controls.Clear();
                WriteInitBstFile();
                WriteInitBibFile();
                SetEntryList();

                authorTab = new AuthorTab("Author", pathBibFile);
                authorTab.Dock = DockStyle.Fill;

                editorTab = new AuthorTab("Editor", pathBibFile);
                editorTab.Dock = DockStyle.Fill;

                citationTab = new CitationTab(pathBibFile);
                citationTab.Dock = DockStyle.Fill;

                initialEntryMenu();
                OpenPdfFile();
                //do something
                tvFormat.SelectedNode = null;
                tvMenu.SelectedNode = null;
            }
        }
    }

}
