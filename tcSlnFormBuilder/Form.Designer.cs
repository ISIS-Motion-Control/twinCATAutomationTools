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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butCreateSolution
            // 
            this.butCreateSolution.Location = new System.Drawing.Point(31, 976);
            this.butCreateSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateSolution.Name = "butCreateSolution";
            this.butCreateSolution.Size = new System.Drawing.Size(179, 46);
            this.butCreateSolution.TabIndex = 0;
            this.butCreateSolution.Text = "Create Solution";
            this.butCreateSolution.UseVisualStyleBackColor = true;
            this.butCreateSolution.Click += new System.EventHandler(this.buttonCreateSolution_Click);
            // 
            // buttonProduceMappings
            // 
            this.buttonProduceMappings.Location = new System.Drawing.Point(567, 864);
            this.buttonProduceMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProduceMappings.Name = "buttonProduceMappings";
            this.buttonProduceMappings.Size = new System.Drawing.Size(204, 46);
            this.buttonProduceMappings.TabIndex = 10;
            this.buttonProduceMappings.Text = "Produce Mappings File";
            this.buttonProduceMappings.UseVisualStyleBackColor = true;
            this.buttonProduceMappings.Click += new System.EventHandler(this.buttonProduceMappings_Click);
            // 
            // buttonGetSln
            // 
            this.buttonGetSln.Location = new System.Drawing.Point(31, 920);
            this.buttonGetSln.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetSln.Name = "buttonGetSln";
            this.buttonGetSln.Size = new System.Drawing.Size(179, 46);
            this.buttonGetSln.TabIndex = 11;
            this.buttonGetSln.Text = "Open Solution";
            this.buttonGetSln.UseVisualStyleBackColor = true;
            this.buttonGetSln.Click += new System.EventHandler(this.buttonOpenSolution_Click);
            // 
            // buttonConsumeMappings
            // 
            this.buttonConsumeMappings.Location = new System.Drawing.Point(567, 920);
            this.buttonConsumeMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConsumeMappings.Name = "buttonConsumeMappings";
            this.buttonConsumeMappings.Size = new System.Drawing.Size(204, 46);
            this.buttonConsumeMappings.TabIndex = 14;
            this.buttonConsumeMappings.Text = "Consume Mappings File";
            this.buttonConsumeMappings.UseVisualStyleBackColor = true;
            this.buttonConsumeMappings.Click += new System.EventHandler(this.buttonConsumeMappings_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonCreateNcTask
            // 
            this.buttonCreateNcTask.Location = new System.Drawing.Point(779, 864);
            this.buttonCreateNcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateNcTask.Name = "buttonCreateNcTask";
            this.buttonCreateNcTask.Size = new System.Drawing.Size(179, 46);
            this.buttonCreateNcTask.TabIndex = 22;
            this.buttonCreateNcTask.Text = "Create NC Task";
            this.buttonCreateNcTask.UseVisualStyleBackColor = true;
            this.buttonCreateNcTask.Click += new System.EventHandler(this.buttonCreateNcTask_Click);
            // 
            // buttonCreateAxis
            // 
            this.buttonCreateAxis.Location = new System.Drawing.Point(779, 920);
            this.buttonCreateAxis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateAxis.Name = "buttonCreateAxis";
            this.buttonCreateAxis.Size = new System.Drawing.Size(179, 46);
            this.buttonCreateAxis.TabIndex = 23;
            this.buttonCreateAxis.Text = "Create Axis";
            this.buttonCreateAxis.UseVisualStyleBackColor = true;
            this.buttonCreateAxis.Click += new System.EventHandler(this.buttonCreateAxis_Click);
            // 
            // buttonDeleteNcTask
            // 
            this.buttonDeleteNcTask.Location = new System.Drawing.Point(779, 976);
            this.buttonDeleteNcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteNcTask.Name = "buttonDeleteNcTask";
            this.buttonDeleteNcTask.Size = new System.Drawing.Size(179, 46);
            this.buttonDeleteNcTask.TabIndex = 25;
            this.buttonDeleteNcTask.Text = "Delete NC Task";
            this.buttonDeleteNcTask.UseVisualStyleBackColor = true;
            this.buttonDeleteNcTask.Click += new System.EventHandler(this.buttonDeleteNcTask_Click);
            // 
            // butGrabProject
            // 
            this.butGrabProject.Location = new System.Drawing.Point(218, 976);
            this.butGrabProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butGrabProject.Name = "butGrabProject";
            this.butGrabProject.Size = new System.Drawing.Size(179, 46);
            this.butGrabProject.TabIndex = 26;
            this.butGrabProject.Text = "Grab Project";
            this.butGrabProject.UseVisualStyleBackColor = true;
            this.butGrabProject.Click += new System.EventHandler(this.buttonGrabProject_Click);
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Solution File";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solutionFileSelect
            // 
            this.solutionFileSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solutionFileSelect.Location = new System.Drawing.Point(272, 59);
            this.solutionFileSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solutionFileSelect.MinimumSize = new System.Drawing.Size(4, 30);
            this.solutionFileSelect.Name = "solutionFileSelect";
            this.solutionFileSelect.Size = new System.Drawing.Size(600, 26);
            this.solutionFileSelect.TabIndex = 27;
            this.solutionFileSelect.Click += new System.EventHandler(this.solutionFileSelect_Click);
            // 
            // openSolutionSelect
            // 
            this.openSolutionSelect.DefaultExt = "sln";
            // 
            // buttonAddTestCrateConfig
            // 
            this.buttonAddTestCrateConfig.Location = new System.Drawing.Point(1056, 864);
            this.buttonAddTestCrateConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTestCrateConfig.Name = "buttonAddTestCrateConfig";
            this.buttonAddTestCrateConfig.Size = new System.Drawing.Size(499, 46);
            this.buttonAddTestCrateConfig.TabIndex = 31;
            this.buttonAddTestCrateConfig.Text = "Add Test Crate Hardware";
            this.buttonAddTestCrateConfig.UseVisualStyleBackColor = true;
            this.buttonAddTestCrateConfig.Click += new System.EventHandler(this.buttonAddHardware_Click);
            // 
            // configFolderSelect
            // 
            this.configFolderSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configFolderSelect.Location = new System.Drawing.Point(272, 103);
            this.configFolderSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configFolderSelect.MinimumSize = new System.Drawing.Size(4, 30);
            this.configFolderSelect.Name = "configFolderSelect";
            this.configFolderSelect.Size = new System.Drawing.Size(600, 26);
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
            this.toolStrip1.Size = new System.Drawing.Size(1894, 33);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1605, 772);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExportDevice1
            // 
            this.buttonExportDevice1.Location = new System.Drawing.Point(1056, 920);
            this.buttonExportDevice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExportDevice1.Name = "buttonExportDevice1";
            this.buttonExportDevice1.Size = new System.Drawing.Size(499, 46);
            this.buttonExportDevice1.TabIndex = 39;
            this.buttonExportDevice1.Text = "Export Device1";
            this.buttonExportDevice1.UseVisualStyleBackColor = true;
            this.buttonExportDevice1.Click += new System.EventHandler(this.buttonExportDevice1_Click);
            // 
            // buttonImportDevice1
            // 
            this.buttonImportDevice1.Location = new System.Drawing.Point(1056, 976);
            this.buttonImportDevice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportDevice1.Name = "buttonImportDevice1";
            this.buttonImportDevice1.Size = new System.Drawing.Size(499, 46);
            this.buttonImportDevice1.TabIndex = 40;
            this.buttonImportDevice1.Text = "Import Device1";
            this.buttonImportDevice1.UseVisualStyleBackColor = true;
            this.buttonImportDevice1.Click += new System.EventHandler(this.buttonImportDevice1_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "Config. Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1486, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 346);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "Guide:\r\n1. Press the solution file box to locate a solution to use\r\n2. If plannin" +
    "g to import solution configurations, select the config folder location\r\n";
            // 
            // buttonClearMappings
            // 
            this.buttonClearMappings.Location = new System.Drawing.Point(567, 976);
            this.buttonClearMappings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClearMappings.Name = "buttonClearMappings";
            this.buttonClearMappings.Size = new System.Drawing.Size(204, 46);
            this.buttonClearMappings.TabIndex = 43;
            this.buttonClearMappings.Text = "Clear Mappings";
            this.buttonClearMappings.UseVisualStyleBackColor = true;
            this.buttonClearMappings.Click += new System.EventHandler(this.buttonClearMappings_Click);
            // 
            // buttonCopySolutionDir
            // 
            this.buttonCopySolutionDir.Location = new System.Drawing.Point(880, 103);
            this.buttonCopySolutionDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCopySolutionDir.Name = "buttonCopySolutionDir";
            this.buttonCopySolutionDir.Size = new System.Drawing.Size(179, 26);
            this.buttonCopySolutionDir.TabIndex = 44;
            this.buttonCopySolutionDir.Text = "Copy Solution Dir";
            this.buttonCopySolutionDir.UseVisualStyleBackColor = true;
            this.buttonCopySolutionDir.Click += new System.EventHandler(this.buttonCopySolutionDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1914, 1062);
            this.Controls.Add(this.buttonCopySolutionDir);
            this.Controls.Add(this.buttonClearMappings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportDevice1);
            this.Controls.Add(this.buttonExportDevice1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.configFolderSelect);
            this.Controls.Add(this.buttonAddTestCrateConfig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.solutionFileSelect);
            this.Controls.Add(this.butGrabProject);
            this.Controls.Add(this.buttonDeleteNcTask);
            this.Controls.Add(this.buttonCreateAxis);
            this.Controls.Add(this.buttonCreateNcTask);
            this.Controls.Add(this.buttonConsumeMappings);
            this.Controls.Add(this.buttonGetSln);
            this.Controls.Add(this.buttonProduceMappings);
            this.Controls.Add(this.butCreateSolution);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "TwinCAT Automation";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

