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

namespace tcSlnFormBuilder
{
    public class tcSln
    {
        private String slnPath = " ";
        private String slnName = " ";
        private String slnBasePath = " ";
        private String plcName;
        private Project project;
        private Solution solution;
        private ITcSysManager13 systemManager;
        public XmlDocument xmlDoc;
        public XmlTools xmlTools= new XmlTools();
        public NcTools ncTools = new NcTools();
        

        public tcSln(String slnPath, String slnName)
        {
            this.slnPath = slnPath;
            this.slnName = slnName;
        }
        public String SlnPath
        {
            get { return slnPath; }
            set { slnPath = value; }
        }
        public String SlnName
        {
            get { return slnName; }
            set { slnName = value; }
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
            get { return project; }
            set { project = value; }
        }


        private Solution setupDTE() //Load up VS environment and set the solution
        {
            environmentDTE vsDTE = new environmentDTE(); //class for holding DTE dependent on VS version          
            vsDTE.dte = vsDTE.getDTE(VSVersion.TWINCAT_SHELL, false, true); //get the DTE
            return vsDTE.dte.Solution;
        }
        public void create() //Create TwinCAT solution and add the TwinCAT "PROJECT" structure
        {
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
                        MessageBox.Show("Issue accessing folder directory");
                        return;
                    }
                }
            }
            solution = setupDTE();
            System.IO.Directory.CreateDirectory(slnPath);
            System.IO.Directory.CreateDirectory(slnPath + @"\" + slnName);

            solution.Create(slnPath, slnName);
            try
            {
                saveAs(solution, slnPath, slnName);

            }
            catch
            {
                MessageBox.Show("Solution won't save");
            }
            string template = @"C:\TwinCAT\3.1\Components\Base\PrjTemplate\TwinCAT Project.tsproj"; //path toproject template

            try
            {
                project = solution.AddFromTemplate(template, slnPath + @"\" + slnName, "MyProject", false);
            }
            catch
            {
                MessageBox.Show("Unable to add TwinCAT Solution template"); //Change the template so it detects version installed and knows where to look
                return;
            }
            systemManager = project.Object;
            project.Save();
            saveAs(solution, slnPath, slnName);
        }
        public Solution openSolution()    //Open existing TwinCAT solution
        {
            solution = setupDTE();
            solution.Open(slnPath + @"\" + slnName + @"\" + slnName + @".sln");
            return solution;
        }

        public void createPLC() //NOT IMPLEMENTED
        {
         
        }
        public void findPLCProject()    //Search projects in solution for named PLC. THen assigns PROJECT object
        {
            PlcBuilder plcbuilder = new PlcBuilder(solution, plcName);
            try
            {
                project = plcbuilder.findPlcProject();
                systemManager = project.Object;
            }
            catch
            {
                MessageBox.Show("Unable to load in project object");
            }
        }
        public void grabFirstProject()
        {
            try
            {
                project = solution.Projects.Item(1);
            }
            catch
            {
                MessageBox.Show("No solution loaded or no projects in solution");
            }
            
        }

        public void saveAs(Solution solution, String slnPath, String slnName)
        {
            try     { solution.SaveAs(slnPath + @"\" + slnName + @"\" + slnName + ".sln"); }
            catch   { MessageBox.Show("Unable to save solution"); }
        }   //Save the current solution
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
        public void addBaseSln(String slnBasePath)
        {
            string template = slnBasePath+ @"\tc_project_app\tc_project_app.plcproj"; //path toproject template
            ITcSmTreeItem plc = systemManager.LookupTreeItem("TIPC");        
            try
            {
                ITcSmTreeItem newProject = plc.CreateChild("basePLC", 0, "", template);
            }
            catch
            {
                MessageBox.Show("Nope"); //Change the template so it detects version installed and knows where to look
            }
        }   //Add the bitbucket base plc solution
    
        public void createNC()
        {
            try
            {
                systemManager = project.Object;
                ITcSmTreeItem ncConfig = systemManager.LookupTreeItem("TINC");
                ncConfig.CreateChild("NC-Task", 1);
                MessageBox.Show("Task created");
                try
                {
                    ITcSmTreeItem axes = systemManager.LookupTreeItem("TINC^NC-Task SAF^Axes");
                    axes.CreateChild("Axis 1", 1);
                    MessageBox.Show("Axis created");
                }
                catch
                {
                    MessageBox.Show("Failed to create Axis", "Oopsie");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Failed to create NC", "OH DEAR");
                return;
            }
            
            
        }
    }
}

