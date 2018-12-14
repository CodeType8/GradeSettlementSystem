namespace GradeCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAndBackToCheckListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckList = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DataSheet = new System.Windows.Forms.DataGridView();
            this.btnFinalScore = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.layResult = new System.Windows.Forms.TableLayoutPanel();
            this.layRequire = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAttedence = new System.Windows.Forms.Label();
            this.txtAttedence = new System.Windows.Forms.TextBox();
            this.lblInclass = new System.Windows.Forms.Label();
            this.txtInclass = new System.Windows.Forms.TextBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAttendence2 = new System.Windows.Forms.Label();
            this.resultAttendence = new System.Windows.Forms.Label();
            this.emptyAttendence = new System.Windows.Forms.Label();
            this.lblInclass2 = new System.Windows.Forms.Label();
            this.resultInclass = new System.Windows.Forms.Label();
            this.emptyInclass = new System.Windows.Forms.Label();
            this.lblAssignment2 = new System.Windows.Forms.Label();
            this.resultAssignment = new System.Windows.Forms.Label();
            this.emptyAssignment = new System.Windows.Forms.Label();
            this.lblMidterm2 = new System.Windows.Forms.Label();
            this.resultMidterm = new System.Windows.Forms.Label();
            this.emptyMidterm = new System.Windows.Forms.Label();
            this.lblFinal2 = new System.Windows.Forms.Label();
            this.resultFinal = new System.Windows.Forms.Label();
            this.emptyFinal = new System.Windows.Forms.Label();
            this.lblOthers2 = new System.Windows.Forms.Label();
            this.resultOther = new System.Windows.Forms.Label();
            this.emptyOthers = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.resultTotal = new System.Windows.Forms.Label();
            this.resultTotal2 = new System.Windows.Forms.Label();
            this.resultTotal3 = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSheet)).BeginInit();
            this.layResult.SuspendLayout();
            this.layRequire.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.menuData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuLoad,
            this.toolStripSeparator1,
            this.menuExit});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "&Files";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(181, 26);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(181, 26);
            this.menuLoad.Text = "&Load";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(181, 26);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp,
            this.toolStripSeparator2,
            this.menuAbout});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "&View";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(181, 26);
            this.menuHelp.Text = "&Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(181, 26);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAndBackToCheckListToolStripMenuItem});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(53, 24);
            this.menuData.Text = "&Data";
            this.menuData.Visible = false;
            // 
            // resetAndBackToCheckListToolStripMenuItem
            // 
            this.resetAndBackToCheckListToolStripMenuItem.Name = "resetAndBackToCheckListToolStripMenuItem";
            this.resetAndBackToCheckListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.resetAndBackToCheckListToolStripMenuItem.Text = "&Reset && Restart";
            this.resetAndBackToCheckListToolStripMenuItem.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 28);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(65, 23);
            this.Label.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 23);
            this.lblStatus.Text = "Ready to use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class Name:";
            this.label3.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(368, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "temp";
            this.lblName.Visible = false;
            // 
            // btnName
            // 
            this.btnName.AutoSize = true;
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(469, 3);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(40, 28);
            this.btnName.TabIndex = 7;
            this.btnName.Text = "&OK";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(115, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 27);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnNameEdit
            // 
            this.btnNameEdit.AutoSize = true;
            this.btnNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameEdit.Location = new System.Drawing.Point(420, 3);
            this.btnNameEdit.Name = "btnNameEdit";
            this.btnNameEdit.Size = new System.Drawing.Size(43, 28);
            this.btnNameEdit.TabIndex = 9;
            this.btnNameEdit.Text = "&Edit";
            this.btnNameEdit.UseVisualStyleBackColor = true;
            this.btnNameEdit.Visible = false;
            this.btnNameEdit.Click += new System.EventHandler(this.btnNameEdit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.btnNameEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(947, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CheckList
            // 
            this.CheckList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckList.FormattingEnabled = true;
            this.CheckList.Items.AddRange(new object[] {
            "Attendence",
            "In-class works",
            "Assignments",
            "Midterm",
            "Final",
            "Others"});
            this.CheckList.Location = new System.Drawing.Point(0, 98);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(947, 158);
            this.CheckList.TabIndex = 3;
            this.CheckList.Visible = false;
            this.CheckList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckList_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(947, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Update the checked data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DataSheet
            // 
            this.DataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layResult.SetColumnSpan(this.DataSheet, 3);
            this.DataSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataSheet.Location = new System.Drawing.Point(133, 3);
            this.DataSheet.Name = "DataSheet";
            this.DataSheet.RowTemplate.Height = 24;
            this.DataSheet.Size = new System.Drawing.Size(611, 342);
            this.DataSheet.TabIndex = 1;
            // 
            // btnFinalScore
            // 
            this.btnFinalScore.AutoSize = true;
            this.btnFinalScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalScore.Location = new System.Drawing.Point(133, 351);
            this.btnFinalScore.Name = "btnFinalScore";
            this.btnFinalScore.Size = new System.Drawing.Size(197, 34);
            this.btnFinalScore.TabIndex = 3;
            this.btnFinalScore.Text = "&Get require Final Score";
            this.btnFinalScore.UseVisualStyleBackColor = true;
            this.btnFinalScore.Click += new System.EventHandler(this.btnFinalScore_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(336, 351);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(175, 34);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Get &Total Grade";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // layResult
            // 
            this.layResult.ColumnCount = 5;
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layResult.Controls.Add(this.DataSheet, 1, 0);
            this.layResult.Controls.Add(this.layRequire, 0, 0);
            this.layResult.Controls.Add(this.btnTotal, 2, 1);
            this.layResult.Controls.Add(this.btnFinalScore, 1, 1);
            this.layResult.Controls.Add(this.flowLayoutPanel2, 4, 0);
            this.layResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layResult.Location = new System.Drawing.Point(0, 286);
            this.layResult.Name = "layResult";
            this.layResult.RowCount = 2;
            this.layResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layResult.Size = new System.Drawing.Size(947, 388);
            this.layResult.TabIndex = 4;
            this.layResult.Visible = false;
            // 
            // layRequire
            // 
            this.layRequire.Controls.Add(this.label1);
            this.layRequire.Controls.Add(this.label2);
            this.layRequire.Controls.Add(this.txtA);
            this.layRequire.Controls.Add(this.label4);
            this.layRequire.Controls.Add(this.txtB);
            this.layRequire.Controls.Add(this.label5);
            this.layRequire.Controls.Add(this.txtC);
            this.layRequire.Controls.Add(this.label6);
            this.layRequire.Controls.Add(this.lblCategory);
            this.layRequire.Controls.Add(this.lblAttedence);
            this.layRequire.Controls.Add(this.txtAttedence);
            this.layRequire.Controls.Add(this.lblInclass);
            this.layRequire.Controls.Add(this.txtInclass);
            this.layRequire.Controls.Add(this.lblAssignment);
            this.layRequire.Controls.Add(this.txtAssignment);
            this.layRequire.Controls.Add(this.lblMidterm);
            this.layRequire.Controls.Add(this.txtMidterm);
            this.layRequire.Controls.Add(this.lblFinal);
            this.layRequire.Controls.Add(this.txtFinal);
            this.layRequire.Controls.Add(this.lblOther);
            this.layRequire.Controls.Add(this.txtOther);
            this.layRequire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layRequire.Location = new System.Drawing.Point(3, 3);
            this.layRequire.Name = "layRequire";
            this.layResult.SetRowSpan(this.layRequire, 2);
            this.layRequire.Size = new System.Drawing.Size(124, 382);
            this.layRequire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Require Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percent for A:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(3, 77);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 24);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Percent for B:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(3, 125);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 24);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Percent for C:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(3, 173);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 24);
            this.txtC.TabIndex = 2;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 33);
            this.label6.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 233);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 56);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Percent of Category: ";
            // 
            // lblAttedence
            // 
            this.lblAttedence.AutoSize = true;
            this.lblAttedence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttedence.Location = new System.Drawing.Point(3, 289);
            this.lblAttedence.Name = "lblAttedence";
            this.lblAttedence.Size = new System.Drawing.Size(85, 18);
            this.lblAttedence.TabIndex = 3;
            this.lblAttedence.Text = "Attendence:";
            this.lblAttedence.Visible = false;
            // 
            // txtAttedence
            // 
            this.txtAttedence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttedence.Location = new System.Drawing.Point(3, 310);
            this.txtAttedence.Name = "txtAttedence";
            this.txtAttedence.Size = new System.Drawing.Size(100, 24);
            this.txtAttedence.TabIndex = 3;
            this.txtAttedence.Visible = false;
            this.txtAttedence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // lblInclass
            // 
            this.lblInclass.AutoSize = true;
            this.lblInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclass.Location = new System.Drawing.Point(3, 337);
            this.lblInclass.Name = "lblInclass";
            this.lblInclass.Size = new System.Drawing.Size(100, 18);
            this.lblInclass.TabIndex = 6;
            this.lblInclass.Text = "In-class work:";
            this.lblInclass.Visible = false;
            // 
            // txtInclass
            // 
            this.txtInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclass.Location = new System.Drawing.Point(3, 358);
            this.txtInclass.Name = "txtInclass";
            this.txtInclass.Size = new System.Drawing.Size(100, 24);
            this.txtInclass.TabIndex = 4;
            this.txtInclass.Visible = false;
            this.txtInclass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(3, 385);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(93, 18);
            this.lblAssignment.TabIndex = 8;
            this.lblAssignment.Text = "Assignment: ";
            this.lblAssignment.Visible = false;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignment.Location = new System.Drawing.Point(3, 406);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(100, 24);
            this.txtAssignment.TabIndex = 5;
            this.txtAssignment.Visible = false;
            this.txtAssignment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(3, 433);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(70, 18);
            this.lblMidterm.TabIndex = 10;
            this.lblMidterm.Text = "Midterm: ";
            this.lblMidterm.Visible = false;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.Location = new System.Drawing.Point(3, 454);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(100, 24);
            this.txtMidterm.TabIndex = 6;
            this.txtMidterm.Visible = false;
            this.txtMidterm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(3, 481);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(89, 18);
            this.lblFinal.TabIndex = 11;
            this.lblFinal.Text = "Final Exam: ";
            this.lblFinal.Visible = false;
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(3, 502);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 24);
            this.txtFinal.TabIndex = 7;
            this.txtFinal.Visible = false;
            this.txtFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(3, 529);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(53, 18);
            this.lblOther.TabIndex = 12;
            this.lblOther.Text = "Other: ";
            this.lblOther.Visible = false;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(3, 550);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 24);
            this.txtOther.TabIndex = 8;
            this.txtOther.Visible = false;
            this.txtOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumAndPoint_KeyPress);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblAttendence2);
            this.flowLayoutPanel2.Controls.Add(this.resultAttendence);
            this.flowLayoutPanel2.Controls.Add(this.emptyAttendence);
            this.flowLayoutPanel2.Controls.Add(this.lblInclass2);
            this.flowLayoutPanel2.Controls.Add(this.resultInclass);
            this.flowLayoutPanel2.Controls.Add(this.emptyInclass);
            this.flowLayoutPanel2.Controls.Add(this.lblAssignment2);
            this.flowLayoutPanel2.Controls.Add(this.resultAssignment);
            this.flowLayoutPanel2.Controls.Add(this.emptyAssignment);
            this.flowLayoutPanel2.Controls.Add(this.lblMidterm2);
            this.flowLayoutPanel2.Controls.Add(this.resultMidterm);
            this.flowLayoutPanel2.Controls.Add(this.emptyMidterm);
            this.flowLayoutPanel2.Controls.Add(this.lblFinal2);
            this.flowLayoutPanel2.Controls.Add(this.resultFinal);
            this.flowLayoutPanel2.Controls.Add(this.emptyFinal);
            this.flowLayoutPanel2.Controls.Add(this.lblOthers2);
            this.flowLayoutPanel2.Controls.Add(this.resultOther);
            this.flowLayoutPanel2.Controls.Add(this.emptyOthers);
            this.flowLayoutPanel2.Controls.Add(this.lblTotal);
            this.flowLayoutPanel2.Controls.Add(this.resultTotal);
            this.flowLayoutPanel2.Controls.Add(this.resultTotal2);
            this.flowLayoutPanel2.Controls.Add(this.resultTotal3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(750, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.layResult.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 382);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lblAttendence2
            // 
            this.lblAttendence2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence2.Location = new System.Drawing.Point(3, 0);
            this.lblAttendence2.Name = "lblAttendence2";
            this.lblAttendence2.Size = new System.Drawing.Size(180, 20);
            this.lblAttendence2.TabIndex = 0;
            this.lblAttendence2.Text = "Attendence:";
            this.lblAttendence2.Visible = false;
            // 
            // resultAttendence
            // 
            this.resultAttendence.AutoSize = true;
            this.resultAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultAttendence.Location = new System.Drawing.Point(3, 20);
            this.resultAttendence.Name = "resultAttendence";
            this.resultAttendence.Size = new System.Drawing.Size(119, 20);
            this.resultAttendence.TabIndex = 1;
            this.resultAttendence.Text = "Not Calculated";
            this.resultAttendence.Visible = false;
            // 
            // emptyAttendence
            // 
            this.emptyAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyAttendence.Location = new System.Drawing.Point(3, 40);
            this.emptyAttendence.Name = "emptyAttendence";
            this.emptyAttendence.Size = new System.Drawing.Size(180, 30);
            this.emptyAttendence.TabIndex = 6;
            this.emptyAttendence.Visible = false;
            // 
            // lblInclass2
            // 
            this.lblInclass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclass2.Location = new System.Drawing.Point(3, 70);
            this.lblInclass2.Name = "lblInclass2";
            this.lblInclass2.Size = new System.Drawing.Size(180, 20);
            this.lblInclass2.TabIndex = 2;
            this.lblInclass2.Text = "In-class Work: ";
            this.lblInclass2.Visible = false;
            // 
            // resultInclass
            // 
            this.resultInclass.AutoSize = true;
            this.resultInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultInclass.Location = new System.Drawing.Point(3, 90);
            this.resultInclass.Name = "resultInclass";
            this.resultInclass.Size = new System.Drawing.Size(119, 20);
            this.resultInclass.TabIndex = 3;
            this.resultInclass.Text = "Not Calculated";
            this.resultInclass.Visible = false;
            // 
            // emptyInclass
            // 
            this.emptyInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyInclass.Location = new System.Drawing.Point(3, 110);
            this.emptyInclass.Name = "emptyInclass";
            this.emptyInclass.Size = new System.Drawing.Size(182, 29);
            this.emptyInclass.TabIndex = 12;
            this.emptyInclass.Visible = false;
            // 
            // lblAssignment2
            // 
            this.lblAssignment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment2.Location = new System.Drawing.Point(3, 139);
            this.lblAssignment2.Name = "lblAssignment2";
            this.lblAssignment2.Size = new System.Drawing.Size(180, 20);
            this.lblAssignment2.TabIndex = 4;
            this.lblAssignment2.Text = "Assignment: ";
            this.lblAssignment2.Visible = false;
            // 
            // resultAssignment
            // 
            this.resultAssignment.AutoSize = true;
            this.resultAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultAssignment.Location = new System.Drawing.Point(3, 159);
            this.resultAssignment.Name = "resultAssignment";
            this.resultAssignment.Size = new System.Drawing.Size(119, 20);
            this.resultAssignment.TabIndex = 5;
            this.resultAssignment.Text = "Not Calculated";
            this.resultAssignment.Visible = false;
            // 
            // emptyAssignment
            // 
            this.emptyAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyAssignment.Location = new System.Drawing.Point(3, 179);
            this.emptyAssignment.Name = "emptyAssignment";
            this.emptyAssignment.Size = new System.Drawing.Size(182, 29);
            this.emptyAssignment.TabIndex = 11;
            this.emptyAssignment.Visible = false;
            // 
            // lblMidterm2
            // 
            this.lblMidterm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm2.Location = new System.Drawing.Point(3, 208);
            this.lblMidterm2.Name = "lblMidterm2";
            this.lblMidterm2.Size = new System.Drawing.Size(180, 20);
            this.lblMidterm2.TabIndex = 7;
            this.lblMidterm2.Text = "Midterm: ";
            this.lblMidterm2.Visible = false;
            // 
            // resultMidterm
            // 
            this.resultMidterm.AutoSize = true;
            this.resultMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMidterm.Location = new System.Drawing.Point(3, 228);
            this.resultMidterm.Name = "resultMidterm";
            this.resultMidterm.Size = new System.Drawing.Size(119, 20);
            this.resultMidterm.TabIndex = 8;
            this.resultMidterm.Text = "Not Calculated";
            this.resultMidterm.Visible = false;
            // 
            // emptyMidterm
            // 
            this.emptyMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyMidterm.Location = new System.Drawing.Point(3, 248);
            this.emptyMidterm.Name = "emptyMidterm";
            this.emptyMidterm.Size = new System.Drawing.Size(182, 29);
            this.emptyMidterm.TabIndex = 13;
            this.emptyMidterm.Visible = false;
            // 
            // lblFinal2
            // 
            this.lblFinal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal2.Location = new System.Drawing.Point(3, 277);
            this.lblFinal2.Name = "lblFinal2";
            this.lblFinal2.Size = new System.Drawing.Size(180, 20);
            this.lblFinal2.TabIndex = 9;
            this.lblFinal2.Text = "Final: ";
            this.lblFinal2.Visible = false;
            // 
            // resultFinal
            // 
            this.resultFinal.AutoSize = true;
            this.resultFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultFinal.Location = new System.Drawing.Point(3, 297);
            this.resultFinal.Name = "resultFinal";
            this.resultFinal.Size = new System.Drawing.Size(119, 20);
            this.resultFinal.TabIndex = 10;
            this.resultFinal.Text = "Not Calculated";
            this.resultFinal.Visible = false;
            // 
            // emptyFinal
            // 
            this.emptyFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyFinal.Location = new System.Drawing.Point(3, 317);
            this.emptyFinal.Name = "emptyFinal";
            this.emptyFinal.Size = new System.Drawing.Size(182, 29);
            this.emptyFinal.TabIndex = 13;
            this.emptyFinal.Visible = false;
            // 
            // lblOthers2
            // 
            this.lblOthers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers2.Location = new System.Drawing.Point(3, 346);
            this.lblOthers2.Name = "lblOthers2";
            this.lblOthers2.Size = new System.Drawing.Size(180, 20);
            this.lblOthers2.TabIndex = 9;
            this.lblOthers2.Text = "Others: ";
            this.lblOthers2.Visible = false;
            // 
            // resultOther
            // 
            this.resultOther.AutoSize = true;
            this.resultOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultOther.Location = new System.Drawing.Point(3, 366);
            this.resultOther.Name = "resultOther";
            this.resultOther.Size = new System.Drawing.Size(119, 20);
            this.resultOther.TabIndex = 10;
            this.resultOther.Text = "Not Calculated";
            this.resultOther.Visible = false;
            // 
            // emptyOthers
            // 
            this.emptyOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyOthers.Location = new System.Drawing.Point(3, 386);
            this.emptyOthers.Name = "emptyOthers";
            this.emptyOthers.Size = new System.Drawing.Size(182, 29);
            this.emptyOthers.TabIndex = 14;
            this.emptyOthers.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 415);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Visible = false;
            // 
            // resultTotal
            // 
            this.resultTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTotal.Location = new System.Drawing.Point(3, 435);
            this.resultTotal.Name = "resultTotal";
            this.resultTotal.Size = new System.Drawing.Size(180, 20);
            this.resultTotal.TabIndex = 16;
            this.resultTotal.Visible = false;
            // 
            // resultTotal2
            // 
            this.resultTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTotal2.Location = new System.Drawing.Point(3, 455);
            this.resultTotal2.Name = "resultTotal2";
            this.resultTotal2.Size = new System.Drawing.Size(180, 20);
            this.resultTotal2.TabIndex = 17;
            this.resultTotal2.Visible = false;
            // 
            // resultTotal3
            // 
            this.resultTotal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTotal3.Location = new System.Drawing.Point(3, 475);
            this.resultTotal3.Name = "resultTotal3";
            this.resultTotal3.Size = new System.Drawing.Size(180, 20);
            this.resultTotal3.TabIndex = 18;
            this.resultTotal3.Visible = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(0, 62);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(947, 36);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Choose categories that need to grade you class.";
            this.lblInstruction.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 702);
            this.Controls.Add(this.layResult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSheet)).EndInit();
            this.layResult.ResumeLayout(false);
            this.layResult.PerformLayout();
            this.layRequire.ResumeLayout(false);
            this.layRequire.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Label;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox CheckList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView DataSheet;
        private System.Windows.Forms.TableLayoutPanel layResult;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnFinalScore;
        private System.Windows.Forms.FlowLayoutPanel layRequire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAttedence;
        private System.Windows.Forms.TextBox txtAttedence;
        private System.Windows.Forms.Label lblInclass;
        private System.Windows.Forms.TextBox txtInclass;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem resetAndBackToCheckListToolStripMenuItem;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAttendence2;
        private System.Windows.Forms.Label resultAttendence;
        private System.Windows.Forms.Label emptyAttendence;
        private System.Windows.Forms.Label lblInclass2;
        private System.Windows.Forms.Label resultInclass;
        private System.Windows.Forms.Label emptyInclass;
        private System.Windows.Forms.Label lblAssignment2;
        private System.Windows.Forms.Label resultAssignment;
        private System.Windows.Forms.Label emptyAssignment;
        private System.Windows.Forms.Label lblMidterm2;
        private System.Windows.Forms.Label resultMidterm;
        private System.Windows.Forms.Label emptyMidterm;
        private System.Windows.Forms.Label lblFinal2;
        private System.Windows.Forms.Label resultFinal;
        private System.Windows.Forms.Label emptyFinal;
        private System.Windows.Forms.Label lblOthers2;
        private System.Windows.Forms.Label resultOther;
        private System.Windows.Forms.Label emptyOthers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label resultTotal;
        private System.Windows.Forms.Label resultTotal2;
        private System.Windows.Forms.Label resultTotal3;
    }
}

