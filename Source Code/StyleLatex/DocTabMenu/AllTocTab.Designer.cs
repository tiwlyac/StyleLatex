namespace StyleLatex.DocTabMenu
{
    partial class AllTocTab
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
            this.cbHyperlink = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbDash = new System.Windows.Forms.RadioButton();
            this.rdbUnderscore = new System.Windows.Forms.RadioButton();
            this.rdbDot = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cbHyperlink);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 800);
            this.panel1.TabIndex = 0;
            // 
            // cbHyperlink
            // 
            this.cbHyperlink.AutoSize = true;
            this.cbHyperlink.Location = new System.Drawing.Point(71, 411);
            this.cbHyperlink.Name = "cbHyperlink";
            this.cbHyperlink.Size = new System.Drawing.Size(231, 34);
            this.cbHyperlink.TabIndex = 1;
            this.cbHyperlink.Text = "Enable Hyperlink";
            this.cbHyperlink.UseVisualStyleBackColor = true;
            this.cbHyperlink.CheckedChanged += new System.EventHandler(this.cbHyperlink_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNone);
            this.groupBox1.Controls.Add(this.rdbDash);
            this.groupBox1.Controls.Add(this.rdbUnderscore);
            this.groupBox1.Controls.Add(this.rdbDot);
            this.groupBox1.Location = new System.Drawing.Point(60, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leader Line Format";
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Location = new System.Drawing.Point(106, 59);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(106, 34);
            this.rdbNone.TabIndex = 3;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = " None";
            this.rdbNone.UseVisualStyleBackColor = true;
            this.rdbNone.CheckedChanged += new System.EventHandler(this.rdbNone_CheckedChanged);
            // 
            // rdbDash
            // 
            this.rdbDash.AutoSize = true;
            this.rdbDash.Location = new System.Drawing.Point(106, 229);
            this.rdbDash.Name = "rdbDash";
            this.rdbDash.Size = new System.Drawing.Size(214, 34);
            this.rdbDash.TabIndex = 2;
            this.rdbDash.TabStop = true;
            this.rdbDash.Text = " - - - - - - - - - - - -";
            this.rdbDash.UseVisualStyleBackColor = true;
            this.rdbDash.CheckedChanged += new System.EventHandler(this.rdbDash_CheckedChanged);
            // 
            // rdbUnderscore
            // 
            this.rdbUnderscore.AutoSize = true;
            this.rdbUnderscore.Location = new System.Drawing.Point(106, 166);
            this.rdbUnderscore.Name = "rdbUnderscore";
            this.rdbUnderscore.Size = new System.Drawing.Size(209, 34);
            this.rdbUnderscore.TabIndex = 1;
            this.rdbUnderscore.TabStop = true;
            this.rdbUnderscore.Text = " ______________";
            this.rdbUnderscore.UseVisualStyleBackColor = true;
            this.rdbUnderscore.CheckedChanged += new System.EventHandler(this.rdbUnderscore_CheckedChanged);
            // 
            // rdbDot
            // 
            this.rdbDot.AutoSize = true;
            this.rdbDot.Location = new System.Drawing.Point(106, 113);
            this.rdbDot.Name = "rdbDot";
            this.rdbDot.Size = new System.Drawing.Size(202, 34);
            this.rdbDot.TabIndex = 0;
            this.rdbDot.TabStop = true;
            this.rdbDot.Text = " . . . . . . . . . . . .";
            this.rdbDot.UseVisualStyleBackColor = true;
            this.rdbDot.CheckedChanged += new System.EventHandler(this.rdbDot_CheckedChanged);
            // 
            // AllTocTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AllTocTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.AllTocTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbHyperlink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.RadioButton rdbDash;
        private System.Windows.Forms.RadioButton rdbUnderscore;
        private System.Windows.Forms.RadioButton rdbDot;
    }
}
