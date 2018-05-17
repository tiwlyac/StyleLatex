namespace StyleLatex.BibTabMenu
{
    partial class CitationTab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCite = new System.Windows.Forms.RadioButton();
            this.rdbAlpha = new System.Windows.Forms.RadioButton();
            this.rdbAuthor = new System.Windows.Forms.RadioButton();
            this.rdbNumeric = new System.Windows.Forms.RadioButton();
            this.lbCitation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbCitation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 880);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCite);
            this.groupBox1.Controls.Add(this.rdbAlpha);
            this.groupBox1.Controls.Add(this.rdbAuthor);
            this.groupBox1.Controls.Add(this.rdbNumeric);
            this.groupBox1.Location = new System.Drawing.Point(47, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Style";
            // 
            // rdbCite
            // 
            this.rdbCite.AutoSize = true;
            this.rdbCite.Location = new System.Drawing.Point(106, 258);
            this.rdbCite.Name = "rdbCite";
            this.rdbCite.Size = new System.Drawing.Size(203, 34);
            this.rdbCite.TabIndex = 3;
            this.rdbCite.TabStop = true;
            this.rdbCite.Text = " Cite Key Style";
            this.rdbCite.UseVisualStyleBackColor = true;
            this.rdbCite.CheckedChanged += new System.EventHandler(this.rdbCite_CheckedChanged);
            // 
            // rdbAlpha
            // 
            this.rdbAlpha.AutoSize = true;
            this.rdbAlpha.Location = new System.Drawing.Point(106, 199);
            this.rdbAlpha.Name = "rdbAlpha";
            this.rdbAlpha.Size = new System.Drawing.Size(235, 34);
            this.rdbAlpha.TabIndex = 2;
            this.rdbAlpha.TabStop = true;
            this.rdbAlpha.Text = " Alphabetic Style";
            this.rdbAlpha.UseVisualStyleBackColor = true;
            this.rdbAlpha.CheckedChanged += new System.EventHandler(this.rdbAlpha_CheckedChanged);
            // 
            // rdbAuthor
            // 
            this.rdbAuthor.AutoSize = true;
            this.rdbAuthor.Location = new System.Drawing.Point(106, 139);
            this.rdbAuthor.Name = "rdbAuthor";
            this.rdbAuthor.Size = new System.Drawing.Size(244, 34);
            this.rdbAuthor.TabIndex = 1;
            this.rdbAuthor.TabStop = true;
            this.rdbAuthor.Text = " Author-Year Style";
            this.rdbAuthor.UseVisualStyleBackColor = true;
            this.rdbAuthor.CheckedChanged += new System.EventHandler(this.rdbAuthor_CheckedChanged);
            // 
            // rdbNumeric
            // 
            this.rdbNumeric.AutoSize = true;
            this.rdbNumeric.Location = new System.Drawing.Point(106, 82);
            this.rdbNumeric.Name = "rdbNumeric";
            this.rdbNumeric.Size = new System.Drawing.Size(205, 34);
            this.rdbNumeric.TabIndex = 0;
            this.rdbNumeric.TabStop = true;
            this.rdbNumeric.Text = " Numeric Style";
            this.rdbNumeric.UseVisualStyleBackColor = true;
            this.rdbNumeric.CheckedChanged += new System.EventHandler(this.rdbNumeric_CheckedChanged);
            // 
            // lbCitation
            // 
            this.lbCitation.AutoSize = true;
            this.lbCitation.Location = new System.Drawing.Point(186, 47);
            this.lbCitation.Name = "lbCitation";
            this.lbCitation.Size = new System.Drawing.Size(170, 30);
            this.lbCitation.TabIndex = 0;
            this.lbCitation.Text = "Citation Style";
            // 
            // CitationTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Name = "CitationTab";
            this.Size = new System.Drawing.Size(550, 880);
            this.Load += new System.EventHandler(this.CitationTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCite;
        private System.Windows.Forms.RadioButton rdbAlpha;
        private System.Windows.Forms.RadioButton rdbAuthor;
        private System.Windows.Forms.RadioButton rdbNumeric;
        private System.Windows.Forms.Label lbCitation;
    }
}
