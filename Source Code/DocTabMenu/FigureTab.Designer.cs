namespace StyleLatex.DocTabMenu
{
    partial class FigureTab
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
            this.lbFigAlign = new System.Windows.Forms.Label();
            this.lbCapAlign = new System.Windows.Forms.Label();
            this.lbSep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboFigAlign = new System.Windows.Forms.ComboBox();
            this.cboCapAlign = new System.Windows.Forms.ComboBox();
            this.cboSep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.lbNumbering = new System.Windows.Forms.Label();
            this.cboNumbering = new System.Windows.Forms.ComboBox();
            this.cbEnableLabel = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cbEnableLabel);
            this.panel1.Controls.Add(this.cboNumbering);
            this.panel1.Controls.Add(this.lbNumbering);
            this.panel1.Controls.Add(this.cboSep);
            this.panel1.Controls.Add(this.cboCapAlign);
            this.panel1.Controls.Add(this.cboFigAlign);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbSep);
            this.panel1.Controls.Add(this.lbCapAlign);
            this.panel1.Controls.Add(this.lbFigAlign);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 800);
            this.panel1.TabIndex = 0;
            // 
            // lbFigAlign
            // 
            this.lbFigAlign.AutoSize = true;
            this.lbFigAlign.Location = new System.Drawing.Point(65, 71);
            this.lbFigAlign.Name = "lbFigAlign";
            this.lbFigAlign.Size = new System.Drawing.Size(152, 30);
            this.lbFigAlign.TabIndex = 0;
            this.lbFigAlign.Text = "Figure Align";
            // 
            // lbCapAlign
            // 
            this.lbCapAlign.AutoSize = true;
            this.lbCapAlign.Location = new System.Drawing.Point(65, 137);
            this.lbCapAlign.Name = "lbCapAlign";
            this.lbCapAlign.Size = new System.Drawing.Size(177, 30);
            this.lbCapAlign.TabIndex = 1;
            this.lbCapAlign.Text = "Caption Align";
            // 
            // lbSep
            // 
            this.lbSep.AutoSize = true;
            this.lbSep.Location = new System.Drawing.Point(59, 588);
            this.lbSep.Name = "lbSep";
            this.lbSep.Size = new System.Drawing.Size(199, 30);
            this.lbSep.TabIndex = 3;
            this.lbSep.Text = "Label Seperater";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbItalic);
            this.groupBox1.Controls.Add(this.cbBold);
            this.groupBox1.Controls.Add(this.btnName);
            this.groupBox1.Controls.Add(this.txtLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Label Format";
            // 
            // cboFigAlign
            // 
            this.cboFigAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFigAlign.FormattingEnabled = true;
            this.cboFigAlign.Location = new System.Drawing.Point(286, 68);
            this.cboFigAlign.Name = "cboFigAlign";
            this.cboFigAlign.Size = new System.Drawing.Size(173, 35);
            this.cboFigAlign.TabIndex = 5;
            this.cboFigAlign.SelectedIndexChanged += new System.EventHandler(this.cboFigAlign_SelectedIndexChanged);
            // 
            // cboCapAlign
            // 
            this.cboCapAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapAlign.FormattingEnabled = true;
            this.cboCapAlign.Location = new System.Drawing.Point(286, 134);
            this.cboCapAlign.Name = "cboCapAlign";
            this.cboCapAlign.Size = new System.Drawing.Size(173, 35);
            this.cboCapAlign.TabIndex = 6;
            this.cboCapAlign.SelectedIndexChanged += new System.EventHandler(this.cboCapAlign_SelectedIndexChanged);
            // 
            // cboSep
            // 
            this.cboSep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSep.FormattingEnabled = true;
            this.cboSep.Location = new System.Drawing.Point(286, 585);
            this.cboSep.Name = "cboSep";
            this.cboSep.Size = new System.Drawing.Size(173, 35);
            this.cboSep.TabIndex = 7;
            this.cboSep.SelectedIndexChanged += new System.EventHandler(this.cboSep_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Label Name";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(29, 105);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(268, 36);
            this.txtLabel.TabIndex = 1;
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(303, 105);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(103, 36);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Apply";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(90, 161);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(87, 34);
            this.cbBold.TabIndex = 3;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(257, 161);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(93, 34);
            this.cbItalic.TabIndex = 4;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // lbNumbering
            // 
            this.lbNumbering.AutoSize = true;
            this.lbNumbering.Location = new System.Drawing.Point(59, 666);
            this.lbNumbering.Name = "lbNumbering";
            this.lbNumbering.Size = new System.Drawing.Size(208, 30);
            this.lbNumbering.TabIndex = 8;
            this.lbNumbering.Text = "Numbering Style";
            // 
            // cboNumbering
            // 
            this.cboNumbering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumbering.FormattingEnabled = true;
            this.cboNumbering.Location = new System.Drawing.Point(286, 666);
            this.cboNumbering.Name = "cboNumbering";
            this.cboNumbering.Size = new System.Drawing.Size(173, 35);
            this.cboNumbering.TabIndex = 9;
            this.cboNumbering.SelectedIndexChanged += new System.EventHandler(this.cboNumbering_SelectedIndexChanged);
            // 
            // cbEnableLabel
            // 
            this.cbEnableLabel.AutoSize = true;
            this.cbEnableLabel.Location = new System.Drawing.Point(70, 219);
            this.cbEnableLabel.Name = "cbEnableLabel";
            this.cbEnableLabel.Size = new System.Drawing.Size(397, 34);
            this.cbEnableLabel.TabIndex = 10;
            this.cbEnableLabel.Text = " Enable Label and Numbering ";
            this.cbEnableLabel.UseVisualStyleBackColor = true;
            this.cbEnableLabel.CheckedChanged += new System.EventHandler(this.cbEnableLabel_CheckedChanged);
            // 
            // FigureTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FigureTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.FigureTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSep;
        private System.Windows.Forms.ComboBox cboCapAlign;
        private System.Windows.Forms.ComboBox cboFigAlign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSep;
        private System.Windows.Forms.Label lbCapAlign;
        private System.Windows.Forms.Label lbFigAlign;
        private System.Windows.Forms.CheckBox cbEnableLabel;
        private System.Windows.Forms.ComboBox cboNumbering;
        private System.Windows.Forms.Label lbNumbering;
    }
}
