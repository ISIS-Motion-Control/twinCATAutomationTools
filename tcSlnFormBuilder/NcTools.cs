using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EnvDTE;
using TCatSysManagerLib;
using System.Windows.Forms;

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
        /// Set NC axis parameters
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public Boolean ncAxisConsumeMap(int axisNum, String xmlString)
        {
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
    }
}
