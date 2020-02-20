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
            this.SuspendLayout();
            // 
            // butCreateSolution
            // 
            this.butCreateSolution.Location = new System.Drawing.Point(539, 11);
            this.butCreateSolution.Margin = new System.Windows.Forms.Padding(4);
            this.butCreateSolution.Name = "butCreateSolution";
            this.butCreateSolution.Size = new System.Drawing.Size(159, 37);
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
            this.labelDirSelected.Location = new System.Drawing.Point(188, 11);
            this.labelDirSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirSelected.Name = "labelDirSelected";
            this.labelDirSelected.Size = new System.Drawing.Size(325, 22);
            this.labelDirSelected.TabIndex = 2;
            this.labelDirSelected.Text = "labelDirSelected";
            this.labelDirSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDirSelected.Click += new System.EventHandler(this.labelDirSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSlnName
            // 
            this.textSlnName.Location = new System.Drawing.Point(192, 49);
            this.textSlnName.Margin = new System.Windows.Forms.Padding(4);
            this.textSlnName.Name = "textSlnName";
            this.textSlnName.Size = new System.Drawing.Size(320, 22);
            this.textSlnName.TabIndex = 4;
            this.textSlnName.TextChanged += new System.EventHandler(this.textSlnName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Solution:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Base Project Dir:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBaseDir
            // 
            this.labelBaseDir.BackColor = System.Drawing.SystemColors.Window;
            this.labelBaseDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBaseDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelBaseDir.Location = new System.Drawing.Point(157, 231);
            this.labelBaseDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaseDir.Name = "labelBaseDir";
            this.labelBaseDir.Size = new System.Drawing.Size(325, 22);
            this.labelBaseDir.TabIndex = 6;
            this.labelBaseDir.Text = "labelBaseDir";
            this.labelBaseDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBaseDir.Click += new System.EventHandler(this.labelBaseDir_Click);
            // 
            // buttonAddBasePrj
            // 
            this.buttonAddBasePrj.Location = new System.Drawing.Point(324, 267);
            this.buttonAddBasePrj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBasePrj.Name = "buttonAddBasePrj";
            this.buttonAddBasePrj.Size = new System.Drawing.Size(159, 37);
            this.buttonAddBasePrj.TabIndex = 8;
            this.buttonAddBasePrj.Text = "Add Base Project";
            this.buttonAddBasePrj.UseVisualStyleBackColor = true;
            this.buttonAddBasePrj.Click += new System.EventHandler(this.buttonAddBasePrj_Click);
            // 
            // buttonCloneRepo
            // 
            this.buttonCloneRepo.Location = new System.Drawing.Point(157, 267);
            this.buttonCloneRepo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloneRepo.Name = "buttonCloneRepo";
            this.buttonCloneRepo.Size = new System.Drawing.Size(159, 37);
            this.buttonCloneRepo.TabIndex = 9;
            this.buttonCloneRepo.Text = "Clone Repo";
            this.buttonCloneRepo.UseVisualStyleBackColor = true;
            this.buttonCloneRepo.Click += new System.EventHandler(this.buttonCloneRepo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "ProduceMap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetSln
            // 
            this.buttonGetSln.Location = new System.Drawing.Point(539, 56);
            this.buttonGetSln.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetSln.Name = "buttonGetSln";
            this.buttonGetSln.Size = new System.Drawing.Size(159, 37);
            this.buttonGetSln.TabIndex = 11;
            this.buttonGetSln.Text = "GetSln";
            this.buttonGetSln.UseVisualStyleBackColor = true;
            this.buttonGetSln.Click += new System.EventHandler(this.buttonGetSln_Click);
            // 
            // getPrj
            // 
            this.getPrj.Location = new System.Drawing.Point(539, 101);
            this.getPrj.Margin = new System.Windows.Forms.Padding(4);
            this.getPrj.Name = "getPrj";
            this.getPrj.Size = new System.Drawing.Size(159, 37);
            this.getPrj.TabIndex = 12;
            this.getPrj.Text = "Find PLC Project";
            this.getPrj.UseVisualStyleBackColor = true;
            this.getPrj.Click += new System.EventHandler(this.getPrj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butConsumeMap
            // 
            this.butConsumeMap.Location = new System.Drawing.Point(490, 493);
            this.butConsumeMap.Margin = new System.Windows.Forms.Padding(4);
            this.butConsumeMap.Name = "butConsumeMap";
            this.butConsumeMap.Size = new System.Drawing.Size(159, 37);
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
            this.xmlFileSelect.Location = new System.Drawing.Point(157, 500);
            this.xmlFileSelect.Margin = new System.Windows.Forms.Padding(4);
            this.xmlFileSelect.Name = "xmlFileSelect";
            this.xmlFileSelect.Size = new System.Drawing.Size(325, 22);
            this.xmlFileSelect.TabIndex = 15;
            this.xmlFileSelect.Click += new System.EventHandler(this.xmlFileSelect_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xml Map:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "XML Save Directory:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlSaveDirectory
            // 
            this.xmlSaveDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.xmlSaveDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xmlSaveDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xmlSaveDirectory.Location = new System.Drawing.Point(157, 452);
            this.xmlSaveDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xmlSaveDirectory.Name = "xmlSaveDirectory";
            this.xmlSaveDirectory.Size = new System.Drawing.Size(325, 22);
            this.xmlSaveDirectory.TabIndex = 18;
            this.xmlSaveDirectory.Text = "label6";
            this.xmlSaveDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xmlSaveDirectory.Click += new System.EventHandler(this.xmlSaveDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 477);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "XML File Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xmlName
            // 
            this.xmlName.Location = new System.Drawing.Point(157, 477);
            this.xmlName.Margin = new System.Windows.Forms.Padding(4);
            this.xmlName.Name = "xmlName";
            this.xmlName.Size = new System.Drawing.Size(325, 22);
            this.xmlName.TabIndex = 21;
            this.xmlName.TextChanged += new System.EventHandler(this.xmlName_TextChanged);
            // 
            // butNcCreate
            // 
            this.butNcCreate.Location = new System.Drawing.Point(685, 403);
            this.butNcCreate.Margin = new System.Windows.Forms.Padding(4);
            this.butNcCreate.Name = "butNcCreate";
            this.butNcCreate.Size = new System.Drawing.Size(159, 37);
            this.butNcCreate.TabIndex = 22;
            this.butNcCreate.Text = "CreateNC";
            this.butNcCreate.UseVisualStyleBackColor = true;
            this.butNcCreate.Click += new System.EventHandler(this.butNcCreate_Click);
            // 
            // butCreateAxis
            // 
            this.butCreateAxis.Location = new System.Drawing.Point(685, 448);
            this.butCreateAxis.Margin = new System.Windows.Forms.Padding(4);
            this.butCreateAxis.Name = "butCreateAxis";
            this.butCreateAxis.Size = new System.Drawing.Size(159, 37);
            this.butCreateAxis.TabIndex = 23;
            this.butCreateAxis.Text = "CreateAxis";
            this.butCreateAxis.UseVisualStyleBackColor = true;
            this.butCreateAxis.Click += new System.EventHandler(this.butCreateAxis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "PLC Project to Search";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butDeleteNC
            // 
            this.butDeleteNC.Location = new System.Drawing.Point(685, 493);
            this.butDeleteNC.Margin = new System.Windows.Forms.Padding(4);
            this.butDeleteNC.Name = "butDeleteNC";
            this.butDeleteNC.Size = new System.Drawing.Size(159, 37);
            this.butDeleteNC.TabIndex = 25;
            this.butDeleteNC.Text = "DeleteNC";
            this.butDeleteNC.UseVisualStyleBackColor = true;
            this.butDeleteNC.Click += new System.EventHandler(this.butDeleteNC_Click);
            // 
            // butGrabProject
            // 
            this.butGrabProject.Location = new System.Drawing.Point(539, 146);
            this.butGrabProject.Margin = new System.Windows.Forms.Padding(4);
            this.butGrabProject.Name = "butGrabProject";
            this.butGrabProject.Size = new System.Drawing.Size(159, 37);
            this.butGrabProject.TabIndex = 26;
            this.butGrabProject.Text = "Grab Project";
            this.butGrabProject.UseVisualStyleBackColor = true;
            this.butGrabProject.Click += new System.EventHandler(this.butGrabProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

