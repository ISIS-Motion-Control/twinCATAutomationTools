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
        private String _axisDirectory = @"\axisXmls";


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
        public String AxisDirectory
        {
            get { return _axisDirectory; }
            set { _axisDirectory = value; }
        }

        /// <summary>
        /// Create NC Task in solution
        /// </summary>
        /// <returns></returns>
        public void createNcTask()
        {
            try
            {
                NcConfig.CreateChild("NC-Task 1", 1);
            }
            catch
            {
                throw new ApplicationException("Unable to create NC Task");
            }
        }

        /// <summary>
        /// Add 'nAxes' number of NC axes to the solution
        /// </summary>
        /// <param name="nAxes"></param>
        /// <returns></returns>
        public Boolean addNcAxes(int nAxes)
        {
            try
            {
                for (int i = 0; i < nAxes; i++)
                {
                    addNcAxis();
                }
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
        /// Add a single standard stepper axis to the NC task with a given axis name
        /// </summary>
        /// <param name="axisName"></param>
        /// <returns></returns>
        public Boolean addNamedNcAxis(String axisName)
        {
            try
            {
                Axes.CreateChild(axisName, 1);
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
        /// Use the file names in the config folder to create axes
        /// </summary>
        public void addNamedNcAxes()
        {
            string axisFolder = ConfigFolder + AxisDirectory;
            if(!Directory.Exists(axisFolder))
            {
                throw new ApplicationException($"Folder not found: {axisFolder}");
            }
            foreach (var file in Directory.GetFiles(axisFolder))
            {
                addNamedNcAxis(Path.GetFileNameWithoutExtension(file));
            }
        }

        /// <summary>
        /// Returns int of number of XML files in axis folder
        /// </summary>
        /// <returns></returns>
        public int getNcXmlCount()
        {
            string axisFolder = ConfigFolder + AxisDirectory;
            if (!Directory.Exists(axisFolder))
            {
                throw new ApplicationException($"Folder not found: {axisFolder}");
            }

            return Directory.GetFiles(axisFolder).Length;
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
                throw new ApplicationException($"Not able to find {axisName}.");
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

        /// <summary>
        /// For each xml file in axis directory folder, import parameters
        /// </summary>
        public void ncConsumeAllMaps()
        {
            string axisFolder = ConfigFolder + AxisDirectory;
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


        public void exportAllAxisXmls()
        {
            for (int i=0; i<getAxisCount(); i++)
            {
                exportAxisXml(i);
            }
        }
        
        public void exportAxisXml(int axisNumber)
        {            
            ITcSmTreeItem axisName = Axes.Child[axisNumber+1];
            string xmlDescription = axisName.ProduceXml();
            File.WriteAllText(ConfigFolder + @"\"+ AxisDirectory + @"\" + axisName.Name + @".xml", xmlDescription);
        }
    }
}
