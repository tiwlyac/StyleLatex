namespace StyleLatex.DocTabMenu
{
    partial class LayoutTab
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
            this.cboCls = new System.Windows.Forms.ComboBox();
            this.lbCls = new System.Windows.Forms.Label();
            this.nudFsize = new System.Windows.Forms.NumericUpDown();
            this.lbFsize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.bnColor = new System.Windows.Forms.Button();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.cbSetFont = new System.Windows.Forms.CheckBox();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.nudBottom = new System.Windows.Forms.NumericUpDown();
            this.nudRight = new System.Windows.Forms.NumericUpDown();
            this.cboColumn = new System.Windows.Forms.ComboBox();
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.lbColumn = new System.Windows.Forms.Label();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.cboLeft = new System.Windows.Forms.ComboBox();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.cboRight = new System.Windows.Forms.ComboBox();
            this.lbOrientation = new System.Windows.Forms.Label();
            this.cboBottom = new System.Windows.Forms.ComboBox();
            this.lbPageSize = new System.Windows.Forms.Label();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 40);
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cboCls);
            this.panel1.Controls.Add(this.lbCls);
            this.panel1.Controls.Add(this.nudFsize);
            this.panel1.Controls.Add(this.lbFsize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbColor);
            this.panel1.Controls.Add(this.bnColor);
            this.panel1.Controls.Add(this.cboFont);
            this.panel1.Controls.Add(this.cbSetFont);
            this.panel1.Controls.Add(this.cbCustom);
            this.panel1.Controls.Add(this.nudBottom);
            this.panel1.Controls.Add(this.nudRight);
            this.panel1.Controls.Add(this.cboColumn);
            this.panel1.Controls.Add(this.nudLeft);
            this.panel1.Controls.Add(this.lbColumn);
            this.panel1.Controls.Add(this.nudTop);
            this.panel1.Controls.Add(this.cboOrientation);
            this.panel1.Controls.Add(this.cboLeft);
            this.panel1.Controls.Add(this.cboPageSize);
            this.panel1.Controls.Add(this.cboRight);
            this.panel1.Controls.Add(this.lbOrientation);
            this.panel1.Controls.Add(this.cboBottom);
            this.panel1.Controls.Add(this.lbPageSize);
            this.panel1.Controls.Add(this.cboTop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 900);
            this.panel1.TabIndex = 0;
            // 
            // cboCls
            // 
            this.cboCls.BackColor = System.Drawing.SystemColors.Window;
            this.cboCls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCls.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCls.FormattingEnabled = true;
            this.cboCls.Location = new System.Drawing.Point(251, 53);
            this.cboCls.Name = "cboCls";
            this.cboCls.Size = new System.Drawing.Size(184, 35);
            this.cboCls.TabIndex = 42;
            this.cboCls.SelectedIndexChanged += new System.EventHandler(this.cboCls_SelectedIndexChanged);
            this.cboCls.SelectionChangeCommitted += new System.EventHandler(this.cboCls_SelectionChangeCommitted);
            // 
            // lbCls
            // 
            this.lbCls.AutoSize = true;
            this.lbCls.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCls.Location = new System.Drawing.Point(62, 53);
            this.lbCls.Name = "lbCls";
            this.lbCls.Size = new System.Drawing.Size(138, 30);
            this.lbCls.TabIndex = 41;
            this.lbCls.Text = "Base Class";
            // 
            // nudFsize
            // 
            this.nudFsize.DecimalPlaces = 1;
            this.nudFsize.Location = new System.Drawing.Point(232, 764);
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
            this.nudFsize.TabIndex = 40;
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
            this.lbFsize.Location = new System.Drawing.Point(62, 764);
            this.lbFsize.Name = "lbFsize";
            this.lbFsize.Size = new System.Drawing.Size(115, 30);
            this.lbFsize.TabIndex = 39;
            this.lbFsize.Text = "Font Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Font Family";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(62, 823);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 30);
            this.lbColor.TabIndex = 37;
            this.lbColor.Text = "Color";
            // 
            // bnColor
            // 
            this.bnColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.bnColor.Location = new System.Drawing.Point(232, 823);
            this.bnColor.Name = "bnColor";
            this.bnColor.Size = new System.Drawing.Size(100, 35);
            this.bnColor.TabIndex = 36;
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
            this.cboFont.Location = new System.Drawing.Point(232, 700);
            this.cboFont.MaxDropDownItems = 5;
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(258, 35);
            this.cboFont.TabIndex = 35;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // cbSetFont
            // 
            this.cbSetFont.AutoSize = true;
            this.cbSetFont.Location = new System.Drawing.Point(62, 637);
            this.cbSetFont.Name = "cbSetFont";
            this.cbSetFont.Size = new System.Drawing.Size(315, 34);
            this.cbSetFont.TabIndex = 24;
            this.cbSetFont.Text = "Custom Main Font Style";
            this.cbSetFont.UseVisualStyleBackColor = true;
            this.cbSetFont.CheckedChanged += new System.EventHandler(this.cbSetFont_CheckedChanged);
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(62, 308);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(218, 34);
            this.cbCustom.TabIndex = 23;
            this.cbCustom.Text = "Custom Margin";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // nudBottom
            // 
            this.nudBottom.DecimalPlaces = 2;
            this.nudBottom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBottom.Location = new System.Drawing.Point(211, 552);
            this.nudBottom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBottom.Name = "nudBottom";
            this.nudBottom.Size = new System.Drawing.Size(100, 36);
            this.nudBottom.TabIndex = 22;
            this.nudBottom.ValueChanged += new System.EventHandler(this.LengthValues_ValueChanged);
            // 
            // nudRight
            // 
            this.nudRight.DecimalPlaces = 2;
            this.nudRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRight.Location = new System.Drawing.Point(211, 492);
            this.nudRight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRight.Name = "nudRight";
            this.nudRight.Size = new System.Drawing.Size(100, 36);
            this.nudRight.TabIndex = 21;
            this.nudRight.ValueChanged += new System.EventHandler(this.LengthValues_ValueChanged);
            // 
            // cboColumn
            // 
            this.cboColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.Location = new System.Drawing.Point(251, 234);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(184, 35);
            this.cboColumn.TabIndex = 5;
            this.cboColumn.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // nudLeft
            // 
            this.nudLeft.DecimalPlaces = 2;
            this.nudLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLeft.Location = new System.Drawing.Point(211, 432);
            this.nudLeft.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLeft.Name = "nudLeft";
            this.nudLeft.Size = new System.Drawing.Size(100, 36);
            this.nudLeft.TabIndex = 20;
            this.nudLeft.ValueChanged += new System.EventHandler(this.LengthValues_ValueChanged);
            // 
            // lbColumn
            // 
            this.lbColumn.AutoSize = true;
            this.lbColumn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumn.Location = new System.Drawing.Point(62, 234);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(109, 30);
            this.lbColumn.TabIndex = 4;
            this.lbColumn.Text = "Column";
            // 
            // nudTop
            // 
            this.nudTop.DecimalPlaces = 2;
            this.nudTop.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTop.Location = new System.Drawing.Point(211, 368);
            this.nudTop.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(100, 36);
            this.nudTop.TabIndex = 19;
            this.nudTop.ValueChanged += new System.EventHandler(this.LengthValues_ValueChanged);
            // 
            // cboOrientation
            // 
            this.cboOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrientation.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Location = new System.Drawing.Point(251, 174);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(184, 35);
            this.cboOrientation.TabIndex = 3;
            this.cboOrientation.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // cboLeft
            // 
            this.cboLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeft.FormattingEnabled = true;
            this.cboLeft.Location = new System.Drawing.Point(328, 431);
            this.cboLeft.Name = "cboLeft";
            this.cboLeft.Size = new System.Drawing.Size(78, 35);
            this.cboLeft.TabIndex = 18;
            this.cboLeft.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // cboPageSize
            // 
            this.cboPageSize.BackColor = System.Drawing.SystemColors.Window;
            this.cboPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPageSize.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPageSize.FormattingEnabled = true;
            this.cboPageSize.Location = new System.Drawing.Point(251, 111);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(184, 35);
            this.cboPageSize.TabIndex = 2;
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // cboRight
            // 
            this.cboRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRight.FormattingEnabled = true;
            this.cboRight.Location = new System.Drawing.Point(328, 491);
            this.cboRight.Name = "cboRight";
            this.cboRight.Size = new System.Drawing.Size(78, 35);
            this.cboRight.TabIndex = 17;
            this.cboRight.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // lbOrientation
            // 
            this.lbOrientation.AutoSize = true;
            this.lbOrientation.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrientation.Location = new System.Drawing.Point(62, 174);
            this.lbOrientation.Name = "lbOrientation";
            this.lbOrientation.Size = new System.Drawing.Size(147, 30);
            this.lbOrientation.TabIndex = 1;
            this.lbOrientation.Text = "Orientation";
            // 
            // cboBottom
            // 
            this.cboBottom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBottom.FormattingEnabled = true;
            this.cboBottom.Location = new System.Drawing.Point(328, 551);
            this.cboBottom.Name = "cboBottom";
            this.cboBottom.Size = new System.Drawing.Size(78, 35);
            this.cboBottom.TabIndex = 16;
            this.cboBottom.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // lbPageSize
            // 
            this.lbPageSize.AutoSize = true;
            this.lbPageSize.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageSize.Location = new System.Drawing.Point(62, 114);
            this.lbPageSize.Name = "lbPageSize";
            this.lbPageSize.Size = new System.Drawing.Size(126, 30);
            this.lbPageSize.TabIndex = 0;
            this.lbPageSize.Text = "Page Size";
            // 
            // cboTop
            // 
            this.cboTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Location = new System.Drawing.Point(328, 367);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(78, 35);
            this.cboTop.TabIndex = 15;
            this.cboTop.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bottom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Right";
            // 
            // LayoutTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LayoutTab";
            this.Size = new System.Drawing.Size(550, 900);
            this.Load += new System.EventHandler(this.LayoutTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPageSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboColumn;
        private System.Windows.Forms.Label lbColumn;
        private System.Windows.Forms.ComboBox cboOrientation;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Label lbOrientation;
        private System.Windows.Forms.ComboBox cboLeft;
        private System.Windows.Forms.ComboBox cboRight;
        private System.Windows.Forms.ComboBox cboBottom;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.NumericUpDown nudBottom;
        private System.Windows.Forms.NumericUpDown nudRight;
        private System.Windows.Forms.NumericUpDown nudLeft;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.CheckBox cbSetFont;
        private System.Windows.Forms.NumericUpDown nudFsize;
        private System.Windows.Forms.Label lbFsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button bnColor;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboCls;
        private System.Windows.Forms.Label lbCls;
    }
}
