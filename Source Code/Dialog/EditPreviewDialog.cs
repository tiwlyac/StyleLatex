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
    public partial class EditPreviewDialog : Form
    {
        public string fieldText { get; set; }

        public EditPreviewDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fieldText = rtxtField.Text;

            bool checkText = String.IsNullOrEmpty(fieldText) || String.IsNullOrWhiteSpace(fieldText);

            if (checkText)
            {
                MessageBox.Show("this preview text isn't filled out correctly.");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
