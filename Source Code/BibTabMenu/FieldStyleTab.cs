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

namespace StyleLatex.BibTabMenu
{
    public partial class FieldStyleTab : UserControl
    {
        private string entryName { get; set; }
        private string fieldName { get; set; }
        private string bstText { get; set; }
        private string pathBibFile { get; set; }
        private bool isInit { get; set; } = true;
        private BibStyleForm parentForm { get; set; }

        private string strPrefix { get; set; }
        private string strSuffix { get; set; }
        private string strEnd { get; set; }

        private bool isEndClick { get; set; }
        private bool isPrefixClick { get; set; }
        private bool isSuffixCilck { get; set; }


        public FieldStyleTab()
        {
            InitializeComponent();
        }

        public FieldStyleTab(string entry, string field, string path) : this()
        {
            entryName = entry;
            fieldName = field;
            pathBibFile = path;
        }


        private void RunFieldStylePreview()
        {
            try
            {
                string path = pathBibFile + Constants.BstName + ".bst";

                using (StreamReader sr = new StreamReader(path))
                {
                    bstText = sr.ReadToEnd();
                }

                string prefixCheck = String.Format(Constants.PrefixCheck, entryName, fieldName);
                string suffixCheck = String.Format(Constants.SuffixCheck, entryName, fieldName);
                string fieldCheck = String.Format(Constants.FieldCheck, entryName, fieldName);
                string endCheck = String.Format(Constants.EndCheck, entryName, fieldName);
                string concatCheck = String.Format(Constants.ConcatCheck, entryName, fieldName);

                string prefixB = cbPrefixB.Checked ? "bold" : "";
                string prefixI = cbPrefixI.Checked ? "italic" : "";
                string prefixU = cbPrefixU.Checked ? "underline" : "";
                string prefixFormat = String.Format("{0} {1} {2}", prefixB, prefixI, prefixU);

                string suffixB = cbSuffixB.Checked ? "bold" : "";
                string suffixI = cbSuffixI.Checked ? "italic" : "";
                string suffixU = cbSuffixU.Checked ? "underline" : "";
                string suffixFormat = String.Format("{0} {1} {2}", suffixB, suffixI, suffixU);

                string fieldB = cbFieldB.Checked ? "bold" : "";
                string fieldI = cbFieldI.Checked ? "italic" : "";
                string fieldU = cbFieldU.Checked ? "underline" : "";
                string fieldFormat = String.Format("{0} {1} {2}", fieldB, fieldI, fieldU);

                strPrefix = isPrefixClick ? txtPrefix.Text : strPrefix;
                txtPrefix.Text = strPrefix;
                strPrefix = strPrefix.Replace("\"", "''");
                strPrefix = strPrefix.Replace("&", "\\&");
                strPrefix = strPrefix.Replace("%", "\\%");
                strPrefix = strPrefix.Replace("#", "\\#");
                strPrefix = strPrefix.Replace("$", "\\$");

                strSuffix = isSuffixCilck ? txtSuffix.Text : strSuffix;
                txtSuffix.Text = strSuffix;
                strSuffix = strSuffix.Replace("\"", "''");
                strSuffix = strSuffix.Replace("&", "\\&");
                strSuffix = strSuffix.Replace("%", "\\%");
                strSuffix = strSuffix.Replace("#", "\\#");
                strSuffix = strSuffix.Replace("$", "\\$");

                strEnd = isEndClick ? txtEnd.Text : strEnd;
                txtEnd.Text = strEnd;
                strEnd = strEnd.Replace("\"", "''");
                strEnd = strEnd.Replace("&", "\\&");
                strEnd = strEnd.Replace("%", "\\%");
                strEnd = strEnd.Replace("#", "\\#");
                strEnd = strEnd.Replace("$", "\\$");

                
                
                

                int countConcat = 0;

                if (strPrefix != "")
                    countConcat++;

                if (strSuffix != "")
                    countConcat++;

                if (strEnd != "")
                    countConcat++;


                string concat = "";
                for (int i = 0; i < countConcat; i++)
                {
                    concat += " * ";
                }

                string prefixTb = strPrefix != "" ? "\"" + strPrefix + "\"" : "";
                string suffixTb = strSuffix != "" ? "\"" + strSuffix + "\"" : "";
                string endTb = strEnd != "" ? "\"" + strEnd + "\"" : "";

                string prefixText = String.Format(Constants.PrefixText, prefixTb, prefixFormat, entryName, fieldName);
                string suffixText = String.Format(Constants.SuffixText, suffixTb, suffixFormat, entryName, fieldName);
                string fieldText = fieldName == "author" || fieldName == "editor" ? String.Format(Constants.AuthorFieldText, fieldFormat, entryName, fieldName) : String.Format(Constants.FieldText, fieldFormat, entryName, fieldName);
                string endText = String.Format(Constants.EndText, endTb, entryName, fieldName);
                string concatText = String.Format(Constants.ConcatText, concat, entryName, fieldName);


                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                int prefixIndex = lst.FindIndex(x => x.Contains(prefixCheck));
                int suffixIndex = lst.FindIndex(x => x.Contains(suffixCheck));
                int fieldIndex = lst.FindIndex(x => x.Contains(fieldCheck));
                int endIndex = lst.FindIndex(x => x.Contains(endCheck));
                int concatIndex = lst.FindIndex(x => x.Contains(concatCheck));

                lst[prefixIndex] = prefixText;
                lst[suffixIndex] = suffixText;
                lst[endIndex] = endText;
                lst[fieldIndex] = fieldText;
                lst[concatIndex] = concatText;

                bstText = String.Join(Environment.NewLine, lst);

                using (var fileStream = new FileStream(path, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(bstText);
                }

                parentForm.ReloadPdf = true;

                isEndClick = false;
                isPrefixClick = false;
                isSuffixCilck = false;

  
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FieldStyleTab_Load(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string tmp = fieldName + " style";
            lbTab.Text = textInfo.ToTitleCase(tmp);
            txtEnd.Text = ". ";

            parentForm = this.ParentForm as BibStyleForm;

            MainService.ChangeControlsEnable(false, cbPrefixB, cbPrefixI, cbPrefixU, cbSuffixB, cbSuffixI, cbSuffixU);

            isEndClick = false;
            isPrefixClick = false;
            isSuffixCilck = false;

            strPrefix = txtPrefix.Text;
            strSuffix = txtSuffix.Text;
            strEnd = txtEnd.Text;
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            RunFieldStylePreview();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RunFieldStylePreview();
        }

        private void txtPrefix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrefix.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuffix.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnd.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            isPrefixClick = true;

            if (txtPrefix.Text.Contains(@"\") || txtSuffix.Text.Contains(@"{") || txtSuffix.Text.Contains(@"}"))
            {
                MessageBox.Show("This text have the character that can't be used in BibTeX style.");
                return;
            }
            

            RunFieldStylePreview();

            if (String.IsNullOrEmpty(txtPrefix.Text) || String.IsNullOrWhiteSpace(txtPrefix.Text))
                MainService.ChangeControlsEnable(false, cbPrefixB, cbPrefixI, cbPrefixU);
            else
                MainService.ChangeControlsEnable(true, cbPrefixB, cbPrefixI, cbPrefixU);
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            isSuffixCilck = true;

            if (txtSuffix.Text.Contains(@"\") || txtSuffix.Text.Contains(@"{") || txtSuffix.Text.Contains(@"}"))
            {
                MessageBox.Show("This text has the character that can't be used in BibTeX style.");
                return;
            }
            txtSuffix.Text = txtSuffix.Text.Replace("\"", "''");
            txtSuffix.Text = txtSuffix.Text.Replace("&", "\\&");
            txtSuffix.Text = txtSuffix.Text.Replace("%", "\\%");
            txtSuffix.Text = txtSuffix.Text.Replace("#", "\\#");
            txtSuffix.Text = txtSuffix.Text.Replace("%", "\\$");

            RunFieldStylePreview();

            if (String.IsNullOrEmpty(txtSuffix.Text) || String.IsNullOrWhiteSpace(txtSuffix.Text))
                MainService.ChangeControlsEnable(false, cbSuffixB, cbSuffixI, cbSuffixU);
            else
                MainService.ChangeControlsEnable(true, cbSuffixB, cbSuffixI, cbSuffixU);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            isEndClick = true;

            if (txtEnd.Text.Contains(@"\") || txtEnd.Text.Contains(@"{") || txtEnd.Text.Contains(@"}"))
            {
                MessageBox.Show("This mark has the character that can't be used in BibTeX style.");
                return;
            }
            txtEnd.Text = txtEnd.Text.Replace("\"", "''");
            txtEnd.Text = txtEnd.Text.Replace("&", "\\&");
            txtEnd.Text = txtEnd.Text.Replace("%", "\\%");
            txtEnd.Text = txtEnd.Text.Replace("#", "\\#");
            txtEnd.Text = txtEnd.Text.Replace("%", "\\$");

            RunFieldStylePreview();
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSuffix_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsPunctuation(e.KeyChar)) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
