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
        
        /// <summary>
        /// Return count of PLC projects in solution
        /// </summary>
        /// <returns></returns>
        public int plcCount()
        {
            MessageBox.Show(Plc.ChildCount.ToString());
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
           

            //plcPath = SlnPath
            solution.SolutionBuild.BuildProject("Release|TwinCAT RT (x64)", plcPath, true);
        }
    }
}
