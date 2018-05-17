namespace StyleLatex
{
    partial class DocStyleForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Page Layout");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Type");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Content");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Figure");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Table");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Table of Contents", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Title ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Author ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Date ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Title Style", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Abstract Style");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Section ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Subsection ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Subsubsection ");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Section Style", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Paragraph ");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Subparagraph ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Paragraph Style", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Figure Style");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Table Style");
            this.pnlDocPage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.DocPdfViewer = new PdfiumViewer.PdfViewer();
            this.pnlDocTabMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bnSaveCls = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlDocPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocPage
            // 
            this.pnlDocPage.AutoScroll = true;
            this.pnlDocPage.Controls.Add(this.panel2);
            this.pnlDocPage.Controls.Add(this.panel1);
            this.pnlDocPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocPage.Location = new System.Drawing.Point(0, 0);
            this.pnlDocPage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDocPage.Name = "pnlDocPage";
            this.pnlDocPage.Size = new System.Drawing.Size(1262, 671);
            this.pnlDocPage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 623);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tvMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocPdfViewer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlDocTabMenu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 623);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.White;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenu.ForeColor = System.Drawing.Color.Black;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.Indent = 25;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.Location = new System.Drawing.Point(3, 3);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "tnLayout";
            treeNode1.Text = "Page Layout";
            treeNode2.Name = "ndAllToc";
            treeNode2.Text = "All Type";
            treeNode3.Name = "ndToc";
            treeNode3.Text = "Content";
            treeNode4.Name = "ndLof";
            treeNode4.Text = "Figure";
            treeNode5.Name = "ndLot";
            treeNode5.Text = "Table";
            treeNode6.Name = "tnToc";
            treeNode6.Text = "Table of Contents";
            treeNode7.Name = "ndTitle";
            treeNode7.Text = "Title ";
            treeNode8.Name = "ndAuthor";
            treeNode8.Text = "Author ";
            treeNode9.Name = "ndDate";
            treeNode9.Text = "Date ";
            treeNode10.Name = "tnTitle";
            treeNode10.Text = "Title Style";
            treeNode11.Name = "tnAbstract";
            treeNode11.Text = "Abstract Style";
            treeNode12.Name = "ndSec";
            treeNode12.Text = "Section ";
            treeNode13.Name = "ndSubSec";
            treeNode13.Text = "Subsection ";
            treeNode14.Name = "ndSubSubSec";
            treeNode14.Text = "Subsubsection ";
            treeNode15.Name = "tnSection";
            treeNode15.Text = "Section Style";
            treeNode16.Name = "ndPar";
            treeNode16.Text = "Paragraph ";
            treeNode17.Name = "ndSubPar";
            treeNode17.Text = "Subparagraph ";
            treeNode18.Name = "tnParagraph";
            treeNode18.Text = "Paragraph Style";
            treeNode19.Name = "tnFigure";
            treeNode19.Text = "Figure Style";
            treeNode20.Name = "tnTable";
            treeNode20.Text = "Table Style";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode10,
            treeNode11,
            treeNode15,
            treeNode18,
            treeNode19,
            treeNode20});
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(294, 617);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // DocPdfViewer
            // 
            this.DocPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocPdfViewer.Location = new System.Drawing.Point(856, 6);
            this.DocPdfViewer.Margin = new System.Windows.Forms.Padding(6);
            this.DocPdfViewer.Name = "DocPdfViewer";
            this.DocPdfViewer.Size = new System.Drawing.Size(400, 611);
            this.DocPdfViewer.TabIndex = 1;
            // 
            // pnlDocTabMenu
            // 
            this.pnlDocTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocTabMenu.Location = new System.Drawing.Point(303, 3);
            this.pnlDocTabMenu.Name = "pnlDocTabMenu";
            this.pnlDocTabMenu.Size = new System.Drawing.Size(544, 617);
            this.pnlDocTabMenu.TabIndex = 2;
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
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bnSaveCls, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bnSaveCls
            // 
            this.bnSaveCls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnSaveCls.FlatAppearance.BorderSize = 0;
            this.bnSaveCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSaveCls.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSaveCls.ForeColor = System.Drawing.SystemColors.Window;
            this.bnSaveCls.Image = global::StyleLatex.Properties.Resources.icons8_export_30;
            this.bnSaveCls.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bnSaveCls.Location = new System.Drawing.Point(153, 3);
            this.bnSaveCls.Name = "bnSaveCls";
            this.bnSaveCls.Size = new System.Drawing.Size(130, 42);
            this.bnSaveCls.TabIndex = 2;
            this.bnSaveCls.Text = " Export";
            this.bnSaveCls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnSaveCls.UseVisualStyleBackColor = false;
            this.bnSaveCls.Click += new System.EventHandler(this.bnSaveCls_Click);
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
            // DocStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.pnlDocPage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocStyleForm";
            this.Load += new System.EventHandler(this.DocStyleForm_Load);
            this.pnlDocPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDocPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnSaveCls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tvMenu;
        private PdfiumViewer.PdfViewer DocPdfViewer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel pnlDocTabMenu;
    }
}