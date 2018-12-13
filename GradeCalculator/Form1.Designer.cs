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
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.layResult = new System.Windows.Forms.TableLayoutPanel();
            this.layRequire = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.menuSave.Size = new System.Drawing.Size(117, 26);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(117, 26);
            this.menuLoad.Text = "&Load";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(117, 26);
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
            this.menuHelp.Size = new System.Drawing.Size(125, 26);
            this.menuHelp.Text = "&Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(125, 26);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAndBackToCheckListToolStripMenuItem});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(53, 24);
            this.menuData.Text = "Data";
            this.menuData.Visible = false;
            // 
            // resetAndBackToCheckListToolStripMenuItem
            // 
            this.resetAndBackToCheckListToolStripMenuItem.Name = "resetAndBackToCheckListToolStripMenuItem";
            this.resetAndBackToCheckListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.resetAndBackToCheckListToolStripMenuItem.Text = "Reset && Restart";
            this.resetAndBackToCheckListToolStripMenuItem.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 28);
            this.statusStrip1.TabIndex = 1;
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
            this.label3.TabIndex = 5;
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
            this.txtName.TabIndex = 8;
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
            this.flowLayoutPanel1.TabIndex = 10;
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
            this.CheckList.Location = new System.Drawing.Point(0, 62);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(947, 158);
            this.CheckList.TabIndex = 12;
            this.CheckList.Visible = false;
            this.CheckList.SelectedValueChanged += new System.EventHandler(this.CheckList_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(947, 30);
            this.btnUpdate.TabIndex = 7;
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
            this.DataSheet.Size = new System.Drawing.Size(661, 332);
            this.DataSheet.TabIndex = 14;
            // 
            // btnFinal
            // 
            this.btnFinal.AutoSize = true;
            this.btnFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.Location = new System.Drawing.Point(133, 341);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(197, 34);
            this.btnFinal.TabIndex = 0;
            this.btnFinal.Text = "Get &Require Final Score";
            this.btnFinal.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.AutoSize = true;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(336, 341);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(175, 34);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Get &Total Grade";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // layResult
            // 
            this.layResult.ColumnCount = 5;
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layResult.Controls.Add(this.DataSheet, 1, 0);
            this.layResult.Controls.Add(this.btnFinal, 1, 1);
            this.layResult.Controls.Add(this.btnResult, 2, 1);
            this.layResult.Controls.Add(this.layRequire, 0, 0);
            this.layResult.Controls.Add(this.flowLayoutPanel2, 4, 0);
            this.layResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layResult.Location = new System.Drawing.Point(0, 250);
            this.layResult.Name = "layResult";
            this.layResult.RowCount = 2;
            this.layResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layResult.Size = new System.Drawing.Size(947, 378);
            this.layResult.TabIndex = 16;
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
            this.layRequire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layRequire.Location = new System.Drawing.Point(3, 3);
            this.layRequire.Name = "layRequire";
            this.layRequire.Size = new System.Drawing.Size(124, 332);
            this.layRequire.TabIndex = 15;
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
            this.txtA.TabIndex = 1;
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
            this.txtB.TabIndex = 4;
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
            this.txtC.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblCategory);
            this.flowLayoutPanel2.Controls.Add(this.lblAttedence);
            this.flowLayoutPanel2.Controls.Add(this.txtAttedence);
            this.flowLayoutPanel2.Controls.Add(this.lblInclass);
            this.flowLayoutPanel2.Controls.Add(this.txtInclass);
            this.flowLayoutPanel2.Controls.Add(this.lblAssignment);
            this.flowLayoutPanel2.Controls.Add(this.txtAssignment);
            this.flowLayoutPanel2.Controls.Add(this.lblMidterm);
            this.flowLayoutPanel2.Controls.Add(this.txtMidterm);
            this.flowLayoutPanel2.Controls.Add(this.lblFinal);
            this.flowLayoutPanel2.Controls.Add(this.txtFinal);
            this.flowLayoutPanel2.Controls.Add(this.lblOther);
            this.flowLayoutPanel2.Controls.Add(this.txtOther);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(800, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(144, 332);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 56);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Percent of Category: ";
            // 
            // lblAttedence
            // 
            this.lblAttedence.AutoSize = true;
            this.lblAttedence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttedence.Location = new System.Drawing.Point(3, 56);
            this.lblAttedence.Name = "lblAttedence";
            this.lblAttedence.Size = new System.Drawing.Size(85, 18);
            this.lblAttedence.TabIndex = 3;
            this.lblAttedence.Text = "Attendence:";
            this.lblAttedence.Visible = false;
            // 
            // txtAttedence
            // 
            this.txtAttedence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttedence.Location = new System.Drawing.Point(3, 77);
            this.txtAttedence.Name = "txtAttedence";
            this.txtAttedence.Size = new System.Drawing.Size(100, 24);
            this.txtAttedence.TabIndex = 4;
            this.txtAttedence.Visible = false;
            // 
            // lblInclass
            // 
            this.lblInclass.AutoSize = true;
            this.lblInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclass.Location = new System.Drawing.Point(3, 104);
            this.lblInclass.Name = "lblInclass";
            this.lblInclass.Size = new System.Drawing.Size(100, 18);
            this.lblInclass.TabIndex = 6;
            this.lblInclass.Text = "In-class work:";
            this.lblInclass.Visible = false;
            // 
            // txtInclass
            // 
            this.txtInclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclass.Location = new System.Drawing.Point(3, 125);
            this.txtInclass.Name = "txtInclass";
            this.txtInclass.Size = new System.Drawing.Size(100, 24);
            this.txtInclass.TabIndex = 7;
            this.txtInclass.Visible = false;
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(3, 152);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(93, 18);
            this.lblAssignment.TabIndex = 8;
            this.lblAssignment.Text = "Assignment: ";
            this.lblAssignment.Visible = false;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignment.Location = new System.Drawing.Point(3, 173);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(100, 24);
            this.txtAssignment.TabIndex = 9;
            this.txtAssignment.Visible = false;
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(3, 200);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(70, 18);
            this.lblMidterm.TabIndex = 10;
            this.lblMidterm.Text = "Midterm: ";
            this.lblMidterm.Visible = false;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.Location = new System.Drawing.Point(3, 221);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(100, 24);
            this.txtMidterm.TabIndex = 15;
            this.txtMidterm.Visible = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(3, 248);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(89, 18);
            this.lblFinal.TabIndex = 11;
            this.lblFinal.Text = "Final Exam: ";
            this.lblFinal.Visible = false;
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(3, 269);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 24);
            this.txtFinal.TabIndex = 13;
            this.txtFinal.Visible = false;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(3, 296);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(53, 18);
            this.lblOther.TabIndex = 12;
            this.lblOther.Text = "Other: ";
            this.lblOther.Visible = false;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(3, 317);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 24);
            this.txtOther.TabIndex = 14;
            this.txtOther.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 656);
            this.Controls.Add(this.layResult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.CheckList);
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnFinal;
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
    }
}

