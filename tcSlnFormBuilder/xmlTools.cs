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
    public class XmlTools
    {
        public XmlDocument xmlDoc;
        public String xmlPath = @"C:\Users\bem74844\tcSln\sln3\myTwinCATSln";
        public String xmlName = "xmlMap";

        public bool consumeXmlMap(ITcSysManager13 systemManager, String xmlFullFilePath)
        {
            try
            {               
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFullFilePath);
                systemManager.ConsumeMappingInfo(xmlDoc.OuterXml);
                MessageBox.Show("Success");
                return true;             
            }
            catch
            {
                MessageBox.Show("Failed to consume", "Oops");
                return false;
            }           
        }
        public bool clearXmlMap(ITcSysManager13 systemManager)
        {
            try
            {             
                systemManager.ClearMappingInfo();
                MessageBox.Show("Map cleared");
                return true;
            }
            catch
            {
                MessageBox.Show("Map failed to clear", "Oops");
                return false;
            }
        }
        public bool produceXmlMap(ITcSysManager13 systemManager)
        {
            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(systemManager.ProduceMappingInfo());
                xmlDoc.Save(xmlPath + @"\" + xmlName + @".xml");
                MessageBox.Show("Success");
                return true;
            }
            catch
            {
                MessageBox.Show("Failed to create XML map","Oops");
                return false;
            }
        }
    }
}
