namespace GradeCalculator
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblAboutDescription = new System.Windows.Forms.TextBox();
            this.lblAboutDeveloper = new System.Windows.Forms.Label();
            this.lblAboutCopyright = new System.Windows.Forms.Label();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblAboutName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAboutDescription
            // 
            this.lblAboutDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutDescription.Location = new System.Drawing.Point(296, 136);
            this.lblAboutDescription.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.lblAboutDescription.Multiline = true;
            this.lblAboutDescription.Name = "lblAboutDescription";
            this.lblAboutDescription.ReadOnly = true;
            this.lblAboutDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblAboutDescription.Size = new System.Drawing.Size(438, 161);
            this.lblAboutDescription.TabIndex = 23;
            this.lblAboutDescription.TabStop = false;
            // 
            // lblAboutDeveloper
            // 
            this.lblAboutDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutDeveloper.Location = new System.Drawing.Point(296, 99);
            this.lblAboutDeveloper.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAboutDeveloper.MaximumSize = new System.Drawing.Size(0, 21);
            this.lblAboutDeveloper.Name = "lblAboutDeveloper";
            this.lblAboutDeveloper.Size = new System.Drawing.Size(438, 21);
            this.lblAboutDeveloper.TabIndex = 22;
            this.lblAboutDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutCopyright
            // 
            this.lblAboutCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutCopyright.Location = new System.Drawing.Point(296, 66);
            this.lblAboutCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAboutCopyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.lblAboutCopyright.Name = "lblAboutCopyright";
            this.lblAboutCopyright.Size = new System.Drawing.Size(438, 21);
            this.lblAboutCopyright.TabIndex = 21;
            this.lblAboutCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutVersion.Location = new System.Drawing.Point(296, 33);
            this.lblAboutVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAboutVersion.MaximumSize = new System.Drawing.Size(0, 21);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(438, 21);
            this.lblAboutVersion.TabIndex = 0;
            this.lblAboutVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutName
            // 
            this.lblAboutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutName.Location = new System.Drawing.Point(296, 0);
            this.lblAboutName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAboutName.MaximumSize = new System.Drawing.Size(0, 21);
            this.lblAboutName.Name = "lblAboutName";
            this.lblAboutName.Size = new System.Drawing.Size(438, 21);
            this.lblAboutName.TabIndex = 19;
            this.lblAboutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(634, 308);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(280, 331);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15989F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84011F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblAboutName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAboutVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblAboutCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblAboutDeveloper, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblAboutDescription, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(738, 339);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // About
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 361);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lblAboutDescription;
        private System.Windows.Forms.Label lblAboutDeveloper;
        private System.Windows.Forms.Label lblAboutCopyright;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.Label lblAboutName;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
