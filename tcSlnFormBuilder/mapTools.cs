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
        private String _mappingsFile = @"\mappings.xml";
        public String MappingsFile
        {
            get { return _mappingsFile; }
            set { _mappingsFile = value; }
        }

        /// <summary>
        /// Create an xml variable map file for project
        /// </summary>
        /// <returns></returns>
        public Boolean exportXmlMap()
        {
            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(SystemManager.ProduceMappingInfo());
                xmlDoc.Save(ConfigFolder + MappingsFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Clear the variable maps for project
        /// </summary>
        /// <returns></returns>
        public Boolean clearMap()
        {
            try
            {
                SystemManager.ClearMappingInfo();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Import a variable map for the project
        /// </summary>
        /// <returns></returns>
        public Boolean importXmlMap()
        {
            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(ConfigFolder + MappingsFile);
                SystemManager.ConsumeMappingInfo(xmlDoc.OuterXml);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
