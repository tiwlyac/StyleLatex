namespace StyleLatex
{
    partial class BibStyleForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Field List");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Field Style");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Citation Style");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Author Setting");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Editor Setting");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BibPdfViewer = new PdfiumViewer.PdfViewer();
            this.pnlBibTabMenu = new System.Windows.Forms.Panel();
            this.tbLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pnlLeftTable = new System.Windows.Forms.Panel();
            this.cboEntry = new System.Windows.Forms.ComboBox();
            this.lbEntry = new System.Windows.Forms.Label();
            this.tvFormat = new System.Windows.Forms.TreeView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlLeftTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 48);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = global::StyleLatex.Properties.Resources.icons8_export_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.Location = new System.Drawing.Point(153, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = " Export";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::StyleLatex.Properties.Resources.icons8_new_file_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(13, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = " New";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 625);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BibPdfViewer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlBibTabMenu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLeft, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 625);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BibPdfViewer
            // 
            this.BibPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BibPdfViewer.Location = new System.Drawing.Point(856, 6);
            this.BibPdfViewer.Margin = new System.Windows.Forms.Padding(6);
            this.BibPdfViewer.Name = "BibPdfViewer";
            this.BibPdfViewer.Size = new System.Drawing.Size(400, 613);
            this.BibPdfViewer.TabIndex = 1;
            // 
            // pnlBibTabMenu
            // 
            this.pnlBibTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBibTabMenu.Location = new System.Drawing.Point(303, 3);
            this.pnlBibTabMenu.Name = "pnlBibTabMenu";
            this.pnlBibTabMenu.Size = new System.Drawing.Size(544, 619);
            this.pnlBibTabMenu.TabIndex = 2;
            // 
            // tbLeft
            // 
            this.tbLeft.ColumnCount = 1;
            this.tbLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLeft.Controls.Add(this.panel3, 0, 1);
            this.tbLeft.Controls.Add(this.tvFormat, 0, 0);
            this.tbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLeft.Location = new System.Drawing.Point(3, 3);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.RowCount = 2;
            this.tbLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tbLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLeft.Size = new System.Drawing.Size(294, 619);
            this.tbLeft.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tvMenu);
            this.panel3.Controls.Add(this.pnlLeftTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 413);
            this.panel3.TabIndex = 0;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.SystemColors.Window;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenu.ForeColor = System.Drawing.Color.Black;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.Indent = 25;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.Location = new System.Drawing.Point(0, 121);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Field List";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Field Style";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(286, 290);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // pnlLeftTable
            // 
            this.pnlLeftTable.BackColor = System.Drawing.SystemColors.Window;
            this.pnlLeftTable.Controls.Add(this.cboEntry);
            this.pnlLeftTable.Controls.Add(this.lbEntry);
            this.pnlLeftTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTable.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLeftTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLeftTable.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTable.Name = "pnlLeftTable";
            this.pnlLeftTable.Size = new System.Drawing.Size(286, 121);
            this.pnlLeftTable.TabIndex = 3;
            // 
            // cboEntry
            // 
            this.cboEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntry.FormattingEnabled = true;
            this.cboEntry.Location = new System.Drawing.Point(17, 59);
            this.cboEntry.Name = "cboEntry";
            this.cboEntry.Size = new System.Drawing.Size(254, 35);
            this.cboEntry.TabIndex = 2;
            this.cboEntry.SelectionChangeCommitted += new System.EventHandler(this.cboEntry_SelectionChangeCommitted);
            // 
            // lbEntry
            // 
            this.lbEntry.AutoSize = true;
            this.lbEntry.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbEntry.Location = new System.Drawing.Point(36, 14);
            this.lbEntry.Name = "lbEntry";
            this.lbEntry.Size = new System.Drawing.Size(213, 30);
            this.lbEntry.TabIndex = 1;
            this.lbEntry.Text = "Select Entry Type";
            // 
            // tvFormat
            // 
            this.tvFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFormat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFormat.FullRowSelect = true;
            this.tvFormat.HideSelection = false;
            this.tvFormat.Indent = 25;
            this.tvFormat.ItemHeight = 50;
            this.tvFormat.Location = new System.Drawing.Point(3, 3);
            this.tvFormat.Name = "tvFormat";
            treeNode3.Name = "rnCitation";
            treeNode3.Text = "Citation Style";
            treeNode4.Name = "rnAuthor";
            treeNode4.Text = "Author Setting";
            treeNode5.Name = "rnEditor";
            treeNode5.Text = "Editor Setting";
            this.tvFormat.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            this.tvFormat.ShowLines = false;
            this.tvFormat.Size = new System.Drawing.Size(288, 194);
            this.tvFormat.TabIndex = 1;
            this.tvFormat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFormat_AfterSelect);
            // 
            // BibStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BibStyleForm";
            this.Load += new System.EventHandler(this.BibStyleForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tbLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlLeftTable.ResumeLayout(false);
            this.pnlLeftTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tvMenu;
        private PdfiumViewer.PdfViewer BibPdfViewer;
        private System.Windows.Forms.Panel pnlBibTabMenu;
        private System.Windows.Forms.Panel pnlLeftTable;
        private System.Windows.Forms.ComboBox cboEntry;
        private System.Windows.Forms.Label lbEntry;
        private System.Windows.Forms.TableLayoutPanel tbLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView tvFormat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}