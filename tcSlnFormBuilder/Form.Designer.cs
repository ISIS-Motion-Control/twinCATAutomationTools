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
            this.folderBrowserBaseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonProduceMappings = new System.Windows.Forms.Button();
            this.buttonGetSln = new System.Windows.Forms.Button();
            this.buttonConsumeMappings = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xmlDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCreateNcTask = new System.Windows.Forms.Button();
            this.buttonCreateAxis = new System.Windows.Forms.Button();
            this.buttonDeleteNcTask = new System.Windows.Forms.Button();
            this.butGrabProject = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.solutionFileSelect = new System.Windows.Forms.TextBox();
            this.openSolutionSelect = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddTestCrateConfig = new System.Windows.Forms.Button();
            this.configFolderSelect = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExportDevice1 = new System.Windows.Forms.Button();
            this.buttonImportDevice1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClearMappings = new System.Windows.Forms.Button();
            this.buttonCopySolutionDir = new System.Windows.Forms.Button();
            this.buttonImportDeviceList = new System.Windows.Forms.Button();
            this.buttonImportIoXmls = new System.Windows.Forms.Button();
            this.buttonImportNcXmls = new System.Windows.Forms.Button();
            this.buttonDeleteAxes = new System.Windows.Forms.Button();
            this.buttonDeleteIo = new System.Windows.Forms.Button();
            this.buttonCleanUp = new System.Windows.Forms.Button();
            this.buttonTesting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butCreateConfigDir = new System.Windows.Forms.Button();
            this.butAxisXmlExport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCreateSolution
            // 
            this.butCreateSolution.BackColor = System.Drawing.Color.LightCoral;
            this.butCreateSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateSolution.Location = new System.Drawing.Point(20, 105);
            this.butCreateSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateSolution.Name = "butCreateSolution";
            this.butCreateSolution.Size = new System.Drawing.Size(178, 46);
            this.butCreateSolution.TabIndex = 0;
            this.butCreateSolution.Text = "Create Solution";
            this.butCreateSolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCreateSolution.UseVisualStyleBackColor = false;
            this.butCreateSolution.Click += new System.EventHandler(this.buttonCreateSolution_Click);
            // 
            // buttonProduceMappings
            // 
            this.buttonProduceMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduceMappings.Location = new System.Drawing.Point(20, 47);
            this.buttonProduceMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProduceMappings.Name = "buttonProduceMappings";
            this.buttonProduceMappings.Size = new System.Drawing.Size(246, 46);
            this.buttonProduceMappings.TabIndex = 10;
            this.buttonProduceMappings.Text = "Produce Mappings File";
            this.buttonProduceMappings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProduceMappings.UseVisualStyleBackColor = true;
            this.buttonProduceMappings.Click += new System.EventHandler(this.buttonProduceMappings_Click);
            // 
            // buttonGetSln
            // 
            this.buttonGetSln.BackColor = System.Drawing.Color.LightCoral;
            this.buttonGetSln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetSln.Location = new System.Drawing.Point(20, 47);
            this.buttonGetSln.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetSln.Name = "buttonGetSln";
            this.buttonGetSln.Size = new System.Drawing.Size(178, 46);
            this.buttonGetSln.TabIndex = 11;
            this.buttonGetSln.Text = "Open Solution";
            this.buttonGetSln.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGetSln.UseVisualStyleBackColor = false;
            this.buttonGetSln.Click += new System.EventHandler(this.buttonOpenSolution_Click);
            // 
            // buttonConsumeMappings
            // 
            this.buttonConsumeMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsumeMappings.Location = new System.Drawing.Point(20, 103);
            this.buttonConsumeMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConsumeMappings.Name = "buttonConsumeMappings";
            this.buttonConsumeMappings.Size = new System.Drawing.Size(246, 46);
            this.buttonConsumeMappings.TabIndex = 14;
            this.buttonConsumeMappings.Text = "Consume Mappings";
            this.buttonConsumeMappings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsumeMappings.UseVisualStyleBackColor = true;
            this.buttonConsumeMappings.Click += new System.EventHandler(this.buttonConsumeMappings_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonCreateNcTask
            // 
            this.buttonCreateNcTask.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCreateNcTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCreateNcTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNcTask.Location = new System.Drawing.Point(20, 47);
            this.buttonCreateNcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateNcTask.Name = "buttonCreateNcTask";
            this.buttonCreateNcTask.Size = new System.Drawing.Size(178, 46);
            this.buttonCreateNcTask.TabIndex = 22;
            this.buttonCreateNcTask.Text = "Create NC Task";
            this.buttonCreateNcTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateNcTask.UseVisualStyleBackColor = false;
            this.buttonCreateNcTask.Click += new System.EventHandler(this.buttonCreateNcTask_Click);
            // 
            // buttonCreateAxis
            // 
            this.buttonCreateAxis.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCreateAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAxis.Location = new System.Drawing.Point(20, 103);
            this.buttonCreateAxis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateAxis.Name = "buttonCreateAxis";
            this.buttonCreateAxis.Size = new System.Drawing.Size(178, 46);
            this.buttonCreateAxis.TabIndex = 23;
            this.buttonCreateAxis.Text = "Create Axis";
            this.buttonCreateAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateAxis.UseVisualStyleBackColor = false;
            this.buttonCreateAxis.Click += new System.EventHandler(this.buttonCreateAxis_Click);
            // 
            // buttonDeleteNcTask
            // 
            this.buttonDeleteNcTask.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDeleteNcTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteNcTask.Location = new System.Drawing.Point(20, 159);
            this.buttonDeleteNcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteNcTask.Name = "buttonDeleteNcTask";
            this.buttonDeleteNcTask.Size = new System.Drawing.Size(178, 46);
            this.buttonDeleteNcTask.TabIndex = 25;
            this.buttonDeleteNcTask.Text = "Delete NC Task";
            this.buttonDeleteNcTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteNcTask.UseVisualStyleBackColor = false;
            this.buttonDeleteNcTask.Click += new System.EventHandler(this.buttonDeleteNcTask_Click);
            // 
            // butGrabProject
            // 
            this.butGrabProject.BackColor = System.Drawing.Color.LightCoral;
            this.butGrabProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGrabProject.Location = new System.Drawing.Point(20, 217);
            this.butGrabProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butGrabProject.Name = "butGrabProject";
            this.butGrabProject.Size = new System.Drawing.Size(178, 46);
            this.butGrabProject.TabIndex = 26;
            this.butGrabProject.Text = "Grab Project";
            this.butGrabProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butGrabProject.UseVisualStyleBackColor = false;
            this.butGrabProject.Click += new System.EventHandler(this.buttonGrabProject_Click);
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 60);
            this.label8.TabIndex = 28;
            this.label8.Text = "Solution File";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solutionFileSelect
            // 
            this.solutionFileSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solutionFileSelect.Location = new System.Drawing.Point(272, 58);
            this.solutionFileSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solutionFileSelect.MinimumSize = new System.Drawing.Size(4, 30);
            this.solutionFileSelect.Multiline = true;
            this.solutionFileSelect.Name = "solutionFileSelect";
            this.solutionFileSelect.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.solutionFileSelect.Size = new System.Drawing.Size(748, 60);
            this.solutionFileSelect.TabIndex = 27;
            this.solutionFileSelect.Click += new System.EventHandler(this.solutionFileSelect_Click);
            // 
            // openSolutionSelect
            // 
            this.openSolutionSelect.DefaultExt = "sln";
            // 
            // buttonAddTestCrateConfig
            // 
            this.buttonAddTestCrateConfig.Location = new System.Drawing.Point(1028, 128);
            this.buttonAddTestCrateConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTestCrateConfig.Name = "buttonAddTestCrateConfig";
            this.buttonAddTestCrateConfig.Size = new System.Drawing.Size(243, 60);
            this.buttonAddTestCrateConfig.TabIndex = 31;
            this.buttonAddTestCrateConfig.Text = "Add configuration to solution";
            this.buttonAddTestCrateConfig.UseVisualStyleBackColor = true;
            this.buttonAddTestCrateConfig.Click += new System.EventHandler(this.buttonAddHardware_Click);
            // 
            // configFolderSelect
            // 
            this.configFolderSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configFolderSelect.Location = new System.Drawing.Point(272, 128);
            this.configFolderSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configFolderSelect.MinimumSize = new System.Drawing.Size(4, 30);
            this.configFolderSelect.Multiline = true;
            this.configFolderSelect.Name = "configFolderSelect";
            this.configFolderSelect.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.configFolderSelect.Size = new System.Drawing.Size(748, 60);
            this.configFolderSelect.TabIndex = 32;
            this.configFolderSelect.Click += new System.EventHandler(this.configFolderSelect_Click);
            this.configFolderSelect.TextChanged += new System.EventHandler(this.configFolderSelect_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(10, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1756, 33);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 150;
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
            this.toolStripComboBox1.Text = "TWINCAT_SHELL";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(747, 750);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExportDevice1
            // 
            this.buttonExportDevice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportDevice1.Location = new System.Drawing.Point(14, 215);
            this.buttonExportDevice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExportDevice1.Name = "buttonExportDevice1";
            this.buttonExportDevice1.Size = new System.Drawing.Size(184, 46);
            this.buttonExportDevice1.TabIndex = 39;
            this.buttonExportDevice1.Text = "Export IO XTI File";
            this.buttonExportDevice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExportDevice1.UseVisualStyleBackColor = true;
            this.buttonExportDevice1.Click += new System.EventHandler(this.buttonExportDevice1_Click);
            // 
            // buttonImportDevice1
            // 
            this.buttonImportDevice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportDevice1.Location = new System.Drawing.Point(14, 159);
            this.buttonImportDevice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportDevice1.Name = "buttonImportDevice1";
            this.buttonImportDevice1.Size = new System.Drawing.Size(184, 46);
            this.buttonImportDevice1.TabIndex = 40;
            this.buttonImportDevice1.Text = "Import IO XTI File";
            this.buttonImportDevice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImportDevice1.UseVisualStyleBackColor = true;
            this.buttonImportDevice1.Click += new System.EventHandler(this.buttonImportDevice1_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 60);
            this.label1.TabIndex = 41;
            this.label1.Text = "Config. Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1025, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 125);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonClearMappings
            // 
            this.buttonClearMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearMappings.Location = new System.Drawing.Point(20, 159);
            this.buttonClearMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClearMappings.Name = "buttonClearMappings";
            this.buttonClearMappings.Size = new System.Drawing.Size(246, 46);
            this.buttonClearMappings.TabIndex = 43;
            this.buttonClearMappings.Text = "Clear Mappings";
            this.buttonClearMappings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearMappings.UseVisualStyleBackColor = true;
            this.buttonClearMappings.Click += new System.EventHandler(this.buttonClearMappings_Click);
            // 
            // buttonCopySolutionDir
            // 
            this.buttonCopySolutionDir.Location = new System.Drawing.Point(1028, 58);
            this.buttonCopySolutionDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCopySolutionDir.Name = "buttonCopySolutionDir";
            this.buttonCopySolutionDir.Size = new System.Drawing.Size(243, 60);
            this.buttonCopySolutionDir.TabIndex = 44;
            this.buttonCopySolutionDir.Text = "Copy Solution Directory Folder";
            this.buttonCopySolutionDir.UseVisualStyleBackColor = true;
            this.buttonCopySolutionDir.Click += new System.EventHandler(this.buttonCopySolutionDir_Click);
            // 
            // buttonImportDeviceList
            // 
            this.buttonImportDeviceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportDeviceList.Location = new System.Drawing.Point(14, 49);
            this.buttonImportDeviceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportDeviceList.Name = "buttonImportDeviceList";
            this.buttonImportDeviceList.Size = new System.Drawing.Size(184, 46);
            this.buttonImportDeviceList.TabIndex = 45;
            this.buttonImportDeviceList.Text = "Import IO List File";
            this.buttonImportDeviceList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImportDeviceList.UseVisualStyleBackColor = true;
            this.buttonImportDeviceList.Click += new System.EventHandler(this.buttonImportDeviceList_Click);
            // 
            // buttonImportIoXmls
            // 
            this.buttonImportIoXmls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportIoXmls.Location = new System.Drawing.Point(14, 103);
            this.buttonImportIoXmls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportIoXmls.Name = "buttonImportIoXmls";
            this.buttonImportIoXmls.Size = new System.Drawing.Size(184, 46);
            this.buttonImportIoXmls.TabIndex = 46;
            this.buttonImportIoXmls.Text = "Import IO XMLs";
            this.buttonImportIoXmls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImportIoXmls.UseVisualStyleBackColor = true;
            this.buttonImportIoXmls.Click += new System.EventHandler(this.buttonImportIoXmls_Click);
            // 
            // buttonImportNcXmls
            // 
            this.buttonImportNcXmls.BackColor = System.Drawing.Color.Turquoise;
            this.buttonImportNcXmls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportNcXmls.Location = new System.Drawing.Point(20, 271);
            this.buttonImportNcXmls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportNcXmls.Name = "buttonImportNcXmls";
            this.buttonImportNcXmls.Size = new System.Drawing.Size(178, 46);
            this.buttonImportNcXmls.TabIndex = 47;
            this.buttonImportNcXmls.Text = "Import NC XMLs";
            this.buttonImportNcXmls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImportNcXmls.UseVisualStyleBackColor = false;
            this.buttonImportNcXmls.Click += new System.EventHandler(this.buttonImportNcXmls_Click);
            // 
            // buttonDeleteAxes
            // 
            this.buttonDeleteAxes.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDeleteAxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAxes.Location = new System.Drawing.Point(20, 215);
            this.buttonDeleteAxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteAxes.Name = "buttonDeleteAxes";
            this.buttonDeleteAxes.Size = new System.Drawing.Size(178, 46);
            this.buttonDeleteAxes.TabIndex = 48;
            this.buttonDeleteAxes.Text = "Delete Axes";
            this.buttonDeleteAxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteAxes.UseVisualStyleBackColor = false;
            this.buttonDeleteAxes.Click += new System.EventHandler(this.buttonDeleteAxes_Click);
            // 
            // buttonDeleteIo
            // 
            this.buttonDeleteIo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteIo.Location = new System.Drawing.Point(14, 271);
            this.buttonDeleteIo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteIo.Name = "buttonDeleteIo";
            this.buttonDeleteIo.Size = new System.Drawing.Size(184, 46);
            this.buttonDeleteIo.TabIndex = 49;
            this.buttonDeleteIo.Text = "Delete IO";
            this.buttonDeleteIo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteIo.UseVisualStyleBackColor = true;
            this.buttonDeleteIo.Click += new System.EventHandler(this.buttonDeleteIo_Click);
            // 
            // buttonCleanUp
            // 
            this.buttonCleanUp.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCleanUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanUp.Location = new System.Drawing.Point(20, 161);
            this.buttonCleanUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCleanUp.Name = "buttonCleanUp";
            this.buttonCleanUp.Size = new System.Drawing.Size(178, 46);
            this.buttonCleanUp.TabIndex = 50;
            this.buttonCleanUp.Text = "Clean Up";
            this.buttonCleanUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanUp.UseVisualStyleBackColor = false;
            this.buttonCleanUp.Click += new System.EventHandler(this.buttonCleanUp_Click);
            // 
            // buttonTesting
            // 
            this.buttonTesting.Location = new System.Drawing.Point(237, 942);
            this.buttonTesting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTesting.Name = "buttonTesting";
            this.buttonTesting.Size = new System.Drawing.Size(115, 96);
            this.buttonTesting.TabIndex = 51;
            this.buttonTesting.Text = "Test Button\r\n(Might do anything)";
            this.buttonTesting.UseVisualStyleBackColor = true;
            this.buttonTesting.Click += new System.EventHandler(this.buttonTesting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCreateAxis);
            this.panel1.Controls.Add(this.buttonCreateNcTask);
            this.panel1.Controls.Add(this.buttonDeleteNcTask);
            this.panel1.Controls.Add(this.buttonDeleteAxes);
            this.panel1.Controls.Add(this.buttonImportNcXmls);
            this.panel1.Location = new System.Drawing.Point(19, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 329);
            this.panel1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 39);
            this.label2.TabIndex = 53;
            this.label2.Text = "NC TOOLS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonGetSln);
            this.panel2.Controls.Add(this.butCreateSolution);
            this.panel2.Controls.Add(this.buttonCleanUp);
            this.panel2.Controls.Add(this.butGrabProject);
            this.panel2.Location = new System.Drawing.Point(19, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 275);
            this.panel2.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 53;
            this.label3.Text = "Solution Tools";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1025, 387);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(726, 594);
            this.textBox2.TabIndex = 55;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.buttonProduceMappings);
            this.panel3.Controls.Add(this.buttonConsumeMappings);
            this.panel3.Controls.Add(this.buttonClearMappings);
            this.panel3.Location = new System.Drawing.Point(237, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 219);
            this.panel3.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 39);
            this.label4.TabIndex = 53;
            this.label4.Text = "MAPPING TOOLS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.butCreateConfigDir);
            this.panel4.Controls.Add(this.butAxisXmlExport);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(237, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 331);
            this.panel4.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 46);
            this.button1.TabIndex = 54;
            this.button1.Text = "Export IO List";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-8, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 39);
            this.label5.TabIndex = 53;
            this.label5.Text = "Configuration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butCreateConfigDir
            // 
            this.butCreateConfigDir.BackColor = System.Drawing.Color.LightCoral;
            this.butCreateConfigDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateConfigDir.Location = new System.Drawing.Point(20, 47);
            this.butCreateConfigDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateConfigDir.Name = "butCreateConfigDir";
            this.butCreateConfigDir.Size = new System.Drawing.Size(178, 46);
            this.butCreateConfigDir.TabIndex = 11;
            this.butCreateConfigDir.Text = "Setup folder";
            this.butCreateConfigDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCreateConfigDir.UseVisualStyleBackColor = false;
            this.butCreateConfigDir.Click += new System.EventHandler(this.butCreateConfigDir_Click);
            // 
            // butAxisXmlExport
            // 
            this.butAxisXmlExport.BackColor = System.Drawing.Color.LightCoral;
            this.butAxisXmlExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAxisXmlExport.Location = new System.Drawing.Point(20, 105);
            this.butAxisXmlExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAxisXmlExport.Name = "butAxisXmlExport";
            this.butAxisXmlExport.Size = new System.Drawing.Size(178, 46);
            this.butAxisXmlExport.TabIndex = 0;
            this.butAxisXmlExport.Text = "Export Axis Xmls";
            this.butAxisXmlExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAxisXmlExport.UseVisualStyleBackColor = false;
            this.butAxisXmlExport.Click += new System.EventHandler(this.butAxisXmlExport_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 46);
            this.button3.TabIndex = 50;
            this.button3.Text = "Export IO Xmls";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 273);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 46);
            this.button4.TabIndex = 26;
            this.button4.Text = "PLC Declarations";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.buttonImportDeviceList);
            this.panel5.Controls.Add(this.buttonImportIoXmls);
            this.panel5.Controls.Add(this.buttonImportDevice1);
            this.panel5.Controls.Add(this.buttonExportDevice1);
            this.panel5.Controls.Add(this.buttonDeleteIo);
            this.panel5.Location = new System.Drawing.Point(523, 670);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 329);
            this.panel5.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 39);
            this.label6.TabIndex = 53;
            this.label6.Text = "IO TOOLS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1302, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 130);
            this.button2.TabIndex = 56;
            this.button2.Text = "Create Configuration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 942);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 96);
            this.button5.TabIndex = 57;
            this.button5.Text = "Test Button\r\n(Might do anything)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1776, 1062);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonTesting);
            this.Controls.Add(this.buttonCopySolutionDir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.configFolderSelect);
            this.Controls.Add(this.buttonAddTestCrateConfig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.solutionFileSelect);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 9);
            this.Text = "TwinCAT Automation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCreateSolution;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBaseDir;
        private System.Windows.Forms.Button buttonProduceMappings;
        private System.Windows.Forms.Button buttonGetSln;
        private System.Windows.Forms.Button buttonConsumeMappings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog xmlDirBrowser;
        private System.Windows.Forms.Button buttonCreateNcTask;
        private System.Windows.Forms.Button buttonCreateAxis;
        private System.Windows.Forms.Button buttonDeleteNcTask;
        private System.Windows.Forms.Button butGrabProject;
        private System.Windows.Forms.TextBox solutionFileSelect;
        private System.Windows.Forms.OpenFileDialog openSolutionSelect;
        private System.Windows.Forms.Button buttonAddTestCrateConfig;
        private System.Windows.Forms.TextBox configFolderSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExportDevice1;
        private System.Windows.Forms.Button buttonImportDevice1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClearMappings;
        private System.Windows.Forms.Button buttonCopySolutionDir;
        private System.Windows.Forms.Button buttonImportDeviceList;
        private System.Windows.Forms.Button buttonImportIoXmls;
        private System.Windows.Forms.Button buttonImportNcXmls;
        private System.Windows.Forms.Button buttonDeleteAxes;
        private System.Windows.Forms.Button buttonDeleteIo;
        private System.Windows.Forms.Button buttonCleanUp;
        private System.Windows.Forms.Button buttonTesting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCreateConfigDir;
        private System.Windows.Forms.Button butAxisXmlExport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

