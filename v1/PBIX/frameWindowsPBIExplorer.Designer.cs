namespace PBIAnalyzer
{
    partial class Playground
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playground));
            this.gbButtonControls = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnMeasureDeps = new System.Windows.Forms.Button();
            this.btnAllStorageQuery = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.gbTableViewer = new System.Windows.Forms.GroupBox();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.cmsColumnNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            this.gbQueryInput = new System.Windows.Forms.GroupBox();
            this.panelDaxEditorFontSize = new System.Windows.Forms.Panel();
            this.cbZoomOptions = new System.Windows.Forms.ComboBox();
            this.gbQueryResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbButtonControls.SuspendLayout();
            this.gbTableViewer.SuspendLayout();
            this.cmsColumnNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            this.gbQueryInput.SuspendLayout();
            this.panelDaxEditorFontSize.SuspendLayout();
            this.gbQueryResult.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButtonControls
            // 
            this.gbButtonControls.Controls.Add(this.button1);
            this.gbButtonControls.Controls.Add(this.btnSaveAs);
            this.gbButtonControls.Controls.Add(this.btnMeasureDeps);
            this.gbButtonControls.Controls.Add(this.btnAllStorageQuery);
            this.gbButtonControls.Controls.Add(this.btnExcelExport);
            this.gbButtonControls.Controls.Add(this.btnRunQuery);
            this.gbButtonControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbButtonControls.Location = new System.Drawing.Point(0, 0);
            this.gbButtonControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbButtonControls.Name = "gbButtonControls";
            this.gbButtonControls.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbButtonControls.Size = new System.Drawing.Size(1596, 78);
            this.gbButtonControls.TabIndex = 0;
            this.gbButtonControls.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(516, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Measure Dependencies";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.Location = new System.Drawing.Point(1468, 17);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(112, 51);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnMeasureDeps
            // 
            this.btnMeasureDeps.Image = ((System.Drawing.Image)(resources.GetObject("btnMeasureDeps.Image")));
            this.btnMeasureDeps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeasureDeps.Location = new System.Drawing.Point(274, 17);
            this.btnMeasureDeps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMeasureDeps.Name = "btnMeasureDeps";
            this.btnMeasureDeps.Size = new System.Drawing.Size(234, 51);
            this.btnMeasureDeps.TabIndex = 2;
            this.btnMeasureDeps.Text = "All Measures";
            this.btnMeasureDeps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMeasureDeps.UseVisualStyleBackColor = true;
            this.btnMeasureDeps.Click += new System.EventHandler(this.btnMeasureDeps_Click);
            // 
            // btnAllStorageQuery
            // 
            this.btnAllStorageQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnAllStorageQuery.Image")));
            this.btnAllStorageQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllStorageQuery.Location = new System.Drawing.Point(128, 17);
            this.btnAllStorageQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllStorageQuery.Name = "btnAllStorageQuery";
            this.btnAllStorageQuery.Size = new System.Drawing.Size(138, 51);
            this.btnAllStorageQuery.TabIndex = 1;
            this.btnAllStorageQuery.Text = "All Storage";
            this.btnAllStorageQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllStorageQuery.UseVisualStyleBackColor = true;
            this.btnAllStorageQuery.Click += new System.EventHandler(this.btnAllStorageQuery_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelExport.Location = new System.Drawing.Point(1316, 17);
            this.btnExcelExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(144, 51);
            this.btnExcelExport.TabIndex = 3;
            this.btnExcelExport.Text = "Exports to Excel ";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.AutoSize = true;
            this.btnRunQuery.Location = new System.Drawing.Point(8, 17);
            this.btnRunQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(112, 51);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "Run";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // gbTableViewer
            // 
            this.gbTableViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTableViewer.Controls.Add(this.tvTables);
            this.gbTableViewer.Location = new System.Drawing.Point(0, 78);
            this.gbTableViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTableViewer.Name = "gbTableViewer";
            this.gbTableViewer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTableViewer.Size = new System.Drawing.Size(456, 846);
            this.gbTableViewer.TabIndex = 4;
            this.gbTableViewer.TabStop = false;
            this.gbTableViewer.Text = "Available Tables";
            // 
            // tvTables
            // 
            this.tvTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTables.Indent = 20;
            this.tvTables.Location = new System.Drawing.Point(9, 29);
            this.tvTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(436, 810);
            this.tvTables.TabIndex = 6;
            this.tvTables.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTables_NodeMouseClick);
            this.tvTables.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTables_NodeMouseDoubleClick);
            // 
            // cmsColumnNode
            // 
            this.cmsColumnNode.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsColumnNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.cmsColumnNode.Name = "cmsColumnNode";
            this.cmsColumnNode.Size = new System.Drawing.Size(165, 36);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.AllowUserToAddRows = false;
            this.dgvQueryResult.AllowUserToDeleteRows = false;
            this.dgvQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueryResult.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Location = new System.Drawing.Point(12, 29);
            this.dgvQueryResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.ReadOnly = true;
            this.dgvQueryResult.RowHeadersWidth = 62;
            this.dgvQueryResult.Size = new System.Drawing.Size(1095, 414);
            this.dgvQueryResult.TabIndex = 7;
            // 
            // gbQueryInput
            // 
            this.gbQueryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQueryInput.Controls.Add(this.panelDaxEditorFontSize);
            this.gbQueryInput.Location = new System.Drawing.Point(4, 5);
            this.gbQueryInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueryInput.Name = "gbQueryInput";
            this.gbQueryInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueryInput.Size = new System.Drawing.Size(1122, 370);
            this.gbQueryInput.TabIndex = 3;
            this.gbQueryInput.TabStop = false;
            this.gbQueryInput.Text = "DAX Query";
            // 
            // panelDaxEditorFontSize
            // 
            this.panelDaxEditorFontSize.Controls.Add(this.cbZoomOptions);
            this.panelDaxEditorFontSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDaxEditorFontSize.Location = new System.Drawing.Point(4, 320);
            this.panelDaxEditorFontSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDaxEditorFontSize.Name = "panelDaxEditorFontSize";
            this.panelDaxEditorFontSize.Size = new System.Drawing.Size(1114, 45);
            this.panelDaxEditorFontSize.TabIndex = 7;
            // 
            // cbZoomOptions
            // 
            this.cbZoomOptions.DropDownHeight = 120;
            this.cbZoomOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoomOptions.DropDownWidth = 60;
            this.cbZoomOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbZoomOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZoomOptions.FormattingEnabled = true;
            this.cbZoomOptions.IntegralHeight = false;
            this.cbZoomOptions.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "175%",
            "200%",
            "300%",
            "400%",
            "500%"});
            this.cbZoomOptions.Location = new System.Drawing.Point(9, 6);
            this.cbZoomOptions.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.cbZoomOptions.Name = "cbZoomOptions";
            this.cbZoomOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbZoomOptions.Size = new System.Drawing.Size(82, 28);
            this.cbZoomOptions.TabIndex = 6;
            this.cbZoomOptions.SelectedIndexChanged += new System.EventHandler(this.cbZoomOptions_SelectedIndexChanged);
            // 
            // gbQueryResult
            // 
            this.gbQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQueryResult.Controls.Add(this.dgvQueryResult);
            this.gbQueryResult.Location = new System.Drawing.Point(4, 385);
            this.gbQueryResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueryResult.Name = "gbQueryResult";
            this.gbQueryResult.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueryResult.Size = new System.Drawing.Size(1122, 457);
            this.gbQueryResult.TabIndex = 3;
            this.gbQueryResult.TabStop = false;
            this.gbQueryResult.Text = "Results";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbQueryInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbQueryResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(466, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 847);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1596, 925);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbTableViewer);
            this.Controls.Add(this.gbButtonControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Playground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBI Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Playground_FormClosed);
            this.Load += new System.EventHandler(this.Playground_Load);
            this.Resize += new System.EventHandler(this.Playground_Resize);
            this.gbButtonControls.ResumeLayout(false);
            this.gbButtonControls.PerformLayout();
            this.gbTableViewer.ResumeLayout(false);
            this.cmsColumnNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            this.gbQueryInput.ResumeLayout(false);
            this.panelDaxEditorFontSize.ResumeLayout(false);
            this.gbQueryResult.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButtonControls;
        private System.Windows.Forms.Button btnAllStorageQuery;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.GroupBox gbTableViewer;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.ContextMenuStrip cmsColumnNode;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.Button btnMeasureDeps;
        private System.Windows.Forms.DataGridView dgvQueryResult;
        private System.Windows.Forms.GroupBox gbQueryInput;
        private System.Windows.Forms.GroupBox gbQueryResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbZoomOptions;
        private System.Windows.Forms.Panel panelDaxEditorFontSize;
        private System.Windows.Forms.Button button1;
    }
}