using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EnvDTE;
using TCatSysManagerLib;
using System.Windows.Forms;
using System.IO;

namespace tcSlnFormBuilder
{
    public partial class tcSln
    {
        private ITcSmTreeItem _plc;
        private String _plcDirectory = @"\plc";
        private String _decDirectory = @"\declarations";
        private String _impDirectory = @"\implementations";
        private String _axesDirectory = @"\axes";
        private String _appDirectory = @"\applications";


        public ITcSmTreeItem Plc
        {
            get { return _plc ?? (_plc = SystemManager.LookupTreeItem("TIPC")); }
            set { _plc = value; }
        }

        public String PlcDirectory
        {
            get { return _plcDirectory; }
            set { _plcDirectory = value; }
        }        
        public String DecDirectory
        {
            get { return _decDirectory; }
            set { _decDirectory = value; }
        }
        public String ImpDirectory
        {
            get { return _impDirectory; }
            set { _impDirectory = value; }
        }
        public String AxesDirectory
        {
            get { return _axesDirectory; }
            set { _axesDirectory = value; }
        }
        public String AppDirectory
        {
            get { return _appDirectory; }
            set { _appDirectory = value; }
        }

        /// <summary>
        /// Return count of PLC projects in solution
        /// </summary>
        /// <returns></returns>
        public int plcCount()
        {
            return Plc.ChildCount;
        }
     
        /// <summary>
        /// Run through each file in declarations folder and import to solution
        /// </summary>
        public void plcImportDeclarations()
        {
            string directoryPath = ConfigFolder + PlcDirectory + DecDirectory;
            if (!Directory.Exists(directoryPath))
            {
                throw new ApplicationException($"Folder not found {directoryPath}");
            }
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                modifyDeclaration(file);
            }
        }
        
        /// <summary>
        /// Import declaration file
        /// </summary>
        /// <param name="decFile"></param>
        public void modifyDeclaration(string decFile)
        {
            //check file exists
            if (!File.Exists(decFile))
            {
                throw new ApplicationException($"PLC file {decFile} could not be found.");
            }
            string plcItemName = File.ReadLines(decFile).First();
            ITcSmTreeItem plcItem;
            try
            {
                plcItem = SystemManager.LookupTreeItem("TIPC^" + plcItemName);
            }
            catch
            {
                throw new ApplicationException($"Unable to find item {plcItemName}");
            }
            ITcPlcDeclaration plcItemDec;
            try
            {
                plcItemDec = (ITcPlcDeclaration)plcItem;
            }
            catch
            {
                throw new ApplicationException($"Unable to create declaration field for item {plcItemName}");
            }

            string declarationText = "";
            int lineCount = File.ReadLines(decFile).Count();
            for (int i = 2; i < lineCount; i++)
            {
                declarationText += Environment.NewLine + File.ReadLines(decFile).ElementAt(i);
            }

            if (File.ReadLines(decFile).ElementAt(1) == "add")
            {
                string existingText = plcItemDec.DeclarationText;
                plcItemDec.DeclarationText = existingText + declarationText;
            }
            else if (File.ReadLines(decFile).ElementAt(1) == "replace")
            {
                plcItemDec.DeclarationText = declarationText;
            }
            else
            {
                throw new ApplicationException("No valid add/replace method found in text file");
            }
        }
        public void buildPlcProject()
        {
            String plcPath;
            String solutionName;
            solutionName = Path.GetFileNameWithoutExtension(SlnPath);
            //solutionName = new FileInfo(SlnPath).Name;
            plcPath = SlnFolder + @"\" + solutionName + @"\" + Plc.Child[1].Name + @"\" + Plc.Child[1].Name + @".plcproj";
            solution.SolutionBuild.BuildProject("Release|TwinCAT RT (x64)", plcPath, true);
        }

        public void exportPlcDec()
        {
            //Create two files for GVL and MAIN. 
            //GVL will be an actual copy of project GVL
            //Main will just be a template file
            String path = ConfigFolder + PlcDirectory + DecDirectory;
            String fileName = @"\mainDeclation.txt";

            String declaration = "tc_project_app^tc_project_app Project^POUs^MAIN" + Environment.NewLine + "add";

            File.WriteAllText(path+ fileName, declaration);

            fileName = @"\gvlAppDeclaration.txt";
            ITcSmTreeItem plcItem;
            try
            {
                plcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^GVLs^GVL_APP");
            }
            catch
            {
                throw new ApplicationException($"Unable to find item GVL_APP");
            }
            ITcPlcDeclaration plcItemDec;
            try
            {
                plcItemDec = (ITcPlcDeclaration)plcItem;
            }
            catch
            {
                throw new ApplicationException($"Unable to create declaration field for item GVL_APP");
            }
            declaration = "tc_project_app^tc_project_app Project^GVLs^GVL_APP" + Environment.NewLine + "replace" + Environment.NewLine + plcItemDec.DeclarationText;
            File.WriteAllText(path + fileName, declaration);
        }

        public void exportAxes()
        {
            String path = ConfigFolder + PlcDirectory + AxesDirectory;
            if (Directory.Exists(path)==false)
            {
                Directory.CreateDirectory(ConfigFolder + @"\plc\axes");
            }
            String axesFolder = SlnFolder + @"\solution\tc_project_app\POUs\Application_Specific\Axes";
            foreach(string file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }

            foreach (string filePath in Directory.GetFiles(axesFolder))
                {File.Copy(filePath, filePath.Replace(axesFolder, path)); }

        }
        public void importAxes()
        {
            String path = ConfigFolder + PlcDirectory + AxesDirectory;
            String axesFolder = SlnFolder + @"\solution\tc_project_app\POUs\Application_Specific\Axes";
            ITcSmTreeItem plcItem;
            try
            {
                plcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^Application_Specific^Axes");
            }
            catch
            {
                throw new ApplicationException($"Unable to find Axes Application Specific directory in solution");
            }
            //Clear the folder in the solution explorer
            if (plcItem.ChildCount !=0)
            {
                while(plcItem.ChildCount!=0)
                {
                    try
                    {
                        plcItem.DeleteChild(plcItem.Child[1].Name);
                    }
                    catch
                    {
                        throw new ApplicationException("Unable to delete Axis PLC Item");
                    }
                }
            }
            //Import all the items
            foreach (string filePath in Directory.GetFiles(path))
            {
                
                plcItem.CreateChild(Path.GetFileNameWithoutExtension(filePath), 58, null, filePath);
            }
        }


        public void exportApplications()
        {
            String path = ConfigFolder + PlcDirectory + AppDirectory;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(ConfigFolder + @"\plc\applications");
            }
            String appsFolder = SlnFolder + @"\solution\tc_project_app\POUs\Application_Specific\Applications";
            foreach (string file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }
            foreach (string filePath in Directory.GetFiles(appsFolder))
            { File.Copy(filePath, filePath.Replace(appsFolder, path)); }
        }

        public void importApplications()
        {
            String path = ConfigFolder + PlcDirectory + AppDirectory;
            String axesFolder = SlnFolder + @"\solution\tc_project_app\POUs\Application_Specific\Applications";
            ITcSmTreeItem plcItem;
            try
            {
                plcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^Application_Specific^Applications");
            }
            catch
            {
                throw new ApplicationException($"ERROR HEREUnable to find Axes Application Specific directory in solution");
            }
            //Clear the folder in the solution explorer
            if (plcItem.ChildCount != 0)
            {
                while (plcItem.ChildCount != 0)
                {
                    try
                    {
                        plcItem.DeleteChild(plcItem.Child[1].Name);
                    }
                    catch
                    {
                        throw new ApplicationException("Error, Unable to delete Application_Specific PLC Item");
                    }
                }
            }
            //Import all the items
            if (Directory.Exists(path))
            {
                foreach (string filePath in Directory.GetFiles(path))
                {
                    plcItem.CreateChild(Path.GetFileNameWithoutExtension(filePath), 58, null, filePath);
                }
            } else
            {
                Console.WriteLine($"WARNING, application folder {path} does not exist");
            }
        }

        public void setupProgAction()
        {
            ITcSmTreeItem plcItem;
            try
            {
                plcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^MAIN^PROG");
            }
            catch
            {
                throw new ApplicationException($"Unable to find PROG action in solution");
            }
            ITcPlcImplementation plcImp;
            plcImp = (ITcPlcImplementation)plcItem;

            //Need to build up the string
            string impText ="";
            //Axes first
            ITcSmTreeItem axesPlcItem;
            try
            {
                axesPlcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^Application_Specific^Axes");
            }
            catch
            {
                throw new ApplicationException($"Couldn't find axes folder");
            }
            for (int i = 1; i < axesPlcItem.ChildCount + 1; i++)
            {
                impText +=  axesPlcItem.Child[i].Name + @"();" + Environment.NewLine;
            }
            //Now Applications
            ITcSmTreeItem appsPlcItem;
            try
            {
                appsPlcItem = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^Application_Specific^Applications");
            }
            catch
            {
                throw new ApplicationException($"Couldn't find applications folder");
            }
            for (int i = 1; i < appsPlcItem.ChildCount + 1; i++)
            {
                impText += appsPlcItem.Child[i].Name + @"();" + Environment.NewLine;
            }
            plcImp.ImplementationText = impText;

        }
    }
}
