namespace StyleLatex.BibTabMenu
{
    partial class FieldStyleTab
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSuffix = new System.Windows.Forms.Button();
            this.cbSuffixU = new System.Windows.Forms.CheckBox();
            this.cbSuffixI = new System.Windows.Forms.CheckBox();
            this.cbSuffixB = new System.Windows.Forms.CheckBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrefix = new System.Windows.Forms.Button();
            this.cbPrefixU = new System.Windows.Forms.CheckBox();
            this.cbPrefixI = new System.Windows.Forms.CheckBox();
            this.cbPrefixB = new System.Windows.Forms.CheckBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFieldU = new System.Windows.Forms.CheckBox();
            this.cbFieldI = new System.Windows.Forms.CheckBox();
            this.cbFieldB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lbTab);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 800);
            this.panel1.TabIndex = 0;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(387, 685);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 36);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Apply";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(164, 685);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(217, 36);
            this.txtEnd.TabIndex = 12;
            this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnd_KeyDown);
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "End Mark";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSuffix);
            this.groupBox3.Controls.Add(this.cbSuffixU);
            this.groupBox3.Controls.Add(this.cbSuffixI);
            this.groupBox3.Controls.Add(this.cbSuffixB);
            this.groupBox3.Controls.Add(this.txtSuffix);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(34, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suffix";
            // 
            // btnSuffix
            // 
            this.btnSuffix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuffix.Location = new System.Drawing.Point(353, 75);
            this.btnSuffix.Name = "btnSuffix";
            this.btnSuffix.Size = new System.Drawing.Size(103, 36);
            this.btnSuffix.TabIndex = 8;
            this.btnSuffix.Text = "Apply";
            this.btnSuffix.UseVisualStyleBackColor = true;
            this.btnSuffix.Click += new System.EventHandler(this.btnSuffix_Click);
            // 
            // cbSuffixU
            // 
            this.cbSuffixU.AutoSize = true;
            this.cbSuffixU.Location = new System.Drawing.Point(293, 132);
            this.cbSuffixU.Name = "cbSuffixU";
            this.cbSuffixU.Size = new System.Drawing.Size(148, 34);
            this.cbSuffixU.TabIndex = 11;
            this.cbSuffixU.Text = "Underline";
            this.cbSuffixU.UseVisualStyleBackColor = true;
            this.cbSuffixU.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbSuffixI
            // 
            this.cbSuffixI.AutoSize = true;
            this.cbSuffixI.Location = new System.Drawing.Point(158, 132);
            this.cbSuffixI.Name = "cbSuffixI";
            this.cbSuffixI.Size = new System.Drawing.Size(93, 34);
            this.cbSuffixI.TabIndex = 10;
            this.cbSuffixI.Text = "Italic";
            this.cbSuffixI.UseVisualStyleBackColor = true;
            this.cbSuffixI.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbSuffixB
            // 
            this.cbSuffixB.AutoSize = true;
            this.cbSuffixB.Location = new System.Drawing.Point(33, 132);
            this.cbSuffixB.Name = "cbSuffixB";
            this.cbSuffixB.Size = new System.Drawing.Size(87, 34);
            this.cbSuffixB.TabIndex = 9;
            this.cbSuffixB.Text = "Bold";
            this.cbSuffixB.UseVisualStyleBackColor = true;
            this.cbSuffixB.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(33, 75);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(314, 36);
            this.txtSuffix.TabIndex = 8;
            this.txtSuffix.TextChanged += new System.EventHandler(this.txtSuffix_TextChanged);
            this.txtSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuffix_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Suffix Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrefix);
            this.groupBox2.Controls.Add(this.cbPrefixU);
            this.groupBox2.Controls.Add(this.cbPrefixI);
            this.groupBox2.Controls.Add(this.cbPrefixB);
            this.groupBox2.Controls.Add(this.txtPrefix);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(35, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prefix";
            // 
            // btnPrefix
            // 
            this.btnPrefix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefix.Location = new System.Drawing.Point(352, 83);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(103, 36);
            this.btnPrefix.TabIndex = 7;
            this.btnPrefix.Text = "Apply";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // cbPrefixU
            // 
            this.cbPrefixU.AutoSize = true;
            this.cbPrefixU.Location = new System.Drawing.Point(292, 134);
            this.cbPrefixU.Name = "cbPrefixU";
            this.cbPrefixU.Size = new System.Drawing.Size(148, 34);
            this.cbPrefixU.TabIndex = 6;
            this.cbPrefixU.Text = "Underline";
            this.cbPrefixU.UseVisualStyleBackColor = true;
            this.cbPrefixU.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbPrefixI
            // 
            this.cbPrefixI.AutoSize = true;
            this.cbPrefixI.Location = new System.Drawing.Point(157, 134);
            this.cbPrefixI.Name = "cbPrefixI";
            this.cbPrefixI.Size = new System.Drawing.Size(93, 34);
            this.cbPrefixI.TabIndex = 5;
            this.cbPrefixI.Text = "Italic";
            this.cbPrefixI.UseVisualStyleBackColor = true;
            this.cbPrefixI.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbPrefixB
            // 
            this.cbPrefixB.AutoSize = true;
            this.cbPrefixB.Location = new System.Drawing.Point(32, 134);
            this.cbPrefixB.Name = "cbPrefixB";
            this.cbPrefixB.Size = new System.Drawing.Size(87, 34);
            this.cbPrefixB.TabIndex = 4;
            this.cbPrefixB.Text = "Bold";
            this.cbPrefixB.UseVisualStyleBackColor = true;
            this.cbPrefixB.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(32, 83);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(314, 36);
            this.txtPrefix.TabIndex = 3;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            this.txtPrefix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrefix_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prefix Text";
            // 
            // lbTab
            // 
            this.lbTab.AutoSize = true;
            this.lbTab.Location = new System.Drawing.Point(36, 26);
            this.lbTab.Name = "lbTab";
            this.lbTab.Size = new System.Drawing.Size(122, 30);
            this.lbTab.TabIndex = 1;
            this.lbTab.Text = "Title Style";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFieldU);
            this.groupBox1.Controls.Add(this.cbFieldI);
            this.groupBox1.Controls.Add(this.cbFieldB);
            this.groupBox1.Location = new System.Drawing.Point(35, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field Text";
            // 
            // cbFieldU
            // 
            this.cbFieldU.AutoSize = true;
            this.cbFieldU.Location = new System.Drawing.Point(292, 52);
            this.cbFieldU.Name = "cbFieldU";
            this.cbFieldU.Size = new System.Drawing.Size(148, 34);
            this.cbFieldU.TabIndex = 2;
            this.cbFieldU.Text = "Underline";
            this.cbFieldU.UseVisualStyleBackColor = true;
            this.cbFieldU.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbFieldI
            // 
            this.cbFieldI.AutoSize = true;
            this.cbFieldI.Location = new System.Drawing.Point(157, 52);
            this.cbFieldI.Name = "cbFieldI";
            this.cbFieldI.Size = new System.Drawing.Size(93, 34);
            this.cbFieldI.TabIndex = 1;
            this.cbFieldI.Text = "Italic";
            this.cbFieldI.UseVisualStyleBackColor = true;
            this.cbFieldI.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbFieldB
            // 
            this.cbFieldB.AutoSize = true;
            this.cbFieldB.Location = new System.Drawing.Point(32, 52);
            this.cbFieldB.Name = "cbFieldB";
            this.cbFieldB.Size = new System.Drawing.Size(87, 34);
            this.cbFieldB.TabIndex = 0;
            this.cbFieldB.Text = "Bold";
            this.cbFieldB.UseVisualStyleBackColor = true;
            this.cbFieldB.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // FieldStyleTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FieldStyleTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.FieldStyleTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFieldU;
        private System.Windows.Forms.CheckBox cbFieldI;
        private System.Windows.Forms.CheckBox cbFieldB;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSuffixU;
        private System.Windows.Forms.CheckBox cbSuffixI;
        private System.Windows.Forms.CheckBox cbSuffixB;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPrefixU;
        private System.Windows.Forms.CheckBox cbPrefixI;
        private System.Windows.Forms.CheckBox cbPrefixB;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSuffix;
        private System.Windows.Forms.Button btnPrefix;
    }
}
