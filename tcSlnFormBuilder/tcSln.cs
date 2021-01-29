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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

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
        private String _slnFolder;
        
        //public String solutionPath;
        public String _configFolder; //Used for all XTIs and XML. Should create folder if doesn't exist

        public String xmlHwMapPath;
        public String xmlFolderPath;
        
        public VSVersion version = VSVersion.TWINCAT_SHELL;
        public String versionString = "TWINCAT_SHELL";

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
            get { return _configFolder ?? (_configFolder = SlnFolder + @"\Config"); }
            set 
            { 
                _configFolder = value;
                Directory.CreateDirectory(_configFolder);
            }
        }
        public String SlnFolder
        {
            get { return _slnFolder ?? (_slnFolder = ""); }
            set { _slnFolder = value; }
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
                solution = setupDTE(versionString, true, false, true);
                solution.Open(SlnPath);
                SlnFolder = new FileInfo(SlnPath).Directory.FullName;
                return solution;
                
            }
            catch
            {
                throw new ApplicationException($"Unable to open '{SlnPath}'");
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
            if (solution == null)
            {
                return null;
            }
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

        public void cleanUp()
        {
            if (_systemManager == null)
            {
                solution = null;
                Project = null;
            }
            try { SystemManager.IsTwinCATStarted(); }
            catch {
                solution = null;
                Project = null;
            }
                
            
            MessageFilter.Revoke();
        }

        /// <summary>
        /// Setup directories in the configuration folder
        /// </summary>
        public void setupConfigFolder()
        {
            if (ConfigFolder == @"\Config")
            {
                MessageBox.Show("Config folder path empty");
                return;
            }
            Directory.CreateDirectory(ConfigFolder + @"\axisXmls");
            Directory.CreateDirectory(ConfigFolder + @"\deviceXmls");
            Directory.CreateDirectory(ConfigFolder + @"\plc\declarations");
            Directory.CreateDirectory(ConfigFolder + @"\plc\implementations");
            Directory.CreateDirectory(ConfigFolder + @"\plc\axes");
            Directory.CreateDirectory(ConfigFolder + @"\plc\applications");
        }


        public void setupTestCrate()
        {
            DialogResult dialogResult;
            //Check solution not empty

            if (String.IsNullOrEmpty(SlnPath))
            {
                MessageBox.Show("You have not selected a solution folder", "Oopsie", MessageBoxButtons.OK);
                return;
            }
            //CHECK CONFIG NOT EMPTY FIRST!!!
            if (ConfigFolder == @"\Config")
            {
                MessageBox.Show("You have not selected a configuration folder", "Oopsie", MessageBoxButtons.OK);
                return;
            }

            //If no open project, load the selected one
            if (solution == null)
            {
                openSolution();
            }
            else //check we have a message filter as using already open project
            {
                if (!MessageFilter.IsRegistered)
                    MessageFilter.Register();
            }
            
            //populate the "project" object
            Project = grabSolutionProject();
            //Check we successfully got the project
            if (Project == null)
            {
                MessageBox.Show("Failed to load in project");
                cleanUp();
                return;
            }


            //User prompt to connect to hardware
            dialogResult = MessageBox.Show(@"Connect to test crate." + Environment.NewLine + "Once connected press OK to confirm or cancel to exit the automated setup", "Time for a break", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.Cancel)
            {
                cleanUp();
                return;
            }

            //Set target platform, we are using TwinCAT RT (x64), PLC will not build if this does not match the build method argument later.
            ITcConfigManager configManager = (ITcConfigManager)SystemManager.ConfigurationManager;
            configManager.ActiveTargetPlatform = "TwinCAT RT (x64)";


            //Solution loaded and project loaded
            //Next task: add NC and parameterise 
            
            //Check if an NC task exists, create if not (task exists in default tc_generic code)
            try
            {
                //Look for existing NC Task
                SystemManager.LookupTreeItem("TINC").Child[1].LookupChild("Axes");
            }
            catch
            {
                //Add NC Task
                createNcTask();
            }


            //Check whether the project already has axes and prompt user
            if (getAxisCount() != 0)
            {
                dialogResult = MessageBox.Show("Axes already exists in this solution. Do you want to remove them?", "Time for a break", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    cleanUp();
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    deleteAxes();
                }
            }
            //Add axes equal to number of xml files in the NC folder
            addNcAxes(getNcXmlCount());

            //Check whether the project already has IO in it and prompt user
            if (getIoCount() != 0)
            {
                dialogResult = MessageBox.Show("Hardware already exists in this solution. Do you want to remove this?", "Time for a break", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    MessageFilter.Revoke();
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    deleteIo();
                }
            }
            //Add the IO from a CSV file
            importIoList();
            //Run through all device xmls and import
            importAllIoXmls();

            //Setup axis parameters from available axis xmls
            ncConsumeAllMaps();

            //Add the plc "stuff"
            plcImportDeclarations();

            //New PLC "stuff" to add
            importAxes();
            importApplications();
            setupProgAction();

            //NEED INSTANCES
            buildPlcProject();
            
            //Map the variables
            importXmlMap();
            
            try
            {
                //SystemManager.ActivateConfiguration();
            }
            catch
            {
                cleanUp();
                throw new ApplicationException("Unable to activate configuration");
            }
            cleanUp();
            MessageBox.Show("Success!");
        }
       
        public void createConfiguration()
        {
            //CHECK CONFIG NOT EMPTY FIRST!!!
            if (ConfigFolder == @"\Config")
            {
                MessageBox.Show("You have not selected a configuration folder location", "Oopsie", MessageBoxButtons.OK);
                return;
            }

            //If no open project, load the selected one
            if (solution == null)
            {
                MessageBox.Show("Please open the solution first", "Oopsie", MessageBoxButtons.OK);
                return;
            }
            if (!MessageFilter.IsRegistered)
                MessageFilter.Register();

            setupConfigFolder();
            exportXmlMap();
            clearMap();
            exportAllAxisXmls();
            exportAllIoXmls();
            exportIoList();
            exportPlcDec();
            exportAxes();
            exportApplications();
            cleanUp();
            MessageBox.Show("Export complete."+Environment.NewLine + "Please ensure to update MAIN declaration file", "Configuration export", MessageBoxButtons.OK);
        }

    }
}

