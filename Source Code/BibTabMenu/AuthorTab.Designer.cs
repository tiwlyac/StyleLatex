namespace StyleLatex.BibTabMenu
{
    partial class AuthorTab
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
            this.tcCustom = new System.Windows.Forms.TabControl();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.ltbField = new System.Windows.Forms.ListBox();
            this.tpFormat = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuffixL = new System.Windows.Forms.Button();
            this.btnPrefixL = new System.Windows.Forms.Button();
            this.cbAbrvL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuffixL = new System.Windows.Forms.TextBox();
            this.txtPrefixL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSuffixV = new System.Windows.Forms.Button();
            this.btnPrefixV = new System.Windows.Forms.Button();
            this.cbAbrvV = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuffixV = new System.Windows.Forms.TextBox();
            this.txtPrefixV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuffixJr = new System.Windows.Forms.Button();
            this.btnPrefixJr = new System.Windows.Forms.Button();
            this.cbAbrvJr = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuffixJr = new System.Windows.Forms.TextBox();
            this.txtPrefixJr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuffixF = new System.Windows.Forms.Button();
            this.btnPrefixF = new System.Windows.Forms.Button();
            this.cbAbrvF = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuffixF = new System.Windows.Forms.TextBox();
            this.txtPrefixF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.btnOthers = new System.Windows.Forms.Button();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpSeperater = new System.Windows.Forms.GroupBox();
            this.btnBetween = new System.Windows.Forms.Button();
            this.btnBeforeLast = new System.Windows.Forms.Button();
            this.txtBeforeLast = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBetween = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tcCustom.SuspendLayout();
            this.tpOrder.SuspendLayout();
            this.tpFormat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpOther.SuspendLayout();
            this.grpSeperater.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCustom
            // 
            this.tcCustom.Controls.Add(this.tpOrder);
            this.tcCustom.Controls.Add(this.tpFormat);
            this.tcCustom.Controls.Add(this.tpOther);
            this.tcCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCustom.ItemSize = new System.Drawing.Size(140, 40);
            this.tcCustom.Location = new System.Drawing.Point(0, 0);
            this.tcCustom.Name = "tcCustom";
            this.tcCustom.SelectedIndex = 0;
            this.tcCustom.Size = new System.Drawing.Size(550, 880);
            this.tcCustom.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcCustom.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.btnDown);
            this.tpOrder.Controls.Add(this.btnUp);
            this.tpOrder.Controls.Add(this.lbOrder);
            this.tpOrder.Controls.Add(this.ltbField);
            this.tpOrder.Location = new System.Drawing.Point(4, 44);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrder.Size = new System.Drawing.Size(542, 832);
            this.tpOrder.TabIndex = 0;
            this.tpOrder.Text = "Ordering";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(434, 175);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 50);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(434, 119);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 50);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.Location = new System.Drawing.Point(32, 71);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(379, 23);
            this.lbOrder.TabIndex = 7;
            this.lbOrder.Text = "Select Part of Author\'s Name to Order";
            // 
            // ltbField
            // 
            this.ltbField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltbField.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbField.FormattingEnabled = true;
            this.ltbField.HorizontalScrollbar = true;
            this.ltbField.ItemHeight = 33;
            this.ltbField.Location = new System.Drawing.Point(52, 116);
            this.ltbField.Name = "ltbField";
            this.ltbField.Size = new System.Drawing.Size(329, 235);
            this.ltbField.TabIndex = 6;
            this.ltbField.SelectedValueChanged += new System.EventHandler(this.ltbField_SelectedValueChanged);
            // 
            // tpFormat
            // 
            this.tpFormat.AutoScroll = true;
            this.tpFormat.Controls.Add(this.groupBox2);
            this.tpFormat.Controls.Add(this.groupBox3);
            this.tpFormat.Controls.Add(this.groupBox4);
            this.tpFormat.Controls.Add(this.groupBox1);
            this.tpFormat.Location = new System.Drawing.Point(4, 44);
            this.tpFormat.Name = "tpFormat";
            this.tpFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormat.Size = new System.Drawing.Size(542, 832);
            this.tpFormat.TabIndex = 1;
            this.tpFormat.Text = "Author Format";
            this.tpFormat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuffixL);
            this.groupBox2.Controls.Add(this.btnPrefixL);
            this.groupBox2.Controls.Add(this.cbAbrvL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSuffixL);
            this.groupBox2.Controls.Add(this.txtPrefixL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 185);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last part";
            // 
            // btnSuffixL
            // 
            this.btnSuffixL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuffixL.Location = new System.Drawing.Point(316, 95);
            this.btnSuffixL.Name = "btnSuffixL";
            this.btnSuffixL.Size = new System.Drawing.Size(100, 36);
            this.btnSuffixL.TabIndex = 11;
            this.btnSuffixL.Text = "Apply";
            this.btnSuffixL.UseVisualStyleBackColor = true;
            this.btnSuffixL.Click += new System.EventHandler(this.btnSuffixL_Click);
            // 
            // btnPrefixL
            // 
            this.btnPrefixL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefixL.Location = new System.Drawing.Point(316, 44);
            this.btnPrefixL.Name = "btnPrefixL";
            this.btnPrefixL.Size = new System.Drawing.Size(100, 36);
            this.btnPrefixL.TabIndex = 10;
            this.btnPrefixL.Text = "Apply";
            this.btnPrefixL.UseVisualStyleBackColor = true;
            this.btnPrefixL.Click += new System.EventHandler(this.btnPrefixL_Click);
            // 
            // cbAbrvL
            // 
            this.cbAbrvL.AutoSize = true;
            this.cbAbrvL.Location = new System.Drawing.Point(148, 137);
            this.cbAbrvL.Name = "cbAbrvL";
            this.cbAbrvL.Size = new System.Drawing.Size(168, 34);
            this.cbAbrvL.TabIndex = 4;
            this.cbAbrvL.Text = "Abbreviate";
            this.cbAbrvL.UseVisualStyleBackColor = true;
            this.cbAbrvL.CheckedChanged += new System.EventHandler(this.cbAbrvAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suffix Mark";
            // 
            // txtSuffixL
            // 
            this.txtSuffixL.Location = new System.Drawing.Point(195, 95);
            this.txtSuffixL.Name = "txtSuffixL";
            this.txtSuffixL.Size = new System.Drawing.Size(115, 36);
            this.txtSuffixL.TabIndex = 2;
            this.txtSuffixL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrefixL
            // 
            this.txtPrefixL.Location = new System.Drawing.Point(195, 44);
            this.txtPrefixL.Name = "txtPrefixL";
            this.txtPrefixL.Size = new System.Drawing.Size(115, 36);
            this.txtPrefixL.TabIndex = 1;
            this.txtPrefixL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prefix Mark";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSuffixV);
            this.groupBox3.Controls.Add(this.btnPrefixV);
            this.groupBox3.Controls.Add(this.cbAbrvV);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSuffixV);
            this.groupBox3.Controls.Add(this.txtPrefixV);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(33, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 185);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Von part";
            // 
            // btnSuffixV
            // 
            this.btnSuffixV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuffixV.Location = new System.Drawing.Point(316, 95);
            this.btnSuffixV.Name = "btnSuffixV";
            this.btnSuffixV.Size = new System.Drawing.Size(100, 36);
            this.btnSuffixV.TabIndex = 11;
            this.btnSuffixV.Text = "Apply";
            this.btnSuffixV.UseVisualStyleBackColor = true;
            this.btnSuffixV.Click += new System.EventHandler(this.btnSuffixV_Click);
            // 
            // btnPrefixV
            // 
            this.btnPrefixV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefixV.Location = new System.Drawing.Point(316, 44);
            this.btnPrefixV.Name = "btnPrefixV";
            this.btnPrefixV.Size = new System.Drawing.Size(100, 36);
            this.btnPrefixV.TabIndex = 10;
            this.btnPrefixV.Text = "Apply";
            this.btnPrefixV.UseVisualStyleBackColor = true;
            this.btnPrefixV.Click += new System.EventHandler(this.btnPrefixV_Click);
            // 
            // cbAbrvV
            // 
            this.cbAbrvV.AutoSize = true;
            this.cbAbrvV.Location = new System.Drawing.Point(148, 137);
            this.cbAbrvV.Name = "cbAbrvV";
            this.cbAbrvV.Size = new System.Drawing.Size(168, 34);
            this.cbAbrvV.TabIndex = 4;
            this.cbAbrvV.Text = "Abbreviate";
            this.cbAbrvV.UseVisualStyleBackColor = true;
            this.cbAbrvV.CheckedChanged += new System.EventHandler(this.cbAbrvAll_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Suffix Mark";
            // 
            // txtSuffixV
            // 
            this.txtSuffixV.Location = new System.Drawing.Point(195, 95);
            this.txtSuffixV.Name = "txtSuffixV";
            this.txtSuffixV.Size = new System.Drawing.Size(115, 36);
            this.txtSuffixV.TabIndex = 2;
            this.txtSuffixV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrefixV
            // 
            this.txtPrefixV.Location = new System.Drawing.Point(195, 44);
            this.txtPrefixV.Name = "txtPrefixV";
            this.txtPrefixV.Size = new System.Drawing.Size(115, 36);
            this.txtPrefixV.TabIndex = 1;
            this.txtPrefixV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prefix Mark";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSuffixJr);
            this.groupBox4.Controls.Add(this.btnPrefixJr);
            this.groupBox4.Controls.Add(this.cbAbrvJr);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtSuffixJr);
            this.groupBox4.Controls.Add(this.txtPrefixJr);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(33, 607);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 185);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jr part";
            // 
            // btnSuffixJr
            // 
            this.btnSuffixJr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuffixJr.Location = new System.Drawing.Point(316, 95);
            this.btnSuffixJr.Name = "btnSuffixJr";
            this.btnSuffixJr.Size = new System.Drawing.Size(100, 36);
            this.btnSuffixJr.TabIndex = 11;
            this.btnSuffixJr.Text = "Apply";
            this.btnSuffixJr.UseVisualStyleBackColor = true;
            this.btnSuffixJr.Click += new System.EventHandler(this.btnSuffixJr_Click);
            // 
            // btnPrefixJr
            // 
            this.btnPrefixJr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefixJr.Location = new System.Drawing.Point(316, 44);
            this.btnPrefixJr.Name = "btnPrefixJr";
            this.btnPrefixJr.Size = new System.Drawing.Size(100, 36);
            this.btnPrefixJr.TabIndex = 10;
            this.btnPrefixJr.Text = "Apply";
            this.btnPrefixJr.UseVisualStyleBackColor = true;
            this.btnPrefixJr.Click += new System.EventHandler(this.btnPrefixJr_Click);
            // 
            // cbAbrvJr
            // 
            this.cbAbrvJr.AutoSize = true;
            this.cbAbrvJr.Location = new System.Drawing.Point(148, 137);
            this.cbAbrvJr.Name = "cbAbrvJr";
            this.cbAbrvJr.Size = new System.Drawing.Size(168, 34);
            this.cbAbrvJr.TabIndex = 4;
            this.cbAbrvJr.Text = "Abbreviate";
            this.cbAbrvJr.UseVisualStyleBackColor = true;
            this.cbAbrvJr.CheckedChanged += new System.EventHandler(this.cbAbrvAll_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Suffix Mark";
            // 
            // txtSuffixJr
            // 
            this.txtSuffixJr.Location = new System.Drawing.Point(195, 95);
            this.txtSuffixJr.Name = "txtSuffixJr";
            this.txtSuffixJr.Size = new System.Drawing.Size(115, 36);
            this.txtSuffixJr.TabIndex = 2;
            this.txtSuffixJr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrefixJr
            // 
            this.txtPrefixJr.Location = new System.Drawing.Point(195, 44);
            this.txtPrefixJr.Name = "txtPrefixJr";
            this.txtPrefixJr.Size = new System.Drawing.Size(115, 36);
            this.txtPrefixJr.TabIndex = 1;
            this.txtPrefixJr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prefix Mark";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuffixF);
            this.groupBox1.Controls.Add(this.btnPrefixF);
            this.groupBox1.Controls.Add(this.cbAbrvF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSuffixF);
            this.groupBox1.Controls.Add(this.txtPrefixF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First part";
            // 
            // btnSuffixF
            // 
            this.btnSuffixF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuffixF.Location = new System.Drawing.Point(316, 95);
            this.btnSuffixF.Name = "btnSuffixF";
            this.btnSuffixF.Size = new System.Drawing.Size(100, 36);
            this.btnSuffixF.TabIndex = 11;
            this.btnSuffixF.Text = "Apply";
            this.btnSuffixF.UseVisualStyleBackColor = true;
            this.btnSuffixF.Click += new System.EventHandler(this.btnSuffixF_Click);
            // 
            // btnPrefixF
            // 
            this.btnPrefixF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefixF.Location = new System.Drawing.Point(316, 47);
            this.btnPrefixF.Name = "btnPrefixF";
            this.btnPrefixF.Size = new System.Drawing.Size(100, 36);
            this.btnPrefixF.TabIndex = 10;
            this.btnPrefixF.Text = "Apply";
            this.btnPrefixF.UseVisualStyleBackColor = true;
            this.btnPrefixF.Click += new System.EventHandler(this.btnPrefixF_Click);
            // 
            // cbAbrvF
            // 
            this.cbAbrvF.AutoSize = true;
            this.cbAbrvF.Location = new System.Drawing.Point(148, 137);
            this.cbAbrvF.Name = "cbAbrvF";
            this.cbAbrvF.Size = new System.Drawing.Size(168, 34);
            this.cbAbrvF.TabIndex = 4;
            this.cbAbrvF.Text = "Abbreviate";
            this.cbAbrvF.UseVisualStyleBackColor = true;
            this.cbAbrvF.CheckedChanged += new System.EventHandler(this.cbAbrvAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suffix Mark";
            // 
            // txtSuffixF
            // 
            this.txtSuffixF.Location = new System.Drawing.Point(195, 95);
            this.txtSuffixF.Name = "txtSuffixF";
            this.txtSuffixF.Size = new System.Drawing.Size(115, 36);
            this.txtSuffixF.TabIndex = 2;
            this.txtSuffixF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrefixF
            // 
            this.txtPrefixF.Location = new System.Drawing.Point(195, 47);
            this.txtPrefixF.Name = "txtPrefixF";
            this.txtPrefixF.Size = new System.Drawing.Size(115, 36);
            this.txtPrefixF.TabIndex = 1;
            this.txtPrefixF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix Mark";
            // 
            // tpOther
            // 
            this.tpOther.Controls.Add(this.btnOthers);
            this.tpOther.Controls.Add(this.txtOthers);
            this.tpOther.Controls.Add(this.label12);
            this.tpOther.Controls.Add(this.grpSeperater);
            this.tpOther.Location = new System.Drawing.Point(4, 44);
            this.tpOther.Name = "tpOther";
            this.tpOther.Padding = new System.Windows.Forms.Padding(3);
            this.tpOther.Size = new System.Drawing.Size(542, 832);
            this.tpOther.TabIndex = 2;
            this.tpOther.Text = "Others";
            this.tpOther.UseVisualStyleBackColor = true;
            // 
            // btnOthers
            // 
            this.btnOthers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.Location = new System.Drawing.Point(354, 335);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(95, 36);
            this.btnOthers.TabIndex = 9;
            this.btnOthers.Text = "Apply";
            this.btnOthers.UseVisualStyleBackColor = true;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(91, 335);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(257, 36);
            this.txtOthers.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "The \"and others\" Text :";
            // 
            // grpSeperater
            // 
            this.grpSeperater.Controls.Add(this.btnBetween);
            this.grpSeperater.Controls.Add(this.btnBeforeLast);
            this.grpSeperater.Controls.Add(this.txtBeforeLast);
            this.grpSeperater.Controls.Add(this.label11);
            this.grpSeperater.Controls.Add(this.txtBetween);
            this.grpSeperater.Controls.Add(this.label10);
            this.grpSeperater.Location = new System.Drawing.Point(30, 60);
            this.grpSeperater.Name = "grpSeperater";
            this.grpSeperater.Size = new System.Drawing.Size(482, 189);
            this.grpSeperater.TabIndex = 0;
            this.grpSeperater.TabStop = false;
            this.grpSeperater.Text = "Authors Seperator";
            // 
            // btnBetween
            // 
            this.btnBetween.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetween.Location = new System.Drawing.Point(365, 57);
            this.btnBetween.Name = "btnBetween";
            this.btnBetween.Size = new System.Drawing.Size(95, 36);
            this.btnBetween.TabIndex = 10;
            this.btnBetween.Text = "Apply";
            this.btnBetween.UseVisualStyleBackColor = true;
            this.btnBetween.Click += new System.EventHandler(this.btnBetween_Click);
            // 
            // btnBeforeLast
            // 
            this.btnBeforeLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeforeLast.Location = new System.Drawing.Point(365, 115);
            this.btnBeforeLast.Name = "btnBeforeLast";
            this.btnBeforeLast.Size = new System.Drawing.Size(95, 36);
            this.btnBeforeLast.TabIndex = 9;
            this.btnBeforeLast.Text = "Apply";
            this.btnBeforeLast.UseVisualStyleBackColor = true;
            this.btnBeforeLast.Click += new System.EventHandler(this.btnBeforeLast_Click);
            // 
            // txtBeforeLast
            // 
            this.txtBeforeLast.Location = new System.Drawing.Point(177, 115);
            this.txtBeforeLast.Name = "txtBeforeLast";
            this.txtBeforeLast.Size = new System.Drawing.Size(182, 36);
            this.txtBeforeLast.TabIndex = 4;
            this.txtBeforeLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 30);
            this.label11.TabIndex = 3;
            this.label11.Text = "Before Last ";
            // 
            // txtBetween
            // 
            this.txtBetween.Location = new System.Drawing.Point(177, 57);
            this.txtBetween.Name = "txtBetween";
            this.txtBetween.Size = new System.Drawing.Size(182, 36);
            this.txtBetween.TabIndex = 2;
            this.txtBetween.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Between ";
            // 
            // AuthorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tcCustom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AuthorTab";
            this.Size = new System.Drawing.Size(550, 880);
            this.Load += new System.EventHandler(this.AuthorTab_Load);
            this.tcCustom.ResumeLayout(false);
            this.tpOrder.ResumeLayout(false);
            this.tpOrder.PerformLayout();
            this.tpFormat.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpOther.ResumeLayout(false);
            this.tpOther.PerformLayout();
            this.grpSeperater.ResumeLayout(false);
            this.grpSeperater.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCustom;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.TabPage tpFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAbrvF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuffixF;
        private System.Windows.Forms.TextBox txtPrefixF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.ListBox ltbField;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.GroupBox grpSeperater;
        private System.Windows.Forms.TextBox txtBeforeLast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBetween;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBetween;
        private System.Windows.Forms.Button btnBeforeLast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuffixL;
        private System.Windows.Forms.Button btnPrefixL;
        private System.Windows.Forms.CheckBox cbAbrvL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuffixL;
        private System.Windows.Forms.TextBox txtPrefixL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSuffixV;
        private System.Windows.Forms.Button btnPrefixV;
        private System.Windows.Forms.CheckBox cbAbrvV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuffixV;
        private System.Windows.Forms.TextBox txtPrefixV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuffixJr;
        private System.Windows.Forms.Button btnPrefixJr;
        private System.Windows.Forms.CheckBox cbAbrvJr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSuffixJr;
        private System.Windows.Forms.TextBox txtPrefixJr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuffixF;
        private System.Windows.Forms.Button btnPrefixF;
        private System.Windows.Forms.Button btnOthers;
    }
}