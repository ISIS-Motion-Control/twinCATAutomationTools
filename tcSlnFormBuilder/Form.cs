using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcSlnFormBuilder
{
    public partial class Form1 : Form
    {
        private tcSln mySln;

        public Form1(tcSln mySln)
        {
            InitializeComponent();
            this.mySln = mySln;
            labelDirSelected.Text = mySln.SlnPath;
            textSlnName.Text = mySln.SlnName;
            labelBaseDir.Text = mySln.SlnBasePath;
            xmlSaveDirectory.Text = mySln.xmlTools.xmlPath;
            xmlName.Text = mySln.xmlTools.xmlName;
            solutionFileSelect.Text = mySln.completeSolutionPath;
            xmlFileSelectHW.Text = mySln.xmlHwMapPath;
        }

        private void butCreateSolution_Click(object sender, EventArgs e)
        {
            mySln.createTcProj(mySln.SlnPath, mySln.SlnName);
        }

        private void labelDirSelected_Click(object sender, EventArgs e)
        {
            folderBrowseDir.SelectedPath = labelDirSelected.Text;
            folderBrowseDir.ShowDialog();
            labelDirSelected.Text = folderBrowseDir.SelectedPath;
            mySln.SlnPath = labelDirSelected.Text;
        }

        private void textSlnName_TextChanged(object sender, EventArgs e)
        {
            mySln.SlnName = textSlnName.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelBaseDir_Click(object sender, EventArgs e)
        {
            folderBrowserBaseDir.SelectedPath = labelBaseDir.Text;
            folderBrowserBaseDir.ShowDialog();
            labelBaseDir.Text = folderBrowserBaseDir.SelectedPath;
            mySln.SlnBasePath = labelBaseDir.Text;
        }

        private void buttonAddBasePrj_Click(object sender, EventArgs e)
        {
            mySln.addBaseSln(labelBaseDir.Text);
        }

        private void buttonCloneRepo_Click(object sender, EventArgs e)
        {
            mySln.gitBash();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySln.xmlTools.produceXmlMap(mySln.Project.Object);
        }

        private void buttonGetSln_Click(object sender, EventArgs e)
        {
            mySln.openSolution();
        }

        private void getPrj_Click(object sender, EventArgs e)
        {
            mySln.findPLCProject();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mySln.PlcName = textBox1.Text;
        }

        private void butConsumeMap_Click(object sender, EventArgs e)
        {
            mySln.xmlTools.clearXmlMap(mySln.Project.Object);
            mySln.xmlTools.consumeXmlMap(mySln.Project.Object, xmlFileSelect.Text);
        }

        private void xmlFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            xmlFileSelect.Text = openFileDialog1.FileName;
        }

        private void xmlSaveDirectory_Click(object sender, EventArgs e)
        {
            xmlDirBrowser.SelectedPath = xmlSaveDirectory.Text;
            xmlDirBrowser.ShowDialog();
            xmlSaveDirectory.Text = xmlDirBrowser.SelectedPath;
            mySln.xmlTools.xmlPath = xmlSaveDirectory.Text;
        }

        private void xmlName_TextChanged(object sender, EventArgs e)
        {
            mySln.xmlTools.xmlName = xmlName.Text;
        }

        private void butNcCreate_Click(object sender, EventArgs e)
        {
            //mySln.createNC();
            mySln.ncTools.createNcTask(mySln.Project.Object);
        }

        private void butCreateAxis_Click(object sender, EventArgs e)
        {
            mySln.ncTools.addNcAxis(mySln.Project.Object);
        }

        private void butDeleteNC_Click(object sender, EventArgs e)
        {
            mySln.ncTools.removeNcTask(mySln.Project.Object);
        }

        private void butGrabProject_Click(object sender, EventArgs e)
        {
            mySln.grabFirstProject();
        }

        private void solutonFileSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void solutionFileSelect_Click(object sender, EventArgs e)
        {
            openSolutionSelect.ShowDialog();
            solutionFileSelect.Text = openSolutionSelect.FileName;
            mySln.completeSolutionPath = openSolutionSelect.FileName;
        }

        private void xmlFileSelectHW_MouseClick(object sender, MouseEventArgs e)
        {
            openSolutionSelect.ShowDialog();
            xmlFileSelectHW.Text = openSolutionSelect.FileName;
            
        }

        private void butAddHardware_Click(object sender, EventArgs e)
        {
            mySln.setupTestCrate();
        }

        private void xmlFolderSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            xmlFolderSelect.Text = folderBrowserDialog2.SelectedPath;
            mySln.xmlFolderPath = folderBrowserDialog2.SelectedPath;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySln.exportHW();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void butOpenDTE_MouseClick(object sender, MouseEventArgs e)
        {
                mySln.setupDTE(toolStripComboBox1.Text, true, false, true);

           
        }
    }
}
