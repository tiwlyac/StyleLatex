namespace StyleLatex.DocTabMenu
{
    partial class AbstractTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAlign = new System.Windows.Forms.ComboBox();
            this.lbAlign = new System.Windows.Forms.Label();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.btnHead = new System.Windows.Forms.Button();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.lbHead = new System.Windows.Forms.Label();
            this.nudFsize = new System.Windows.Forms.NumericUpDown();
            this.lbFsize = new System.Windows.Forms.Label();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.bnColor = new System.Windows.Forms.Button();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cboAlign);
            this.panel1.Controls.Add(this.lbAlign);
            this.panel1.Controls.Add(this.cbCustom);
            this.panel1.Controls.Add(this.btnHead);
            this.panel1.Controls.Add(this.txtHead);
            this.panel1.Controls.Add(this.lbHead);
            this.panel1.Controls.Add(this.nudFsize);
            this.panel1.Controls.Add(this.lbFsize);
            this.panel1.Controls.Add(this.cbUnderline);
            this.panel1.Controls.Add(this.cbItalic);
            this.panel1.Controls.Add(this.cbBold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbColor);
            this.panel1.Controls.Add(this.bnColor);
            this.panel1.Controls.Add(this.cboFont);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 800);
            this.panel1.TabIndex = 0;
            // 
            // cboAlign
            // 
            this.cboAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlign.FormattingEnabled = true;
            this.cboAlign.Location = new System.Drawing.Point(223, 262);
            this.cboAlign.Name = "cboAlign";
            this.cboAlign.Size = new System.Drawing.Size(191, 35);
            this.cboAlign.TabIndex = 80;
            this.cboAlign.SelectedIndexChanged += new System.EventHandler(this.cboAlign_SelectedIndexChanged);
            // 
            // lbAlign
            // 
            this.lbAlign.AutoSize = true;
            this.lbAlign.Location = new System.Drawing.Point(51, 262);
            this.lbAlign.Name = "lbAlign";
            this.lbAlign.Size = new System.Drawing.Size(127, 30);
            this.lbAlign.TabIndex = 79;
            this.lbAlign.Text = "Text Align";
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(54, 59);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(233, 34);
            this.cbCustom.TabIndex = 78;
            this.cbCustom.Text = "Custom Abstract";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // btnHead
            // 
            this.btnHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead.Location = new System.Drawing.Point(376, 174);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(113, 36);
            this.btnHead.TabIndex = 77;
            this.btnHead.Text = "Apply";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(56, 174);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(314, 36);
            this.txtHead.TabIndex = 76;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Location = new System.Drawing.Point(175, 132);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(192, 30);
            this.lbHead.TabIndex = 75;
            this.lbHead.Text = "Abstract Name";
            // 
            // nudFsize
            // 
            this.nudFsize.DecimalPlaces = 1;
            this.nudFsize.Location = new System.Drawing.Point(223, 403);
            this.nudFsize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudFsize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFsize.Name = "nudFsize";
            this.nudFsize.Size = new System.Drawing.Size(100, 36);
            this.nudFsize.TabIndex = 74;
            this.nudFsize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFsize.ValueChanged += new System.EventHandler(this.nudFsize_ValueChanged);
            // 
            // lbFsize
            // 
            this.lbFsize.AutoSize = true;
            this.lbFsize.Location = new System.Drawing.Point(54, 405);
            this.lbFsize.Name = "lbFsize";
            this.lbFsize.Size = new System.Drawing.Size(115, 30);
            this.lbFsize.TabIndex = 73;
            this.lbFsize.Text = "Font Size";
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(357, 550);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(148, 34);
            this.cbUnderline.TabIndex = 72;
            this.cbUnderline.Text = "Underline";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(213, 550);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(93, 34);
            this.cbItalic.TabIndex = 71;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(59, 550);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(87, 34);
            this.cbBold.TabIndex = 70;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Font Family";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(53, 478);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 30);
            this.lbColor.TabIndex = 68;
            this.lbColor.Text = "Color";
            // 
            // bnColor
            // 
            this.bnColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.bnColor.Location = new System.Drawing.Point(222, 478);
            this.bnColor.Name = "bnColor";
            this.bnColor.Size = new System.Drawing.Size(100, 35);
            this.bnColor.TabIndex = 67;
            this.bnColor.UseVisualStyleBackColor = false;
            this.bnColor.Click += new System.EventHandler(this.bnColor_Click);
            // 
            // cboFont
            // 
            this.cboFont.DropDownHeight = 150;
            this.cboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFont.DropDownWidth = 350;
            this.cboFont.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFont.FormattingEnabled = true;
            this.cboFont.IntegralHeight = false;
            this.cboFont.Location = new System.Drawing.Point(223, 333);
            this.cboFont.MaxDropDownItems = 5;
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(258, 35);
            this.cboFont.TabIndex = 66;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // AbstractTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AbstractTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.AbstractTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboAlign;
        private System.Windows.Forms.Label lbAlign;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.NumericUpDown nudFsize;
        private System.Windows.Forms.Label lbFsize;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button bnColor;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
