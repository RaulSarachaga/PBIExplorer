namespace PBIAnalyzer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.boxDS = new System.Windows.Forms.GroupBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnDataSrc = new System.Windows.Forms.RadioButton();
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.boxDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxDS
            // 
            this.boxDS.Controls.Add(this.cbPorts);
            this.boxDS.Controls.Add(this.btnDataSrc);
            this.boxDS.Cursor = System.Windows.Forms.Cursors.Default;
            this.boxDS.Location = new System.Drawing.Point(28, 31);
            this.boxDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxDS.Name = "boxDS";
            this.boxDS.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxDS.Size = new System.Drawing.Size(546, 176);
            this.boxDS.TabIndex = 0;
            this.boxDS.TabStop = false;
            this.boxDS.Text = "Data Source";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(224, 83);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(298, 28);
            this.cbPorts.TabIndex = 1;
            this.cbPorts.Text = "Select Port";
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // btnDataSrc
            // 
            this.btnDataSrc.AutoSize = true;
            this.btnDataSrc.Checked = true;
            this.btnDataSrc.Location = new System.Drawing.Point(36, 85);
            this.btnDataSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDataSrc.Name = "btnDataSrc";
            this.btnDataSrc.Size = new System.Drawing.Size(154, 24);
            this.btnDataSrc.TabIndex = 0;
            this.btnDataSrc.TabStop = true;
            this.btnDataSrc.Text = "PBI/SSDT Model";
            this.btnDataSrc.UseVisualStyleBackColor = true;
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.Location = new System.Drawing.Point(318, 246);
            this.btnConnectPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.Size = new System.Drawing.Size(106, 37);
            this.btnConnectPort.TabIndex = 3;
            this.btnConnectPort.Text = "Connect";
            this.btnConnectPort.UseVisualStyleBackColor = true;
            this.btnConnectPort.Click += new System.EventHandler(this.btnConnectPort_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 246);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.boxDS);
            this.Controls.Add(this.btnConnectPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBI Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.boxDS.ResumeLayout(false);
            this.boxDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxDS;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.RadioButton btnDataSrc;
        private System.Windows.Forms.Button btnConnectPort;
        private System.Windows.Forms.Button btnCancel;
    }
}

