using StyleLatex.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex.Dialog
{
    public partial class BibListDialog : Form
    {
        public string fieldName { get; set; }
        public string fieldText { get; set; }

        private List<string> fieldLst { get; set; }

        private List<string> entryField { get; set; }

        private DbService db { get; set; }

        public BibListDialog()
        {
            InitializeComponent();
        }

        public BibListDialog(List<string> fieldList) : this()
        {
            radioButton1.Checked = true;
            txtField.Enabled = false;

            entryField = fieldList;

            db = new DbService();
            fieldLst = db.GetFieldData();
            fieldLst = fieldLst.Except(fieldList).ToList();
            cboField.DataSource = fieldLst;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fieldName = cboField.SelectedItem.ToString();
            }
            else
            {
                fieldName = txtField.Text;

            }

            fieldText = rtxtField.Text;

            bool checkName = !fieldName.All(char.IsLetter);
            bool checkText = String.IsNullOrEmpty(fieldText) || String.IsNullOrWhiteSpace(fieldText);

            if (checkName || checkText)
            {
                string msg = "";
                if (checkName && checkText)
                {
                    msg = "Both field and preview text aren't";
                }
                else if (checkName)
                {
                    msg = "This field isn't";
                }
                else
                {
                    msg = "This preview text isn't";
                }

                MessageBox.Show("{0} filled out correctly.", msg);
                return;
            }

            var duplicate = entryField.Where(x => x == fieldName).FirstOrDefault();

            if (duplicate == fieldName)
            {
                MessageBox.Show("This field already exists.");
                return;
            }

            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cboField.Enabled = radioButton1.Checked ? true : false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtField.Enabled = true;
            }
            else
            {
                txtField.Text = "";
                txtField.Enabled = false;
            }

        }
    }
}
