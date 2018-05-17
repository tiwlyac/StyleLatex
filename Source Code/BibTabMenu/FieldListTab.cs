using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using StyleLatex.Helper;
using System.IO;
using StyleLatex.Dialog;

namespace StyleLatex.BibTabMenu
{
    public partial class FieldListTab : UserControl
    {
        private string entryName { get; set; }
        private BindingList<string> fieldListData { get; set; }
        private List<string> fieldList { get; set; }
        private string bstText { get; set; }
        private string bibText { get; set; }
        private string pathBibFile { get; set; }
        private bool isInit { get; set; } = true;
        private BibStyleForm parentForm { get; set; }

        public FieldListTab()
        {
            InitializeComponent();
        }

        public FieldListTab(string entry, List<string> field, string path) : this()
        {
            entryName = entry;
            fieldListData = new BindingList<string>(field);
            pathBibFile = path;

            ReadBstFile();
        }

        private void ReadBstFile()
        {
            string path = pathBibFile + Constants.BstName + ".bst";

            using (StreamReader sr = new StreamReader(path))
            {
                bstText = sr.ReadToEnd();
            }
        }

        private void ReadBibFile()
        {
            string path = pathBibFile + Constants.BibName + ".bib";

            using (StreamReader sr = new StreamReader(path))
            {
                bibText = sr.ReadToEnd();
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

        private void WriteBibFile()
        {
            string path = pathBibFile + Constants.BibName + ".bib";
            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(bibText);
            }

        }


        private void RunOrderedPreview(string currField, string changeField)
        {
            try
            {
                ReadBstFile();

                string currWriteField = String.Format(Constants.WriteField, entryName, currField);
                string changeWriteField = String.Format(Constants.WriteField, entryName, changeField);

                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                int currIndex = lst.FindIndex(x => x.Contains(currWriteField));
                int changeIndex = lst.FindIndex(x => x.Contains(changeWriteField));

                lst[currIndex] = " " + changeWriteField;
                lst[changeIndex] = " " + currWriteField;

                bstText = String.Join(Environment.NewLine, lst);

                WriteBstFile();

                parentForm.ReloadPdf = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editFieldTextInBib(string field, string mode, string fieldText = "")
        {
            ReadBibFile();
            List<string> lst = bibText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            int index = lst.FindIndex(x => x.Contains(String.Format("@{0}{{{0},", entryName)));

            if (mode == "Add")
            {
                lst.Insert(index + 1, String.Format("  {0}   = \"{1}\",", field, fieldText));
            }
            else
            {
                for (int i = index + 1; i <= index + fieldListData.Count; i++)
                {
                    if (lst[i].StartsWith(String.Format("  {0}", field)))
                    {
                        if (mode == "Edit")
                            lst[i] = String.Format("  {0}   = \"{1}\",", field, fieldText);
                        else
                        {
                            lst.RemoveAt(i);
                        }
                        break;
                    }
                }
            }

            bibText = String.Join(Environment.NewLine, lst);

            WriteBibFile();
            parentForm.ReloadPdf = true;
        }

        private void FieldListTab_Load(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string tmp = entryName + "'s " + "field";
            lbTab.Text = textInfo.ToTitleCase(tmp);
            ltbField.DataSource = fieldListData;

            parentForm = this.ParentForm as BibStyleForm;
        }

        private void ltbField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ltbField.SelectedIndex == 0)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = true;
            }

            else if (ltbField.SelectedIndex == ltbField.Items.Count - 1)
            {
                btnUp.Enabled = true;
                btnDown.Enabled = false;
            }
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ReadBstFile();
            string curr = fieldListData[ltbField.SelectedIndex];
            string change = fieldListData[ltbField.SelectedIndex - 1];
            fieldListData[ltbField.SelectedIndex] = change;
            fieldListData[ltbField.SelectedIndex - 1] = curr;
            ltbField.SelectedIndex--;
            RunOrderedPreview(curr, change);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ReadBstFile();
            string curr = fieldListData[ltbField.SelectedIndex];
            string change = fieldListData[ltbField.SelectedIndex + 1];
            fieldListData[ltbField.SelectedIndex] = change;
            fieldListData[ltbField.SelectedIndex + 1] = curr;
            ltbField.SelectedIndex++;
            RunOrderedPreview(curr, change);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parentForm.removeFieldSelected(entryName, ltbField.SelectedItem.ToString());
            fieldListData.RemoveAt(ltbField.SelectedIndex);
            editFieldTextInBib(ltbField.SelectedItem.ToString(), "Remove");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fieldText = "";
            string fieldAdd = "";

            using (BibListDialog dialog = new BibListDialog(fieldListData.ToList()))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    fieldAdd = dialog.fieldName;
                    fieldText = dialog.fieldText;

                    parentForm.addNewField(entryName, fieldAdd);
                    fieldListData.Add(fieldAdd);
                    editFieldTextInBib(fieldAdd, "Add", fieldText);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fieldText = "";

            using (EditPreviewDialog dialog = new EditPreviewDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    fieldText = dialog.fieldText;

                    editFieldTextInBib(ltbField.SelectedItem.ToString(), "Edit", fieldText);
                }
            }
        }
    }
}
