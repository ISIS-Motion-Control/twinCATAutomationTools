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
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;
using System.Net.Http.Headers;

namespace tcSlnFormBuilder
{
    public partial class tcSln 
    {
        private ITcSmTreeItem _ncConfig;
        private ITcSmTreeItem _axes;
        

        public ITcSmTreeItem NcConfig
        {
            get { return _ncConfig ?? (_ncConfig = SystemManager.LookupTreeItem("TINC")); }
            set { _ncConfig = value; }
        }       
        public ITcSmTreeItem Axes
        {
            get { return _axes ?? (_axes = NcConfig.Child[1].LookupChild("Axes")); }
            set { _axes = value; }
        }

        /// <summary>
        /// Create NC Task in solution
        /// </summary>
        /// <returns></returns>
        public Boolean createNcTask()
        {
            try
            {
                NcConfig.CreateChild("NC-Task 1", 1);
                return true;
            }
            catch { return false; }
        }
        
        /// <summary>
        /// Add single standard stepper axis to NC Task
        /// </summary>
        /// <returns></returns>
        public Boolean addNcAxis()
        {
            try
            {
                Axes.CreateChild("Axis " + (Axes.ChildCount + 1).ToString(), 1);
                return true;
            }
            catch { return false; }            
        }
       
        /// <summary>
        /// Remove NC Task and all axes from solution
        /// </summary>
        /// <returns></returns>
        public Boolean removeNcTask() 
        {
            try
            {
                NcConfig.DeleteChild(NcConfig.Child[1].Name);
                NcConfig = null;
                Axes = null;
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// With given file, search axes for match and consume
        /// </summary>
        /// <param name="xmlFile"></param>
        public void ncAxisMapSearchConsume(string xmlFile)
        {
            ITcSmTreeItem axis;
            XmlDocument axisXml = new XmlDocument();
            if (!File.Exists(xmlFile))
            {
                throw new ApplicationException($"IO Xml file {xmlFile} could not be found.");
            }
            string axisName = Path.GetFileNameWithoutExtension(xmlFile);
            try
            {
                axis = Axes.LookupChild(axisName);
            }
            catch
            {
                throw new ApplicationException($"Not able to fine {axisName}.");
            }
            axisXml.Load(xmlFile);
            try
            {
                axis.ConsumeXml(axisXml.OuterXml);
            }
            catch
            {
                throw new ApplicationException($"Unable to consume xml for {axisName}");
            }           
        }
        

        public void ncConsumeAllMaps()
        {
            string axisFolder = ConfigFolder + @"\axisXmls\";
            if (!Directory.Exists(axisFolder))
            {
                throw new ApplicationException($"Folder not found: {axisFolder}");
            }
            
            foreach (string file in Directory.GetFiles(axisFolder))
            {
                ncAxisMapSearchConsume(file);
            }
        }
        
        
        /// <summary>
        /// Set NC axis parameters
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public Boolean ncAxisConsumeMap(int axisNum, String xmlString)
        {
            ITcSmTreeItem axis;
            try
            {
                axis = Axes.LookupChild("Axis " + axisNum);
                axis.ConsumeXml(xmlString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Return the number of axes in project
        /// </summary>
        /// <returns></returns>
        public int getAxisCount()
        {
            return Axes.ChildCount;
        }

        /// <summary>
        /// Delete all axes in project but level NC task
        /// </summary>
        public void deleteAxes()
        {
            if (getAxisCount() == 0)
            {
                throw new ApplicationException("Already no axes in tree");
            }
            while (getAxisCount() != 0)
            {
                try
                {
                    Axes.DeleteChild(Axes.Child[1].Name);
                }
                catch
                {
                    throw new ApplicationException($"Unable to delete {Axes.Child[1].Name}.");
                }

            }
        }



    }
}
