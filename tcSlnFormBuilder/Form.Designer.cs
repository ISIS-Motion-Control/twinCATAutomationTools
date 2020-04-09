namespace tcSlnFormBuilder
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
            this.butCreateSolution = new System.Windows.Forms.Button();
            this.folderBrowseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.labelDirSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSlnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBaseDir = new System.Windows.Forms.Label();
            this.folderBrowserBaseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAddBasePrj = new System.Windows.Forms.Button();
            this.buttonCloneRepo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGetSln = new System.Windows.Forms.Button();
            this.getPrj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butConsumeMap = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xmlFileSelect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xmlSaveDirectory = new System.Windows.Forms.Label();
            this.xmlDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.xmlName = new System.Windows.Forms.TextBox();
            this.butNcCreate = new System.Windows.Forms.Button();
            this.butCreateAxis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.butDeleteNC = new System.Windows.Forms.Button();
            this.butGrabProject = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.solutionFileSelect = new System.Windows.Forms.TextBox();
            this.openSolutionSelect = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.xmlFileSelectHW = new System.Windows.Forms.TextBox();
            this.butAddHardware = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.xmlFolderSelect = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.butOpenDTE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butCreateSolution
            // 
            this.butCreateSolution.Location = new System.Drawing.Point(598, 100);
            this.butCreateSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateSolution.Name = "butCreateSolution";
            this.butCreateSolution.Size = new System.Drawing.Size(179, 46);
            this.butCreateSolution.TabIndex = 0;
            this.butCreateSolution.Text = "Create Solution";
            this.butCreateSolution.UseVisualStyleBackColor = true;
            this.butCreateSolution.Click += new System.EventHandler(this.butCreateSolution_Click);
            // 
            // labelDirSelected
            // 
            this.labelDirSelected.BackColor = System.Drawing.SystemColors.Window;
            this.labelDirSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDirSelected.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDirSelected.Location = new System.Drawing.Point(212, 113);
            this.labelDirSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirSelected.Name = "labelDirSelected";
            this.labelDirSelected.Size = new System.Drawing.Size(366, 28);
            this.labelDirSelected.TabIndex = 2;
            this.labelDirSelected.Text = "labelDirSelected";
            this.labelDirSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDirSelected.Click += new System.EventHandler(this.labelDirSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSlnName
            // 
            this.textSlnName.Location = new System.Drawing.Point(211, 160);
            this.textSlnName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSlnName.Name = "textSlnName";
            this.textSlnName.Size = new System.Drawing.Size(360, 26);
            this.textSlnName.TabIndex = 4;
            this.textSlnName.TextChanged += new System.EventHandler(this.textSlnName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Solution:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Base Project Dir:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBaseDir
            // 
            this.labelBaseDir.BackColor = System.Drawing.SystemColors.Window;
            this.labelBaseDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBaseDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelBaseDir.Location = new System.Drawing.Point(177, 289);
            this.labelBaseDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaseDir.Name = "labelBaseDir";
            this.labelBaseDir.Size = new System.Drawing.Size(366, 28);
            this.labelBaseDir.TabIndex = 6;
            this.labelBaseDir.Text = "labelBaseDir";
            this.labelBaseDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBaseDir.Click += new System.EventHandler(this.labelBaseDir_Click);
            // 
            // buttonAddBasePrj
            // 
            this.buttonAddBasePrj.Location = new System.Drawing.Point(364, 334);
            this.buttonAddBasePrj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddBasePrj.Name = "buttonAddBasePrj";
            this.buttonAddBasePrj.Size = new System.Drawing.Size(179, 46);
            this.buttonAddBasePrj.TabIndex = 8;
            this.buttonAddBasePrj.Text = "Add Base Project";
            this.buttonAddBasePrj.UseVisualStyleBackColor = true;
            this.buttonAddBasePrj.Click += new System.EventHandler(this.buttonAddBasePrj_Click);
            // 
            // buttonCloneRepo
            // 
            this.buttonCloneRepo.Location = new System.Drawing.Point(177, 334);
            this.buttonCloneRepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCloneRepo.Name = "buttonCloneRepo";
            this.buttonCloneRepo.Size = new System.Drawing.Size(179, 46);
            this.buttonCloneRepo.TabIndex = 9;
            this.buttonCloneRepo.Text = "Clone Repo";
            this.buttonCloneRepo.UseVisualStyleBackColor = true;
            this.buttonCloneRepo.Click += new System.EventHandler(this.buttonCloneRepo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "ProduceMap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetSln
            // 
            this.buttonGetSln.Location = new System.Drawing.Point(598, 156);
            this.buttonGetSln.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetSln.Name = "buttonGetSln";
            this.buttonGetSln.Size = new System.Drawing.Size(179, 46);
            this.buttonGetSln.TabIndex = 11;
            this.buttonGetSln.Text = "GetSln";
            this.buttonGetSln.UseVisualStyleBackColor = true;
            this.buttonGetSln.Click += new System.EventHandler(this.buttonGetSln_Click);
            // 
            // getPrj
            // 
            this.getPrj.Location = new System.Drawing.Point(598, 212);
            this.getPrj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getPrj.Name = "getPrj";
            this.getPrj.Size = new System.Drawing.Size(179, 46);
            this.getPrj.TabIndex = 12;
            this.getPrj.Text = "Find PLC Project";
            this.getPrj.UseVisualStyleBackColor = true;
            this.getPrj.Click += new System.EventHandler(this.getPrj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 198);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butConsumeMap
            // 
            this.butConsumeMap.Location = new System.Drawing.Point(551, 616);
            this.butConsumeMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butConsumeMap.Name = "butConsumeMap";
            this.butConsumeMap.Size = new System.Drawing.Size(179, 46);
            this.butConsumeMap.TabIndex = 14;
            this.butConsumeMap.Text = "ConsumeMap";
            this.butConsumeMap.UseVisualStyleBackColor = true;
            this.butConsumeMap.Click += new System.EventHandler(this.butConsumeMap_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xmlFileSelect
            // 
            this.xmlFileSelect.Location = new System.Drawing.Point(177, 625);
            this.xmlFileSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xmlFileSelect.Name = "xmlFileSelect";
            this.xmlFileSelect.Size = new System.Drawing.Size(365, 26);
            this.xmlFileSelect.TabIndex = 15;
            this.xmlFileSelect.Click += new System.EventHandler(this.xmlFileSelect_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 620);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xml Map:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "XML Save Directory:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlSaveDirectory
            // 
            this.xmlSaveDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.xmlSaveDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xmlSaveDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xmlSaveDirectory.Location = new System.Drawing.Point(177, 565);
            this.xmlSaveDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xmlSaveDirectory.Name = "xmlSaveDirectory";
            this.xmlSaveDirectory.Size = new System.Drawing.Size(366, 28);
            this.xmlSaveDirectory.TabIndex = 18;
            this.xmlSaveDirectory.Text = "label6";
            this.xmlSaveDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xmlSaveDirectory.Click += new System.EventHandler(this.xmlSaveDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 596);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "XML File Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlName
            // 
            this.xmlName.Location = new System.Drawing.Point(177, 596);
            this.xmlName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xmlName.Name = "xmlName";
            this.xmlName.Size = new System.Drawing.Size(365, 26);
            this.xmlName.TabIndex = 21;
            this.xmlName.TextChanged += new System.EventHandler(this.xmlName_TextChanged);
            // 
            // butNcCreate
            // 
            this.butNcCreate.Location = new System.Drawing.Point(771, 504);
            this.butNcCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNcCreate.Name = "butNcCreate";
            this.butNcCreate.Size = new System.Drawing.Size(179, 46);
            this.butNcCreate.TabIndex = 22;
            this.butNcCreate.Text = "CreateNC";
            this.butNcCreate.UseVisualStyleBackColor = true;
            this.butNcCreate.Click += new System.EventHandler(this.butNcCreate_Click);
            // 
            // butCreateAxis
            // 
            this.butCreateAxis.Location = new System.Drawing.Point(771, 560);
            this.butCreateAxis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateAxis.Name = "butCreateAxis";
            this.butCreateAxis.Size = new System.Drawing.Size(179, 46);
            this.butCreateAxis.TabIndex = 23;
            this.butCreateAxis.Text = "CreateAxis";
            this.butCreateAxis.UseVisualStyleBackColor = true;
            this.butCreateAxis.Click += new System.EventHandler(this.butCreateAxis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "PLC Project to Search";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butDeleteNC
            // 
            this.butDeleteNC.Location = new System.Drawing.Point(771, 616);
            this.butDeleteNC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeleteNC.Name = "butDeleteNC";
            this.butDeleteNC.Size = new System.Drawing.Size(179, 46);
            this.butDeleteNC.TabIndex = 25;
            this.butDeleteNC.Text = "DeleteNC";
            this.butDeleteNC.UseVisualStyleBackColor = true;
            this.butDeleteNC.Click += new System.EventHandler(this.butDeleteNC_Click);
            // 
            // butGrabProject
            // 
            this.butGrabProject.Location = new System.Drawing.Point(598, 268);
            this.butGrabProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butGrabProject.Name = "butGrabProject";
            this.butGrabProject.Size = new System.Drawing.Size(179, 46);
            this.butGrabProject.TabIndex = 26;
            this.butGrabProject.Text = "Grab Project";
            this.butGrabProject.UseVisualStyleBackColor = true;
            this.butGrabProject.Click += new System.EventHandler(this.butGrabProject_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(872, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Select Solution:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solutionFileSelect
            // 
            this.solutionFileSelect.Location = new System.Drawing.Point(1010, 166);
            this.solutionFileSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solutionFileSelect.Name = "solutionFileSelect";
            this.solutionFileSelect.Size = new System.Drawing.Size(365, 26);
            this.solutionFileSelect.TabIndex = 27;
            this.solutionFileSelect.Click += new System.EventHandler(this.solutionFileSelect_Click);
            // 
            // openSolutionSelect
            // 
            this.openSolutionSelect.DefaultExt = "sln";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(862, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Select XML Map:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlFileSelectHW
            // 
            this.xmlFileSelectHW.Location = new System.Drawing.Point(1010, 232);
            this.xmlFileSelectHW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xmlFileSelectHW.Name = "xmlFileSelectHW";
            this.xmlFileSelectHW.Size = new System.Drawing.Size(365, 26);
            this.xmlFileSelectHW.TabIndex = 29;
            this.xmlFileSelectHW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xmlFileSelectHW_MouseClick);
            // 
            // butAddHardware
            // 
            this.butAddHardware.Location = new System.Drawing.Point(876, 287);
            this.butAddHardware.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddHardware.Name = "butAddHardware";
            this.butAddHardware.Size = new System.Drawing.Size(499, 46);
            this.butAddHardware.TabIndex = 31;
            this.butAddHardware.Text = "Add Test Crate Hardware";
            this.butAddHardware.UseVisualStyleBackColor = true;
            this.butAddHardware.Click += new System.EventHandler(this.butAddHardware_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(812, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Select Hardware Folder:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlFolderSelect
            // 
            this.xmlFolderSelect.Location = new System.Drawing.Point(1010, 196);
            this.xmlFolderSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xmlFolderSelect.Name = "xmlFolderSelect";
            this.xmlFolderSelect.Size = new System.Drawing.Size(365, 26);
            this.xmlFolderSelect.TabIndex = 32;
            this.xmlFolderSelect.Click += new System.EventHandler(this.xmlFolderSelect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(499, 46);
            this.button2.TabIndex = 34;
            this.button2.Text = "ExportScan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(10, 865);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1892, 32);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(10, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1892, 33);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 150;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "VS_2010",
            "VS_2012",
            "VS_2013",
            "VS_2015",
            "VS_2017",
            "VS_2019",
            "TWINCAT_SHELL"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(180, 33);
            // 
            // butOpenDTE
            // 
            this.butOpenDTE.Location = new System.Drawing.Point(598, 44);
            this.butOpenDTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butOpenDTE.Name = "butOpenDTE";
            this.butOpenDTE.Size = new System.Drawing.Size(179, 46);
            this.butOpenDTE.TabIndex = 37;
            this.butOpenDTE.Text = "Open DTE";
            this.butOpenDTE.UseVisualStyleBackColor = true;
            this.butOpenDTE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butOpenDTE_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1378, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 420);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1912, 907);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butOpenDTE);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xmlFolderSelect);
            this.Controls.Add(this.butAddHardware);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.xmlFileSelectHW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.solutionFileSelect);
            this.Controls.Add(this.butGrabProject);
            this.Controls.Add(this.butDeleteNC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butCreateAxis);
            this.Controls.Add(this.butNcCreate);
            this.Controls.Add(this.xmlName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xmlSaveDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xmlFileSelect);
            this.Controls.Add(this.butConsumeMap);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getPrj);
            this.Controls.Add(this.buttonGetSln);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCloneRepo);
            this.Controls.Add(this.buttonAddBasePrj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBaseDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSlnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDirSelected);
            this.Controls.Add(this.butCreateSolution);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "TwinCAT Automation";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCreateSolution;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDir;
        private System.Windows.Forms.Label labelDirSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSlnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBaseDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBaseDir;
        private System.Windows.Forms.Button buttonAddBasePrj;
        private System.Windows.Forms.Button buttonCloneRepo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGetSln;
        private System.Windows.Forms.Button getPrj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butConsumeMap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox xmlFileSelect;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label xmlSaveDirectory;
        private System.Windows.Forms.FolderBrowserDialog xmlDirBrowser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xmlName;
        private System.Windows.Forms.Button butNcCreate;
        private System.Windows.Forms.Button butCreateAxis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butDeleteNC;
        private System.Windows.Forms.Button butGrabProject;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox solutionFileSelect;
        private System.Windows.Forms.OpenFileDialog openSolutionSelect;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xmlFileSelectHW;
        private System.Windows.Forms.Button butAddHardware;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox xmlFolderSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button butOpenDTE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

