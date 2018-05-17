namespace StyleLatex.DocTabMenu
{
    partial class TocTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.lbDepth = new System.Windows.Forms.Label();
            this.grpToc = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tcAbove = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnderlineLeft = new System.Windows.Forms.CheckBox();
            this.cbItalicLeft = new System.Windows.Forms.CheckBox();
            this.cbBoldLeft = new System.Windows.Forms.CheckBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.cbUnderlineRight = new System.Windows.Forms.CheckBox();
            this.cbItalicRight = new System.Windows.Forms.CheckBox();
            this.cbBoldRight = new System.Windows.Forms.CheckBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLeftFont = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRightFont = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnColorRight = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnColorLeft = new System.Windows.Forms.Button();
            this.cdLeft = new System.Windows.Forms.ColorDialog();
            this.cdRight = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            this.grpToc.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).BeginInit();
            this.tcAbove.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 800);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.nudDepth);
            this.tabPage1.Controls.Add(this.lbDepth);
            this.tabPage1.Controls.Add(this.grpToc);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Body Style";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(252, 663);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(75, 36);
            this.nudDepth.TabIndex = 55;
            this.nudDepth.ValueChanged += new System.EventHandler(this.nudDepth_ValueChanged);
            // 
            // lbDepth
            // 
            this.lbDepth.AutoSize = true;
            this.lbDepth.Location = new System.Drawing.Point(64, 663);
            this.lbDepth.Name = "lbDepth";
            this.lbDepth.Size = new System.Drawing.Size(157, 30);
            this.lbDepth.TabIndex = 52;
            this.lbDepth.Text = "Depth Level";
            // 
            // grpToc
            // 
            this.grpToc.Controls.Add(this.tcAbove);
            this.grpToc.Location = new System.Drawing.Point(34, 40);
            this.grpToc.Name = "grpToc";
            this.grpToc.Size = new System.Drawing.Size(475, 581);
            this.grpToc.TabIndex = 51;
            this.grpToc.TabStop = false;
            this.grpToc.Text = "Text above a table of content ";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.cboAlign);
            this.tabPage2.Controls.Add(this.lbAlign);
            this.tabPage2.Controls.Add(this.cbCustom);
            this.tabPage2.Controls.Add(this.btnHead);
            this.tabPage2.Controls.Add(this.txtHead);
            this.tabPage2.Controls.Add(this.lbHead);
            this.tabPage2.Controls.Add(this.nudFsize);
            this.tabPage2.Controls.Add(this.lbFsize);
            this.tabPage2.Controls.Add(this.cbUnderline);
            this.tabPage2.Controls.Add(this.cbItalic);
            this.tabPage2.Controls.Add(this.cbBold);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbColor);
            this.tabPage2.Controls.Add(this.bnColor);
            this.tabPage2.Controls.Add(this.cboFont);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 752);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Heading Style";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboAlign
            // 
            this.cboAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlign.FormattingEnabled = true;
            this.cboAlign.Location = new System.Drawing.Point(217, 241);
            this.cboAlign.Name = "cboAlign";
            this.cboAlign.Size = new System.Drawing.Size(191, 35);
            this.cboAlign.TabIndex = 65;
            this.cboAlign.SelectedIndexChanged += new System.EventHandler(this.cboAlign_SelectedIndexChanged);
            // 
            // lbAlign
            // 
            this.lbAlign.AutoSize = true;
            this.lbAlign.Location = new System.Drawing.Point(45, 241);
            this.lbAlign.Name = "lbAlign";
            this.lbAlign.Size = new System.Drawing.Size(127, 30);
            this.lbAlign.TabIndex = 64;
            this.lbAlign.Text = "Text Align";
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(48, 38);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(236, 34);
            this.cbCustom.TabIndex = 63;
            this.cbCustom.Text = "Custom Heading";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // btnHead
            // 
            this.btnHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead.Location = new System.Drawing.Point(370, 153);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(113, 36);
            this.btnHead.TabIndex = 62;
            this.btnHead.Text = "Apply";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(50, 153);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(314, 36);
            this.txtHead.TabIndex = 61;
            this.txtHead.TextChanged += new System.EventHandler(this.txtHead_TextChanged);
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Location = new System.Drawing.Point(169, 111);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(195, 30);
            this.lbHead.TabIndex = 60;
            this.lbHead.Text = "Heading Name";
            // 
            // nudFsize
            // 
            this.nudFsize.DecimalPlaces = 1;
            this.nudFsize.Location = new System.Drawing.Point(217, 382);
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
            this.nudFsize.TabIndex = 59;
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
            this.lbFsize.Location = new System.Drawing.Point(48, 384);
            this.lbFsize.Name = "lbFsize";
            this.lbFsize.Size = new System.Drawing.Size(115, 30);
            this.lbFsize.TabIndex = 58;
            this.lbFsize.Text = "Font Size";
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(351, 529);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(148, 34);
            this.cbUnderline.TabIndex = 57;
            this.cbUnderline.Text = "Underline";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(207, 529);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(93, 34);
            this.cbItalic.TabIndex = 56;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(53, 529);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(87, 34);
            this.cbBold.TabIndex = 55;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 54;
            this.label3.Text = "Font Family";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(47, 457);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 30);
            this.lbColor.TabIndex = 53;
            this.lbColor.Text = "Color";
            // 
            // bnColor
            // 
            this.bnColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.bnColor.Location = new System.Drawing.Point(216, 457);
            this.bnColor.Name = "bnColor";
            this.bnColor.Size = new System.Drawing.Size(100, 35);
            this.bnColor.TabIndex = 52;
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
            this.cboFont.Location = new System.Drawing.Point(217, 312);
            this.cboFont.MaxDropDownItems = 5;
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(258, 35);
            this.cboFont.TabIndex = 51;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // tcAbove
            // 
            this.tcAbove.Controls.Add(this.tabPage3);
            this.tcAbove.Controls.Add(this.tabPage4);
            this.tcAbove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcAbove.ItemSize = new System.Drawing.Size(150, 35);
            this.tcAbove.Location = new System.Drawing.Point(3, 53);
            this.tcAbove.Name = "tcAbove";
            this.tcAbove.SelectedIndex = 0;
            this.tcAbove.Size = new System.Drawing.Size(469, 525);
            this.tcAbove.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAbove.TabIndex = 64;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnColorLeft);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cboLeftFont);
            this.tabPage3.Controls.Add(this.nudLeft);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cbUnderlineLeft);
            this.tabPage3.Controls.Add(this.cbItalicLeft);
            this.tabPage3.Controls.Add(this.cbBoldLeft);
            this.tabPage3.Controls.Add(this.btnLeft);
            this.tabPage3.Controls.Add(this.txtLeft);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(461, 482);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Left Side";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnColorRight);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.cboRightFont);
            this.tabPage4.Controls.Add(this.nudRight);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtRight);
            this.tabPage4.Controls.Add(this.cbUnderlineRight);
            this.tabPage4.Controls.Add(this.cbItalicRight);
            this.tabPage4.Controls.Add(this.cbBoldRight);
            this.tabPage4.Controls.Add(this.btnRight);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(461, 482);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Right Side";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nudLeft
            // 
            this.nudLeft.DecimalPlaces = 1;
            this.nudLeft.Location = new System.Drawing.Point(183, 218);
            this.nudLeft.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudLeft.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLeft.Name = "nudLeft";
            this.nudLeft.Size = new System.Drawing.Size(100, 36);
            this.nudLeft.TabIndex = 69;
            this.nudLeft.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLeft.ValueChanged += new System.EventHandler(this.nudLeft_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 68;
            this.label1.Text = "Font Size";
            // 
            // cbUnderlineLeft
            // 
            this.cbUnderlineLeft.AutoSize = true;
            this.cbUnderlineLeft.Location = new System.Drawing.Point(293, 340);
            this.cbUnderlineLeft.Name = "cbUnderlineLeft";
            this.cbUnderlineLeft.Size = new System.Drawing.Size(148, 34);
            this.cbUnderlineLeft.TabIndex = 67;
            this.cbUnderlineLeft.Text = "Underline";
            this.cbUnderlineLeft.UseVisualStyleBackColor = true;
            this.cbUnderlineLeft.CheckedChanged += new System.EventHandler(this.Left_CheckedChanged);
            // 
            // cbItalicLeft
            // 
            this.cbItalicLeft.AutoSize = true;
            this.cbItalicLeft.Location = new System.Drawing.Point(161, 340);
            this.cbItalicLeft.Name = "cbItalicLeft";
            this.cbItalicLeft.Size = new System.Drawing.Size(93, 34);
            this.cbItalicLeft.TabIndex = 66;
            this.cbItalicLeft.Text = "Italic";
            this.cbItalicLeft.UseVisualStyleBackColor = true;
            this.cbItalicLeft.CheckedChanged += new System.EventHandler(this.Left_CheckedChanged);
            // 
            // cbBoldLeft
            // 
            this.cbBoldLeft.AutoSize = true;
            this.cbBoldLeft.Location = new System.Drawing.Point(19, 340);
            this.cbBoldLeft.Name = "cbBoldLeft";
            this.cbBoldLeft.Size = new System.Drawing.Size(87, 34);
            this.cbBoldLeft.TabIndex = 65;
            this.cbBoldLeft.Text = "Bold";
            this.cbBoldLeft.UseVisualStyleBackColor = true;
            this.cbBoldLeft.CheckedChanged += new System.EventHandler(this.Left_CheckedChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(328, 84);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(113, 36);
            this.btnLeft.TabIndex = 64;
            this.btnLeft.Text = "Apply";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(19, 84);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(303, 36);
            this.txtLeft.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 62;
            this.label2.Text = "Left Side";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRight
            // 
            this.nudRight.DecimalPlaces = 1;
            this.nudRight.Location = new System.Drawing.Point(183, 218);
            this.nudRight.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudRight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudRight.Name = "nudRight";
            this.nudRight.Size = new System.Drawing.Size(100, 36);
            this.nudRight.TabIndex = 71;
            this.nudRight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudRight.ValueChanged += new System.EventHandler(this.nudRight_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 70;
            this.label5.Text = "Font Size";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(19, 84);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(303, 36);
            this.txtRight.TabIndex = 69;
            // 
            // cbUnderlineRight
            // 
            this.cbUnderlineRight.AutoSize = true;
            this.cbUnderlineRight.Location = new System.Drawing.Point(293, 340);
            this.cbUnderlineRight.Name = "cbUnderlineRight";
            this.cbUnderlineRight.Size = new System.Drawing.Size(148, 34);
            this.cbUnderlineRight.TabIndex = 68;
            this.cbUnderlineRight.Text = "Underline";
            this.cbUnderlineRight.UseVisualStyleBackColor = true;
            this.cbUnderlineRight.CheckedChanged += new System.EventHandler(this.Right_CheckedChanged);
            // 
            // cbItalicRight
            // 
            this.cbItalicRight.AutoSize = true;
            this.cbItalicRight.Location = new System.Drawing.Point(161, 340);
            this.cbItalicRight.Name = "cbItalicRight";
            this.cbItalicRight.Size = new System.Drawing.Size(93, 34);
            this.cbItalicRight.TabIndex = 67;
            this.cbItalicRight.Text = "Italic";
            this.cbItalicRight.UseVisualStyleBackColor = true;
            this.cbItalicRight.CheckedChanged += new System.EventHandler(this.Right_CheckedChanged);
            // 
            // cbBoldRight
            // 
            this.cbBoldRight.AutoSize = true;
            this.cbBoldRight.Location = new System.Drawing.Point(19, 340);
            this.cbBoldRight.Name = "cbBoldRight";
            this.cbBoldRight.Size = new System.Drawing.Size(87, 34);
            this.cbBoldRight.TabIndex = 66;
            this.cbBoldRight.Text = "Bold";
            this.cbBoldRight.UseVisualStyleBackColor = true;
            this.cbBoldRight.CheckedChanged += new System.EventHandler(this.Right_CheckedChanged);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(328, 84);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(113, 36);
            this.btnRight.TabIndex = 65;
            this.btnRight.Text = "Apply";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 64;
            this.label4.Text = "Right Side";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 30);
            this.label6.TabIndex = 71;
            this.label6.Text = "Font Family";
            // 
            // cboLeftFont
            // 
            this.cboLeftFont.DropDownHeight = 150;
            this.cboLeftFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeftFont.DropDownWidth = 350;
            this.cboLeftFont.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeftFont.FormattingEnabled = true;
            this.cboLeftFont.IntegralHeight = false;
            this.cboLeftFont.Location = new System.Drawing.Point(183, 154);
            this.cboLeftFont.MaxDropDownItems = 5;
            this.cboLeftFont.Name = "cboLeftFont";
            this.cboLeftFont.Size = new System.Drawing.Size(258, 35);
            this.cboLeftFont.TabIndex = 70;
            this.cboLeftFont.SelectedIndexChanged += new System.EventHandler(this.cboLeftFont_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 73;
            this.label7.Text = "Font Family";
            // 
            // cboRightFont
            // 
            this.cboRightFont.DropDownHeight = 150;
            this.cboRightFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRightFont.DropDownWidth = 350;
            this.cboRightFont.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRightFont.FormattingEnabled = true;
            this.cboRightFont.IntegralHeight = false;
            this.cboRightFont.Location = new System.Drawing.Point(183, 154);
            this.cboRightFont.MaxDropDownItems = 5;
            this.cboRightFont.Name = "cboRightFont";
            this.cboRightFont.Size = new System.Drawing.Size(258, 35);
            this.cboRightFont.TabIndex = 72;
            this.cboRightFont.SelectedIndexChanged += new System.EventHandler(this.cboRightFont_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 30);
            this.label8.TabIndex = 75;
            this.label8.Text = "Color";
            // 
            // btnColorRight
            // 
            this.btnColorRight.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnColorRight.Location = new System.Drawing.Point(183, 280);
            this.btnColorRight.Name = "btnColorRight";
            this.btnColorRight.Size = new System.Drawing.Size(100, 35);
            this.btnColorRight.TabIndex = 74;
            this.btnColorRight.UseVisualStyleBackColor = false;
            this.btnColorRight.Click += new System.EventHandler(this.btnColorRight_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 30);
            this.label9.TabIndex = 73;
            this.label9.Text = "Color";
            // 
            // btnColorLeft
            // 
            this.btnColorLeft.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnColorLeft.Location = new System.Drawing.Point(183, 280);
            this.btnColorLeft.Name = "btnColorLeft";
            this.btnColorLeft.Size = new System.Drawing.Size(100, 35);
            this.btnColorLeft.TabIndex = 72;
            this.btnColorLeft.UseVisualStyleBackColor = false;
            this.btnColorLeft.Click += new System.EventHandler(this.btnColorLeft_Click);
            // 
            // TocTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TocTab";
            this.Size = new System.Drawing.Size(550, 800);
            this.Load += new System.EventHandler(this.TocTab_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            this.grpToc.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).EndInit();
            this.tcAbove.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbDepth;
        private System.Windows.Forms.GroupBox grpToc;
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
        private System.Windows.Forms.ComboBox cboAlign;
        private System.Windows.Forms.Label lbAlign;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.TabControl tcAbove;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUnderlineLeft;
        private System.Windows.Forms.CheckBox cbItalicLeft;
        private System.Windows.Forms.CheckBox cbBoldLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown nudRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.CheckBox cbUnderlineRight;
        private System.Windows.Forms.CheckBox cbItalicRight;
        private System.Windows.Forms.CheckBox cbBoldRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnColorLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLeftFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnColorRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRightFont;
        private System.Windows.Forms.ColorDialog cdLeft;
        private System.Windows.Forms.ColorDialog cdRight;
    }
}
