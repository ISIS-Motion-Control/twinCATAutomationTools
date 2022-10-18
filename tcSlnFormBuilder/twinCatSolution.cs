using System;
using TCatSysManagerLib;
using EnvDTE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tcSlnFormBuilder
{
    class twinCatSolution
    {
        private string _solutionFilePath;
        public string SolutionFilePath
        {
            get { return _solutionFilePath; }
            set { _solutionFilePath = value; }
        }
        private string _solutionFileDirectory;
        public string SolutionFileDirectory
        {
            get { return _solutionFileDirectory; }
            set { _solutionFileDirectory = value; }
        }

        private string _configFolderPath;
        public string ConfigFolderPath
        {
            get { return _configFolderPath; }
            set { _configFolderPath = value; }
        }

        private Solution _twinCatSolution;
        public Solution TwinCatSolution
        {
            get { return _twinCatSolution; }
            set { _twinCatSolution = value; }
        }

        private string _visualStudioVersion = "TWINCAT_SHELL";

        public string VisualStudioVersion
        {
            get { return _visualStudioVersion; }
            set { _visualStudioVersion = value; }
        }

        private Project solutionProject;
        private ITcSysManager13 systemManager;
        private ITcConfigManager configManager;



        public twinCatSolution(string solutionFilePath, string configFolderPath = null, bool quiet = false)
        {
            SolutionFilePath = solutionFilePath;
            ConfigFolderPath = configFolderPath;
            openSolutionFile(quiet);
            populateObjects();
        }


        public bool openSolutionFile(bool quiet = false)
        {
            if(!string.IsNullOrEmpty(SolutionFilePath))
            {
                try
                {
                    TwinCatSolution = setupDTE(VisualStudioVersion, !quiet, quiet, !quiet);
                    TwinCatSolution.Open(SolutionFilePath);
                    SolutionFileDirectory = new FileInfo(SolutionFilePath).Directory.FullName;
                    return true;
                }
                catch
                {
                    Console.WriteLine("Failed to open solution");
                    return false;
                }               
            }
            Console.WriteLine("No solution file specified");
            return false;
        }

        private bool populateObjects()
        {
            if (!populateSolutionProject()) return false;
            if (!populateSystemManager()) return false;
            if (!populateConfigManager()) return false;
            return true;

        }

        private bool populateSolutionProject(int itemNum =1)
        {
            if(TwinCatSolution != null)
            {
                try
                {
                    solutionProject = TwinCatSolution.Projects.Item(itemNum);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        private bool populateSystemManager()
        {
            if (solutionProject != null)
            {
                try
                {
                    systemManager = solutionProject.Object;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        private bool populateConfigManager()
        {
            if (systemManager != null)
            {
                try
                {
                    configManager = systemManager.ConfigurationManager;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }



        public Solution setupDTE(string appID, bool ideVisible, bool suppressUI, bool userControl)
        {
            if (!MessageFilter.IsRegistered)
                MessageFilter.Register();
            environmentDTE vsDTE = new environmentDTE();
            vsDTE.dte = vsDTE.CreateDTE(appID, ideVisible, suppressUI, userControl);
            return vsDTE.dte.Solution;
        }

        private void clearObjects()
        {
            //Method to clear internal objects
        }
    }
}
