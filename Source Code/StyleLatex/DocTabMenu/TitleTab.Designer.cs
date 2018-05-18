﻿namespace StyleLatex.DocTabMenu
{
    partial class TitleTab
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAlign = new System.Windows.Forms.ComboBox();
            this.nudFsize = new System.Windows.Forms.NumericUpDown();
            this.lbFsize = new System.Windows.Forms.Label();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.bnColor = new System.Windows.Forms.Button();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lbAlign = new System.Windows.Forms.Label();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cboAlign);
            this.panel1.Controls.Add(this.nudFsize);
            this.panel1.Controls.Add(this.lbFsize);
            this.panel1.Controls.Add(this.cbUnderline);
            this.panel1.Controls.Add(this.cbItalic);
            this.panel1.Controls.Add(this.cbBold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbColor);
            this.panel1.Controls.Add(this.bnColor);
            this.panel1.Controls.Add(this.cboFont);
            this.panel1.Controls.Add(this.lbAlign);
            this.panel1.Controls.Add(this.cbCustom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 800);
            this.panel1.TabIndex = 1;
            // 
            // cboAlign
            // 
            this.cboAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlign.FormattingEnabled = true;
            this.cboAlign.Location = new System.Drawing.Point(230, 143);
            this.cboAlign.Name = "cboAlign";
            this.cboAlign.Size = new System.Drawing.Size(191, 35);
            this.cboAlign.TabIndex = 35;
            this.cboAlign.SelectionChangeCommitted += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // nudFsize
            // 
            this.nudFsize.DecimalPlaces = 1;
            this.nudFsize.Location = new System.Drawing.Point(230, 279);
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
            this.nudFsize.TabIndex = 34;
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
            this.lbFsize.Location = new System.Drawing.Point(61, 281);
            this.lbFsize.Name = "lbFsize";
            this.lbFsize.Size = new System.Drawing.Size(115, 30);
            this.lbFsize.TabIndex = 33;
            this.lbFsize.Text = "Font Size";
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(364, 426);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(148, 34);
            this.cbUnderline.TabIndex = 32;
            this.cbUnderline.Text = "Underline";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(220, 426);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(93, 34);
            this.cbItalic.TabIndex = 31;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(66, 426);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(87, 34);
            this.cbBold.TabIndex = 30;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Font Family";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(60, 354);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 30);
            this.lbColor.TabIndex = 28;
            this.lbColor.Text = "Color";
            // 
            // bnColor
            // 
            this.bnColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.bnColor.Location = new System.Drawing.Point(229, 354);
            this.bnColor.Name = "bnColor";
            this.bnColor.Size = new System.Drawing.Size(100, 35);
            this.bnColor.TabIndex = 27;
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
            this.cboFont.Location = new System.Drawing.Point(230, 209);
            this.cboFont.MaxDropDownItems = 5;
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(258, 35);
            this.cboFont.TabIndex = 26;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            this.cboFont.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
            // 
            // lbAlign
            // 
            this.lbAlign.AutoSize = true;
            this.lbAlign.Location = new System.Drawing.Point(58, 143);
            this.lbAlign.Name = "lbAlign";
            this.lbAlign.Size = new System.Drawing.Size(127, 30);
            this.lbAlign.TabIndex = 24;
            this.lbAlign.Text = "Text Align";
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(63, 61);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(272, 34);
            this.cbCustom.TabIndex = 23;
            this.cbCustom.Text = "Custom Title Format";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // TitleTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TitleTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.TitleTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudFsize;
        private System.Windows.Forms.Label lbFsize;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button bnColor;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lbAlign;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboAlign;
    }
}