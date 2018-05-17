using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StyleLatex.Helper;

namespace StyleLatex.BibTabMenu
{
    public partial class CitationTab : UserControl
    {
        private string bstText { get; set; }
        private string pathBibFile { get; set; }
        private string pathCiteFile { get; set; }
        private BibStyleForm parentForm { get; set; }
        private bool isLoad { get; set; } = true;

        public CitationTab()
        {
            InitializeComponent();
        }

        public CitationTab(string path) : this()
        {
            pathBibFile = path;
        }

        private void CitationTab_Load(object sender, EventArgs e)
        {
            parentForm = this.ParentForm as BibStyleForm;
            pathCiteFile = AppDomain.CurrentDomain.BaseDirectory + Constants.PathCiteFile;
            rdbNumeric.Checked = true;
            isLoad = false;
        }

        private void ReadBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (StreamReader sr = new StreamReader(path))
            {
                bstText = sr.ReadToEnd();
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

        private string readCiteTxtFile(string fileName)
        {
            string path = pathCiteFile + fileName;
            string txt = "";

            using (StreamReader sr = new StreamReader(path))
            {
                txt = sr.ReadToEnd();
            }

            return txt;
        }

        private void RunCitationStyle()
        {
            try
            {
                ReadBstFile();

                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                int startBibItem = lst.FindIndex(x => x.Contains("%start.bibitem")) + 1;

                while (!lst[startBibItem].Contains("%end.bibitem"))
                {
                    lst.RemoveAt(startBibItem);
                }

                if (rdbNumeric.Checked)
                {
                    lst.Insert(startBibItem, readCiteTxtFile(Constants.NubericBibItemFile));
                }
                else if (rdbCite.Checked)
                {
                    lst.Insert(startBibItem, String.Format(readCiteTxtFile(Constants.BibItemFile), "cite$"));
                }
                else
                {
                    lst.Insert(startBibItem, String.Format(readCiteTxtFile(Constants.BibItemFile), "label"));
                }

                int startCite = lst.FindIndex(x => x.Contains("%start.cite")) + 1;

                while (!lst[startCite].Contains("%end.cite"))
                {
                    lst.RemoveAt(startCite);
                }

                if (rdbNumeric.Checked)
                {
                    lst.Insert(startCite, readCiteTxtFile(Constants.NumericFile));
                }
                else if (rdbCite.Checked)
                {
                    lst.Insert(startCite, readCiteTxtFile(Constants.AbstractFile));
                }
                else if (rdbAlpha.Checked)
                {
                    lst.Insert(startCite, readCiteTxtFile(Constants.AlphaFile));
                }
                else
                {
                    lst.Insert(startCite, readCiteTxtFile(Constants.AuthorYearfile));
                }

                bstText = String.Join(Environment.NewLine, lst);

                WriteBstFile();

                parentForm.ReloadPdf = true;
            }catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbNumeric_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNumeric.Checked && !isLoad)
                RunCitationStyle();
        }

        private void rdbAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAuthor.Checked)
                RunCitationStyle();
        }

        private void rdbAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlpha.Checked)
                RunCitationStyle();
        }

        private void rdbCite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCite.Checked)
                RunCitationStyle();
        }
    }
}
