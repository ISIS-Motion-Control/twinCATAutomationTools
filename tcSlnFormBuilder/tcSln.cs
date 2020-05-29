using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using TCatSysManagerLib;
using System.Diagnostics;
using EnvDTE;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace tcSlnFormBuilder
{
    public partial class tcSln
    {

        //FIELDS
        private String _slnPath;    //Dir for new solution
        private String _slnName;    //Name for new solution
        private String slnBasePath;
        private String plcName;
        private Project _project;
        private Solution solution;
        private ITcSysManager13 _systemManager;
        public XmlDocument xmlDoc;  //Generic holder for xmlDocument
        public String xmlPath;
        public XmlTools xmlTools= new XmlTools();
        
        public String solutionPath = " ";
        public String solutionFolder = " ";
        public String _configFolder = " "; //Used for all XTIs and XML. Should create folder if doesn't exist

        public String xmlHwMapPath = " ";
        public String xmlFolderPath = " ";
        public ITcSmTreeItem axis;
        public VSVersion version = VSVersion.TWINCAT_SHELL;

        public tcSln()
        {

        }
        //FIELD METHODS
        public String SlnPath
        {
            get { return _slnPath; }
            set { _slnPath = value; }
        }
        public String SlnName
        {
            get { return _slnName; }
            set { _slnName = value; }
        }
        public String SlnBasePath
        {
            get { return slnBasePath; }
            set { slnBasePath = value; }
        }
        public String PlcName
        {
            get { return plcName; }
            set { plcName = value; }
        }
        public Project Project
        {
            get { return _project ?? (_project = grabSolutionProject()); }
            set { _project = value; }
        }
        public ITcSysManager13 SystemManager
        {
            get { return _systemManager ?? (_systemManager = Project.Object); }
            set { _systemManager = value; }
        }
        public String ConfigFolder
        {
            get { return _configFolder ?? (_configFolder = solutionFolder + @"\Config"); }
            set 
            { 
                _configFolder = value;
                Directory.CreateDirectory(_configFolder);
            }
        }

        //METHODS
        /// <summary>
        /// Quick setup method for opening TWINCAT_XAE
        /// Contains default parameters for visibility
        /// </summary>
        /// <returns>Visual Studio Solution Object</returns>
        public Solution quickSetupDTE()
        {
            return setupDTE("TWINCAT_SHELL", true, false, true);
        }

        /// <summary>
        /// Create visual studio instance
        /// </summary>
        /// <param name="appID">Visual studio version</param>
        /// <param name="ideVisible">Visibility</param>
        /// <param name="suppressUI">No idea</param>
        /// <param name="userControl">Allow user control</param>
        /// <returns>Visual Studio Solution Object</returns>
        public Solution setupDTE(string appID, bool ideVisible, bool suppressUI, bool userControl)
        {
            if (!MessageFilter.IsRegistered)
                MessageFilter.Register();
            environmentDTE vsDTE = new environmentDTE();          
            vsDTE.dte = vsDTE.CreateDTE(appID, ideVisible, suppressUI, userControl); 
            return vsDTE.dte.Solution;
        }

        /// <summary>
        /// Creates a TwinCAT solution using the default TwinCAT project template
        /// </summary>
        /// <param name="slnPath"></param>
        /// <param name="slnName"></param>
        public void createTcProj(string slnPath, string slnName) //Create TwinCAT solution and add the TwinCAT "PROJECT" structure
        {
            DialogResult dialogResult = MessageBox.Show($"This will erase all folder contents of {slnPath}. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.No)
            {
                return;
            }
            if (System.IO.Directory.Exists(slnPath))
            {
                try
                {
                    System.IO.Directory.Delete(slnPath, recursive: true);
                }
                catch
                {
                    try
                    {
                        System.Threading.Thread.Sleep(2000);
                        System.IO.Directory.Delete(slnPath, recursive: true);
                    }
                    catch
                    {
                        throw new ApplicationException("Issue accessing directory");
                    }
                }
            }
            solution = quickSetupDTE();
            System.IO.Directory.CreateDirectory(slnPath);
            solution.Create(slnPath, slnName);
            try
            {
                saveAs(slnPath, slnName);
            }
            catch
            {
                throw new ApplicationException("Solution can't save, check user rights");
            }

            //Add the TwinCAT Project template. Method will attempt to do this automatically and prompt user if file cannot be found
            string template = @"C:\TwinCAT\3.1\Components\Base\PrjTemplate\TwinCAT Project.tsproj"; //Default
            try
            {
                Project = solution.AddFromTemplate(template, slnPath + @"\" + slnName, slnName, false);
            }
            catch
            {
                dialogResult = MessageBox.Show("Unable to add TwinCAT Solution template. Do you want to try to select the template project manually?", "Warning",MessageBoxButtons.YesNo); //Change the template so it detects version installed and knows where to look
                if (dialogResult == DialogResult.Yes)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = @"C:\\";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            template = openFileDialog.FileName;
                        }
                        try
                        {
                            Project = solution.AddFromTemplate(template, slnPath + @"\" + slnName, slnName, false);
                        }
                        catch
                        {
                            throw new ApplicationException($"No compatible TwinCAT Project Template found");
                        }
                    }
                }
            }
            Project.Save();
            saveAs(slnPath, slnName);
        }

        /// <summary>
        /// Opens a given TwinCAT solution file
        /// </summary>
        /// <param name="solutionFilePath"></param>
        /// <returns></returns>
        public Solution openSolution()    //Open existing TwinCAT solution
        {
            try
            {
                solution = quickSetupDTE();
                solution.Open(solutionPath);
                solutionFolder = new FileInfo(solutionPath).Directory.FullName;
                return solution;
                
            }
            catch
            {
                throw new ApplicationException($"Unable to open '{solutionPath}'");
            }
        }

        public void createPLC() //NOT IMPLEMENTED
        {
            throw new NotImplementedException();
        }
        
        
        public void findPLCProject()    //Search projects in solution for named PLC. THen assigns PROJECT object
        {
            PlcBuilder plcbuilder = new PlcBuilder(solution, plcName);
            try
            {
                Project = plcbuilder.findPlcProject();
            }
            catch
            {
                throw new ApplicationException($"Unable to find '{plcName}' object");    
            }
        }

        /// <summary>
        /// Using the loaded solution, load in the project object using the first availabe project in the solution
        /// </summary>
        public Project grabSolutionProject(int itemNum = 1)
        {
            try
            {
                Project = solution.Projects.Item(itemNum);
                return Project;
            }
            catch
            {
                return null;
            }         
        }

        /// <summary>
        /// Save the current solution within a given directory and with a given name
        /// </summary>
        /// <param name="slnPath"></param>
        /// <param name="slnName"></param>
        /// <returns></returns>
        public Boolean saveAs(String slnPath, String slnName)
        {
            try     
            { 
                solution.SaveAs(slnPath + @"\" + slnName + @"\" + slnName + ".sln");
                return true;
            }
            catch   
            {
                return false; 
            }
        }

        //<Not used>
        public void gitBash()
        {
            //Launches a shell script to checks if base code repo is present, clones if not, then switches to master
            //Currently utilising static address locations. Need to package the sh script locally and change script to have input to repo location.
            //What happens if not logged in to git???
            var process = new System.Diagnostics.Process();
            var startinfo = new ProcessStartInfo(@"C:\Users\bem74844\AppData\Local\Programs\Git\git-bash.exe", @" C:\Users\bem74844\Desktop\gitCloneTest\bin\getRepo.sh");
            startinfo.RedirectStandardOutput = true;
            startinfo.UseShellExecute = false;
            process.StartInfo = startinfo;
            process.OutputDataReceived += (cmdSender, args) => Console.WriteLine(args.Data); // do whatever processing you need to do in this handler
            process.Start();
            process.BeginOutputReadLine();
            //process.WaitForExit();
        }
        //<Not used>
        public void addBaseSln(String slnBasePath) //For adding collab code automatically - requires better gitbash
        {
            string template = slnBasePath+ @"\tc_project_app\tc_project_app.plcproj"; //path toproject template
            ITcSmTreeItem plc = SystemManager.LookupTreeItem("TIPC");        
            try
            {
                ITcSmTreeItem newProject = plc.CreateChild("basePLC", 0, "", template);
            }
            catch
            {
                MessageBox.Show("Nope"); //Change the template so it detects version installed and knows where to look
            }
        }

        
        public void exportHW()  //This is not really doing what I want it to at the moment. I need to look at using the import and export XTI option
        {   //Export XTI apparently does everything under it too
            ITcSmTreeItem etherCatMaster = SystemManager.LookupTreeItem("TIID^Device 1 (EtherCAT)");
            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(etherCatMaster.ProduceXml());
            xmlFolderPath = solutionFolder;
            xmlDoc.Save(xmlFolderPath + "hwScan.xml");
            MessageBox.Show("Success");           
        }

        /// <summary>
        /// Export xti file for a given device number under the IO
        /// </summary>
        /// <param name="deviceNumber"></param>       
        public void exportHardwareXTI(int deviceNumber)
        {
            //This keeps link information which I do not want. Would be ideal to strip link information first
            try
            {
                ITcSmTreeItem io = SystemManager.LookupTreeItem("TIID");
                ITcSmTreeItem deviceName = io.Child[deviceNumber];
                io.ExportChild(deviceName.Name, solutionFolder + @"\" + deviceName.Name + @".xti");
            }
            catch
            {
                throw new ApplicationException($"Unable to export hardware");
            }
        }

        /// <summary>
        /// Export xti file for first device
        /// </summary>
        public void exportDevice1XTI()
        {
            exportHardwareXTI(1);
        }

        public void importHardwareXTI(string xtiFile = @"C:\Users\SCooper - work\Documents\Git Repos\TEST CRATE HARDWARE\ Device 1 (EtherCAT).xti")
        {
            try
            {
                ITcSmTreeItem io = SystemManager.LookupTreeItem("TIID");
                io.ImportChild(xtiFile);
            }
            catch
            {
                throw new ApplicationException($"Unable to import hardware");
            }
        }

        public void setupTestCrate()
        {
            openSolution();
            for (int i = 0; i < 20; i++)
            {
                if (grabSolutionProject()!=null)
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                }
            }
            if (Project == null)
            {
                MessageBox.Show("Failed to load in project");
                MessageFilter.Revoke();
                return;
            }
            //Break to connect to hardware
            DialogResult dialogResult = MessageBox.Show("Connect to test crate", "Time for a break", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.Cancel)
            {
                MessageFilter.Revoke();
                return;
            }


            //Solution loaded and project loaded
            //Next task: add NC and parameterise 
            //SystemManager = (ITcSysManager13) project.Object;
            //Create NC Task
            try
            {
                //Look for existing NC Task
                SystemManager.LookupTreeItem("TINC").Child[1].LookupChild("Axes");
            }
            catch
            {
                //Add NC Task
                for (int i = 0; i < 20; i++)
                {
                    if (createNcTask())
                    {
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
                        if (i == 19)
                        {
                            MessageBox.Show("Failed to create NC task");
                            MessageFilter.Revoke();
                            return;
                        }
                    }
                }
            }
            

            //Add NC Axes (2 of them)
            for (int i = 0; i < 10; i++)
            {
                if (addNcAxis())
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    if (i == 9)
                    {
                        MessageBox.Show("Failed to add NC axis");
                        MessageFilter.Revoke();
                        return;
                    }
                }
            }
            System.Threading.Thread.Sleep(500);
            for (int i = 0; i < 10; i++)
            {
                if (addNcAxis())
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    if (i == 9)
                    {
                        MessageBox.Show("Failed to add NC axis");
                        MessageFilter.Revoke();
                        return;
                    }
                }
            }
           

            //Add the IO and startup next
            
            xmlDoc = new XmlDocument();
            
            System.Threading.Thread.Sleep(1000);
            ITcSmTreeItem devices = SystemManager.LookupTreeItem("TIID");
            devices.CreateChild("Device 1 (EtherCAT)", 111, null, null);

            ITcSmTreeItem etherCatMaster = SystemManager.LookupTreeItem("TIID^Device 1 (EtherCAT)");
            etherCatMaster.CreateChild("Term 1 (EK1200)", 9099, "", "EK1200-5000");
            ITcSmTreeItem ek1200 = SystemManager.LookupTreeItem("TIID^Device 1 (EtherCAT)^Term 1 (EK1200)");
            ek1200.CreateChild("Term 2 (EL1808)", 9099, "", "EL1808");
            ek1200.CreateChild("Term 3 (EL2819)", 9099, "", "EL2819");
            ek1200.CreateChild("Term 4 (EL5002)", 9099, "", "EL5002");
            ek1200.CreateChild("Term 5 (EL2014)", 9099, "", "EL2014");
            ek1200.CreateChild("Term 6 (EL7041-0052)", 9099, "", "EL7041-0052");
            ek1200.CreateChild("Term 7 (EL7041-0052)", 9099, "", "EL7041-0052");
            ek1200.CreateChild("Term 8 (EK1110)", 9099, "", "EK1110");

            xmlFolderPath = @"C:\Users\SCooper - work\Documents\Git Repos\TEST CRATE HARDWARE";
            xmlPath = xmlFolderPath + @"\el7041Term6.xml";
            xmlDoc.Load(xmlPath);
            SystemManager.LookupTreeItem("TIID^Device 1 (EtherCAT)^Term 1 (EK1200)^Term 6 (EL7041-0052)").ConsumeXml(xmlDoc.OuterXml);
            xmlPath = xmlFolderPath + @"\el7041Term7.xml";
            xmlDoc.Load(xmlPath);
            SystemManager.LookupTreeItem("TIID^Device 1 (EtherCAT)^Term 1 (EK1200)^Term 7 (EL7041-0052)").ConsumeXml(xmlDoc.OuterXml);

            
            xmlPath = xmlFolderPath + @"\ioConfig.xml";
            xmlDoc.Load(xmlPath);
            //devices.Child[1].ConsumeXml(xmlDoc.OuterXml);
            devices.ConsumeXml(xmlDoc.OuterXml);
            //etherCatMaster.ConsumeXml(xmlDoc.OuterXml);
            //Setup axes


            xmlPath = xmlFolderPath + @"\Axis 1.xml";
            
            xmlDoc.Load(xmlPath);
            try
            {

                //axis = SystemManager.LookupTreeItem("TINC^NC-Task 1 SAF^Axes^Axis 1");
                ncAxisConsumeMap(1,xmlDoc.OuterXml);
            }
            catch
            {
                MessageBox.Show("Failed to add parameters");
            }
            xmlPath = xmlFolderPath + @"\Axis 2.xml";
            xmlDoc.Load(xmlPath);
            try
            {

                //axis = SystemManager.LookupTreeItem("TINC^NC-Task 1 SAF^Axes^Axis 2");
                ncAxisConsumeMap(2,xmlDoc.OuterXml);
            }
            catch
            {
                MessageBox.Show("Failed to add parameters");
            }

            System.Threading.Thread.Sleep(1000);
            //Add PLC stuff
            ITcSmTreeItem plcPou = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^MAIN");
            ITcPlcPou mainPou = (ITcPlcPou)plcPou;
            ITcPlcDeclaration mainPouDec = (ITcPlcDeclaration)plcPou;
            String declarationText = mainPouDec.DeclarationText;
            declarationText = declarationText + Environment.NewLine + "VAR" + Environment.NewLine + "    bEnableAxis1Limits AT %Q*: BOOL:=TRUE;" + Environment.NewLine + "    bEnableAxis2Limits AT %Q*: BOOL:=TRUE;" + Environment.NewLine + "    bEnableAxis1Enc AT %Q*: BOOL:=TRUE;" + Environment.NewLine+"    bEnableAxis2Enc AT %Q*: BOOL:=TRUE;" + Environment.NewLine+"END_VAR";
            mainPouDec.DeclarationText = declarationText;

            //ITcSmTreeItem gvlPouItem = systemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^GVLs^GVL_APP");
            System.Threading.Thread.Sleep(500);
            ITcSmTreeItem gvlPouItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^GVLs").Child[1];

            ITcPlcDeclaration gvlPouDec = (ITcPlcDeclaration)gvlPouItem;
            gvlPouDec.DeclarationText = "{attribute 'qualified_only'}"+Environment.NewLine+"VAR_GLOBAL"+Environment.NewLine+Environment.NewLine+"END_VAR"+Environment.NewLine+Environment.NewLine+"VAR_GLOBAL CONSTANT"+Environment.NewLine+ "    nAXIS_NUM : UINT:=2;" + Environment.NewLine+"END_VAR";

            System.Threading.Thread.Sleep(1000);
            dialogResult = MessageBox.Show("Manually activate configuration", "Time for a break", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                MessageFilter.Revoke();
                return;
            }
            //systemManager.ActivateConfiguration();
            //ACtivate wasn't working, think I need to create the config first! There's a command to do this i think
            xmlPath = xmlFolderPath + @"\xmlMapMCU_HW.xml";
            xmlDoc.Load(xmlPath);
            SystemManager.ConsumeMappingInfo(xmlDoc.OuterXml);
            SystemManager.ActivateConfiguration();
            MessageFilter.Revoke();
            MessageBox.Show("Success!");
        }



        /////////DEVELOPING NEW METHODS HERE
        
    }
}

