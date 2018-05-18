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
    public partial class AllTocTab : UserControl
    {
        private DbService db { get; set; }
        private string clsText { get; set; }
        private string pathTexFile { get; set; }

        private DocStyleForm parentForm { get; set; }
        private bool isFormLoad { get; set; } = true;

        public AllTocTab()
        {
            InitializeComponent();
        }

        public AllTocTab(string path) : this()
        {
            pathTexFile = path;
        }

        private void RunPreview(string mode)
        {
            try
            {
                List<string> lst = new List<string>();
                int findIndex = -1;
                string leader = "";

                clsText = MainService.ReadLatexFile(Constants.DocClsName, ".cls", pathTexFile);

                lst = clsText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                if (mode == "Hyperlink")
                {
                    findIndex = lst.FindIndex(x => x.Contains("hyperref"));

                    if (cbHyperlink.Checked)
                    {
                        lst[findIndex] = String.Format(Constants.HyperrefFormat, "all");
                    }
                    else
                    {
                        lst[findIndex] = String.Format(Constants.HyperrefFormat, "none");
                    }
                }
                else if (mode == "LeaderLine")
                {
                    findIndex = lst.FindIndex(x => x.Contains(@"\renewcommand{\cftdot}"));

                    if (rdbDot.Checked)
                    {
                        leader = ".";
                    }
                    else if (rdbUnderscore.Checked)
                    {
                        leader = @"\_";
                    }
                    else if (rdbDash.Checked)
                    {
                        leader = "-";
                    }

                    lst[findIndex] = String.Format(Constants.LeaderLineFormat, leader);
                    if (rdbUnderscore.Checked)
                        lst.Insert(findIndex, @"\renewcommand{\cftdotsep}{0}");
                    else
                    {
                        findIndex = lst.FindIndex(x => x.Contains(@"\renewcommand{\cftdotsep}{0}"));
                        if (findIndex >= 0)
                        {
                            lst.RemoveAt(findIndex);
                        }
                    }

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

        private void cbHyperlink_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHyperlink.Checked)
                RunPreview("Hyperlink");
        }

        private void rdbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNone.Checked)
                RunPreview("LeaderLine");
        }

        private void rdbDot_CheckedChanged(object sender, EventArgs e)
        {
            if (!isFormLoad && rdbDot.Checked)
            {
                RunPreview("LeaderLine");
            }
        }

        private void rdbUnderscore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUnderscore.Checked)
                RunPreview("LeaderLine");
        }

        private void rdbDash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDash.Checked)
                RunPreview("LeaderLine");
        }

        private void AllTocTab_Load(object sender, EventArgs e)
        {
            rdbDot.Checked = true;

            parentForm = this.ParentForm as DocStyleForm;

            isFormLoad = false;
        }
    }
}
