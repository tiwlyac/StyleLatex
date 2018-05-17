using StyleLatex.Helper;
using StyleLatex.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex.BibTabMenu
{
    public partial class AuthorTab : UserControl
    {
        private string fieldName { get; set; }
        private string bstText { get; set; }
        private string pathBibFile { get; set; }
        private BindingList<NamePart> partList { get; set; }
        private BibStyleForm parentForm { get; set; }

        private PartNameFormat formatF { get; set; }
        private PartNameFormat formatL { get; set; }
        private PartNameFormat formatV { get; set; }
        private PartNameFormat formatJr { get; set; }

        private string betweenTxt { get; set; }
        private string beforeLastTxt { get; set; }
        private string othersTxt { get; set; }

        private bool isPrefixF { get; set; }
        private bool isPrefixL { get; set; }
        private bool isPrefixV { get; set; }
        private bool isPrefixJr { get; set; }

        private bool isSuffixF { get; set; }
        private bool isSuffixL { get; set; }
        private bool isSuffixV { get; set; }
        private bool isSuffixJr { get; set; }

        private string tmpPrefixF { get; set; }
        private string tmpPrefixL { get; set; }
        private string tmpPrefixV { get; set; }
        private string tmpPrefixJr { get; set; }

        private string tmpSuffixF { get; set; }
        private string tmpSuffixL { get; set; }
        private string tmpSuffixV { get; set; }
        private string tmpSuffixJr { get; set; }

        private bool isBetween { get; set; }
        private bool isBeforeLast { get; set; }
        private bool isOthers { get; set; }

        public AuthorTab()
        {
            InitializeComponent();
        }

        public AuthorTab(string field, string path) : this()
        {
            fieldName = field;
            pathBibFile = path;

            partList = new BindingList<NamePart>() {
                new NamePart {partName = "First Part" , partVal = "ff " },
                new NamePart {partName = "Von Part" , partVal = "vv " },
                new NamePart {partName = "Last Part" , partVal = "ll" },
                new NamePart {partName = "Jr Part" , partVal = "jj, " }
            };

            ltbField.DisplayMember = "partName";
            ltbField.ValueMember = "partVal";
            ltbField.DataSource = partList;
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
        private void RunOrderedPreview()
        {
            try
            {
                string path = pathBibFile + Constants.BstName + ".bst";
                ReadBstFile();
                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                string fieldCheck = fieldName.ToLower();
                int formatIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.AuthorFormatCheck, fieldCheck)));

                string partNameFormat = String.Format(Constants.AllPartFormat, partList[0].partVal, partList[1].partVal, partList[2].partVal, partList[3].partVal);
                lst[formatIndex] = String.Format(Constants.AuthorNameFormat, partNameFormat, fieldCheck);

                bstText = String.Join(Environment.NewLine, lst);

                WriteBstFile();
                parentForm.ReloadPdf = true;
            }catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunFormatPreview()
        {
            try
            {
                string path = pathBibFile + Constants.BstName + ".bst";
                ReadBstFile();

                List<NamePart> tmpList = partList.ToList();

                int indexF = tmpList.FindIndex(x => x.partName.Equals("First Part"));
                int indexL = tmpList.FindIndex(x => x.partName.Equals("Last Part"));
                int indexV = tmpList.FindIndex(x => x.partName.Equals("Von Part"));
                int indexJr = tmpList.FindIndex(x => x.partName.Equals("Jr Part"));

                formatF.partVal = cbAbrvF.Checked ? "f" : "ff";
                formatL.partVal = cbAbrvL.Checked ? "l" : "ll";
                formatV.partVal = cbAbrvV.Checked ? "v" : "vv";
                formatJr.partVal = cbAbrvJr.Checked ? "j" : "jj";

                formatF.prefix = isPrefixF ? txtPrefixF.Text : tmpPrefixF;
                tmpPrefixF = formatF.prefix;
                txtPrefixF.Text = formatF.prefix;
                formatF.prefix = formatF.prefix.Replace("\"", "''");
                formatF.prefix = formatF.prefix.Replace("&", "\\&");
                formatF.prefix = formatF.prefix.Replace("%", "\\%");
                formatF.prefix = formatF.prefix.Replace("#", "\\#");


                formatL.prefix = isPrefixL ? txtPrefixL.Text : tmpPrefixL;
                tmpPrefixL = formatL.prefix;
                txtPrefixL.Text = formatL.prefix;
                formatL.prefix = formatL.prefix.Replace("\"", "''");
                formatL.prefix = formatL.prefix.Replace("&", "\\&");
                formatL.prefix = formatL.prefix.Replace("%", "\\%");
                formatL.prefix = formatL.prefix.Replace("#", "\\#");

                formatV.prefix = isPrefixV ? txtPrefixV.Text : tmpPrefixV;
                tmpPrefixV = formatV.prefix;
                txtPrefixV.Text = formatV.prefix;
                formatV.prefix = formatV.prefix.Replace("\"", "''");
                formatV.prefix = formatV.prefix.Replace("&", "\\&");
                formatV.prefix = formatV.prefix.Replace("%", "\\%");
                formatV.prefix = formatV.prefix.Replace("#", "\\#");

                formatJr.prefix = isPrefixJr ? txtPrefixJr.Text : tmpPrefixJr;
                tmpPrefixJr = formatJr.prefix;
                txtPrefixJr.Text = formatJr.prefix;
                formatJr.prefix = formatJr.prefix.Replace("\"", "''");
                formatJr.prefix = formatJr.prefix.Replace("&", "\\&");
                formatJr.prefix = formatJr.prefix.Replace("%", "\\%");
                formatJr.prefix = formatJr.prefix.Replace("#", "\\#");


                formatF.suffix = isSuffixF ? txtSuffixF.Text : tmpSuffixF;
                tmpSuffixF = formatF.suffix;
                txtSuffixF.Text = formatF.suffix;
                formatF.suffix = formatF.suffix.Replace("\"", "''");
                formatF.suffix = formatF.suffix.Replace("&", "\\&");
                formatF.suffix = formatF.suffix.Replace("%", "\\%");
                formatF.suffix = formatF.suffix.Replace("#", "\\#");


                formatL.suffix = isSuffixL ? txtSuffixL.Text : tmpSuffixL;
                tmpSuffixL = formatL.suffix;
                txtSuffixL.Text = formatL.suffix;
                formatL.suffix = formatL.suffix.Replace("\"", "''");
                formatL.suffix = formatL.suffix.Replace("&", "\\&");
                formatL.suffix = formatL.suffix.Replace("%", "\\%");
                formatL.suffix = formatL.suffix.Replace("#", "\\#");


                formatV.suffix = isSuffixV ? txtSuffixV.Text : tmpSuffixV;
                tmpSuffixV = formatV.suffix;
                txtSuffixV.Text = formatV.suffix;
                formatV.suffix = formatV.suffix.Replace("\"", "''");
                formatV.suffix = formatV.suffix.Replace("&", "\\&");
                formatV.suffix = formatV.suffix.Replace("%", "\\%");
                formatV.suffix = formatV.suffix.Replace("#", "\\#");


                formatJr.suffix = isSuffixJr ? txtSuffixJr.Text : tmpSuffixJr;
                tmpSuffixJr = formatJr.suffix;
                txtSuffixJr.Text = formatJr.suffix;
                formatJr.suffix = formatJr.suffix.Replace("\"", "''");
                formatJr.suffix = formatJr.suffix.Replace("&", "\\&");
                formatJr.suffix = formatJr.suffix.Replace("%", "\\%");
                formatJr.suffix = formatJr.suffix.Replace("#", "\\#");

                string strF = formatF.prefix + formatF.partVal + formatF.suffix;
                string strL = formatL.prefix + formatL.partVal + formatL.suffix;
                string strV = formatV.prefix + formatV.partVal + formatV.suffix;
                string strJr = formatJr.prefix + formatJr.partVal + formatJr.suffix;

                partList[indexF].partVal = strF;
                partList[indexL].partVal = strL;
                partList[indexV].partVal = strV;
                partList[indexJr].partVal = strJr;

                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                string fieldCheck = fieldName.ToLower();
                int formatIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.AuthorFormatCheck, fieldCheck)));

                string partNameFormat = String.Format(Constants.AllPartFormat, partList[0].partVal, partList[1].partVal, partList[2].partVal, partList[3].partVal);
                lst[formatIndex] = String.Format(Constants.AuthorNameFormat, partNameFormat, fieldCheck);

                bstText = String.Join(Environment.NewLine, lst);

                WriteBstFile();
                parentForm.ReloadPdf = true;

                isPrefixF = false;
                isPrefixL = false;
                isPrefixV = false;
                isPrefixJr = false;

                isSuffixF = false;
                isSuffixL = false;
                isSuffixV = false;
                isSuffixJr = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RunOthersPreview()
        {
            try
            {
                string path = pathBibFile + Constants.BstName + ".bst";
                ReadBstFile();

                List<string> lst = bstText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                string fieldCheck = fieldName.ToLower();
                int betweenIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.BetweenCheck, fieldCheck)));
                int beforeLastIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.BeforeLastCheck, fieldCheck)));
                int othersIndex = lst.FindIndex(x => x.Contains(String.Format(Constants.OthersCheck, fieldCheck)));

                betweenTxt = isBetween ? txtBetween.Text : betweenTxt;
                txtBetween.Text = betweenTxt;
                txtBetween.Text = txtBetween.Text.Replace("\"", "''");
                txtBetween.Text = txtBetween.Text.Replace("&", "\\&");
                txtBetween.Text = txtBetween.Text.Replace("%", "\\%");
                txtBetween.Text = txtBetween.Text.Replace("#", "\\#");


                beforeLastTxt = isBeforeLast ? txtBeforeLast.Text : beforeLastTxt;
                txtBeforeLast.Text = beforeLastTxt;
                txtBeforeLast.Text = txtBeforeLast.Text.Replace("\"", "''");
                txtBeforeLast.Text = txtBeforeLast.Text.Replace("&", "\\&");
                txtBeforeLast.Text = txtBeforeLast.Text.Replace("%", "\\%");
                txtBeforeLast.Text = txtBeforeLast.Text.Replace("#", "\\#");

                othersTxt = isOthers ? txtOthers.Text : othersTxt;
                txtOthers.Text = othersTxt;
                othersTxt = othersTxt.Replace("\"", "''");
                othersTxt = othersTxt.Replace("&", "\\&");
                othersTxt = othersTxt.Replace("%", "\\%");
                othersTxt = othersTxt.Replace("#", "\\#");
                othersTxt = othersTxt.Replace("$", "\\$");

                string strBetween = String.Format(Constants.BetweenFormat, betweenTxt, fieldCheck);
                string strBeforeLast = String.Format(Constants.BeforeLastFormat, beforeLastTxt, fieldCheck);
                string strOthers = String.Format(Constants.OthersFormat, othersTxt, fieldCheck);

                lst[betweenIndex] = strBetween;
                lst[beforeLastIndex] = strBeforeLast;
                lst[othersIndex] = strOthers;

                bstText = String.Join(Environment.NewLine, lst);

                WriteBstFile();
                parentForm.ReloadPdf = true;

                isBetween = false;
                isBeforeLast = false;
                isOthers = false;

            }catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AuthorTab_Load(object sender, EventArgs e)
        {
            tpFormat.Text = String.Format(Constants.StrTabFormat, fieldName);
            lbOrder.Text = String.Format(Constants.StrLabelOrder, fieldName);
            grpSeperater.Text = String.Format(Constants.StrGroupSeperator, fieldName);

            parentForm = this.ParentForm as BibStyleForm;

            txtBetween.Text = ", ";
            txtBeforeLast.Text = ",";
            txtOthers.Text = " et al.";

            betweenTxt = txtBetween.Text;
            beforeLastTxt = txtBeforeLast.Text;
            othersTxt = txtOthers.Text;

            txtSuffixF.Text = " ";
            txtSuffixV.Text = " ";
            txtPrefixJr.Text = ", ";

            formatF = new PartNameFormat() { prefix = txtPrefixF.Text, suffix = txtSuffixF.Text, partVal = "ff" };
            formatL = new PartNameFormat() { prefix = txtPrefixL.Text, suffix = txtSuffixL.Text, partVal = "ll" };
            formatV = new PartNameFormat() { prefix = txtPrefixV.Text, suffix = txtSuffixV.Text, partVal = "vv" };
            formatJr = new PartNameFormat() { prefix = txtPrefixJr.Text, suffix = txtSuffixJr.Text, partVal = "jj" };

            isPrefixF = false;
            isPrefixL = false;
            isPrefixV = false;
            isPrefixJr = false;

            isSuffixF = false;
            isSuffixL = false;
            isSuffixV = false;
            isSuffixJr = false;

            isBetween = false;
            isBeforeLast = false;
            isOthers = false;

            tmpPrefixF = txtPrefixF.Text;
            tmpPrefixL = txtPrefixL.Text;
            tmpPrefixV = txtPrefixV.Text;
            tmpPrefixJr = txtPrefixJr.Text;

            tmpSuffixF = txtSuffixF.Text;
            tmpSuffixL = txtSuffixL.Text;
            tmpSuffixV = txtSuffixV.Text;
            tmpSuffixJr = txtSuffixJr.Text;
    }

        private void btnUp_Click(object sender, EventArgs e)
        {
            NamePart curr = partList[ltbField.SelectedIndex];
            NamePart change = partList[ltbField.SelectedIndex - 1];
            partList[ltbField.SelectedIndex] = change;
            partList[ltbField.SelectedIndex - 1] = curr;
            ltbField.SelectedIndex--;
            RunOrderedPreview();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            NamePart curr = partList[ltbField.SelectedIndex];
            NamePart change = partList[ltbField.SelectedIndex + 1];
            partList[ltbField.SelectedIndex] = change;
            partList[ltbField.SelectedIndex + 1] = curr;
            ltbField.SelectedIndex++;
            RunOrderedPreview();
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

        private void btnPrefixF_Click(object sender, EventArgs e)
        {
            isPrefixF = true;
            if (txtPrefixF.Text.Contains(@"\") || txtPrefixF.Text.Contains(@"{") || txtPrefixF.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
            
            RunFormatPreview();
        }

        private void btnSuffixF_Click(object sender, EventArgs e)
        {
            isSuffixF = true;
            if (txtSuffixF.Text.Contains(@"\") || txtSuffixF.Text.Contains(@"{") || txtSuffixF.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
           
            RunFormatPreview();
        }

        private void btnPrefixL_Click(object sender, EventArgs e)
        {
            isPrefixL = true;
            if (txtPrefixL.Text.Contains(@"\") || txtPrefixL.Text.Contains(@"{") || txtPrefixL.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
            
            RunFormatPreview();
        }

        private void btnSuffixL_Click(object sender, EventArgs e)
        {
            isSuffixL = true;
            if (txtSuffixL.Text.Contains(@"\") || txtSuffixL.Text.Contains(@"{") || txtSuffixL.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
           
           
            RunFormatPreview();
        }

        private void btnPrefixV_Click(object sender, EventArgs e)
        {
            isPrefixV = true;
            if (txtPrefixV.Text.Contains(@"\") || txtPrefixV.Text.Contains(@"{") || txtPrefixV.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
         
           
            RunFormatPreview();
        }

        private void btnSuffixV_Click(object sender, EventArgs e)
        {
            isSuffixV = true;
            if (txtSuffixV.Text.Contains(@"\") || txtSuffixV.Text.Contains(@"{") || txtSuffixV.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
          
           
            RunFormatPreview();
        }

        private void btnPrefixJr_Click(object sender, EventArgs e)
        {
            isPrefixJr = true;
            if (txtPrefixJr.Text.Contains(@"\") || txtPrefixJr.Text.Contains(@"{") || txtPrefixJr.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
           
           
            RunFormatPreview();
        }

        private void btnSuffixJr_Click(object sender, EventArgs e)
        {
            isSuffixJr = true;
            if (txtSuffixJr.Text.Contains(@"\") || txtSuffixJr.Text.Contains(@"{") || txtSuffixJr.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
            
            
            RunFormatPreview();
        }

        private void cbAbrvAll_CheckedChanged(object sender, EventArgs e)
        {
            RunFormatPreview();
        }

        private void btnBetween_Click(object sender, EventArgs e)
        {
            isBetween = true;
            if (txtBetween.Text.Contains(@"\") || txtBetween.Text.Contains(@"{") || txtBetween.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
         
            RunOthersPreview();
        }

        private void btnBeforeLast_Click(object sender, EventArgs e)
        {
            isBeforeLast = true;
            if (txtBeforeLast.Text.Contains(@"\") || txtBeforeLast.Text.Contains(@"{") || txtBeforeLast.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
           
            
            RunOthersPreview();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            isOthers = true;
            if (txtOthers.Text.Contains(@"\") || txtOthers.Text.Contains(@"{") || txtOthers.Text.Contains(@"}"))
            {
                MessageBox.Show("This marks have the character that can't be used in BibTeX style.");
                return;
            }
            
            RunOthersPreview();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsPunctuation(e.KeyChar))  || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
