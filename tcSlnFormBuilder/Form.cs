using System;
using System.IO;
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
            solutionFileSelect.Text = mySln.SlnPath;
        }



        //Solution file selection box
        private void solutionFileSelect_Click(object sender, EventArgs e)
        {
            openSolutionSelect.ShowDialog();
            solutionFileSelect.Text = openSolutionSelect.FileName;
            mySln.SlnPath = openSolutionSelect.FileName;
        }

        //Config folder selection box
        private void configFolderSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            configFolderSelect.Text = folderBrowserDialog2.SelectedPath;
            mySln.xmlFolderPath = folderBrowserDialog2.SelectedPath;
            mySln.ConfigFolder = configFolderSelect.Text;
        }

        //Open selected solution file
        private void buttonOpenSolution_Click(object sender, EventArgs e)
        {
            mySln.openSolution();
        }

        //Create new solution
        private void buttonCreateSolution_Click(object sender, EventArgs e)
        {
            mySln.createTcProj(mySln.SlnPath, mySln.SlnName);
        }

        //Load in Project object from first available project
        private void buttonGrabProject_Click(object sender, EventArgs e)
        {
            mySln.grabSolutionProject();
        }

        //Produce project mappings
        private void buttonProduceMappings_Click(object sender, EventArgs e)
        {
            mySln.exportXmlMap();
        }

        //Consuming mappings file - <BROKEN>
        private void buttonConsumeMappings_Click(object sender, EventArgs e)
        {
            mySln.clearMap();
            mySln.importXmlMap();
        }

        //Clear project mappings - <NOT IMPLEMENTED>
        private void buttonClearMappings_Click(object sender, EventArgs e)
        {
            mySln.clearMap();
        }

        //Create NC Task
        private void buttonCreateNcTask_Click(object sender, EventArgs e)
        {
            mySln.createNcTask();
        }

        //Create NC Axis
        private void buttonCreateAxis_Click(object sender, EventArgs e)
        {
            mySln.addNcAxis();
        }

        //Delete NC Task
        private void buttonDeleteNcTask_Click(object sender, EventArgs e)
        {
            mySln.removeNcTask();
        }

        //Add Test Crate Hardware to selected solution
        private void buttonAddHardware_Click(object sender, EventArgs e)
        {
            mySln.setupTestCrate();
        }

        //Export Device 1 hardware tree to XTI
        private void buttonExportDevice1_Click(object sender, EventArgs e)
        {
            mySln.exportHardwareXTI(1);
        }

        //Import Device 1 hardware tree to solution
        private void buttonImportDevice1_Click(object sender, EventArgs e)
        {
            //mySln.importHardwareXTI();
            mySln.importIoXti();
        }

        //Use config folder in solution directory
        private void buttonCopySolutionDir_Click(object sender, EventArgs e)
        {
            if (solutionFileSelect.Text == "")
            { return; }
            if (mySln.SlnFolder == "")
            {             
                configFolderSelect.Text = Path.GetDirectoryName(solutionFileSelect.Text) + @"\Config";
            }
            else
            {
                configFolderSelect.Text = mySln.SlnFolder + @"\Config";
            }         
            mySln.ConfigFolder = configFolderSelect.Text;
        }

        //Text change on configuration folder
        private void configFolderSelect_TextChanged(object sender, EventArgs e)
        {
            mySln.ConfigFolder = configFolderSelect.Text;
        }

        private void buttonImportDeviceList_Click(object sender, EventArgs e)
        {
            mySln.importIoList();
        }

        private void buttonImportIoXmls_Click(object sender, EventArgs e)
        {
            //mySln.importIoXmls(@"C:\Users\SCooper - work\Documents\Git Repos\autoDeployTools\Config Folder\deviceXmls\Device 1 (EtherCAT).xml");
            mySln.importAllIoXmls();
        }

        private void buttonImportNcXmls_Click(object sender, EventArgs e)
        {
            mySln.ncConsumeAllMaps();
        }

        private void buttonDeleteAxes_Click(object sender, EventArgs e)
        {
            mySln.deleteAxes();
        }

        private void buttonDeleteIo_Click(object sender, EventArgs e)
        {
            mySln.deleteIo();
        }

        private void buttonCleanUp_Click(object sender, EventArgs e)
        {
            mySln.cleanUp();
        }

        private void buttonTesting_Click(object sender, EventArgs e)
        {
            mySln.exportApplications();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySln.versionString = toolStripComboBox1.Text;
            MessageBox.Show(mySln.versionString);
        }

        private void butCreateConfigDir_Click(object sender, EventArgs e)
        {
            mySln.setupConfigFolder();
        }

        private void butAxisXmlExport_Click(object sender, EventArgs e)
        {
            mySln.exportAllAxisXmls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mySln.exportAllIoXmls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySln.exportIoList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mySln.exportPlcDec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySln.createConfiguration();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mySln.setupProgAction();
        }
    }
}
