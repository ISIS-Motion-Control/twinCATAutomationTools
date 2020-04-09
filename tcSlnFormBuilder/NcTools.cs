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
    public class NcTools
    {
        public XmlDocument xmlDoc;
        public String ncXmlPath = @"C:\Users\bem74844\tcSln\sln3\myTwinCATSln";
        public String ncXmlName = "xmlMap";

        public Boolean createNcTask(ITcSysManager13 systemManager)
        {
            try
            {
                ITcSmTreeItem ncConfig = systemManager.LookupTreeItem("TINC");
                ncConfig.CreateChild("NC-Task 1", 1);
                return true;
            }
            catch
            {
                return false ;
            }
        }
        public Boolean addNcAxis(ITcSysManager13 systemManager)
        {
            try
            {
                ITcSmTreeItem axes = systemManager.LookupTreeItem("TINC").Child[1].LookupChild("Axes");
                //MessageBox.Show((axes.ChildCount).ToString());
                axes.CreateChild("Axis " + (axes.ChildCount + 1).ToString(), 1);
                //MessageBox.Show("That somehow worked");
                return true;
            }
            catch
            {
                //MessageBox.Show("Not a chance sonny");
                return false;
            }
            
        }

        public bool removeNcTask(ITcSysManager13 systemManager) //NOT IMPLEMENTED
        {
            try
            {
                ITcSmTreeItem ncConfig = systemManager.LookupTreeItem("TINC");
                ncConfig.DeleteChild(ncConfig.Child[1].Name);
                MessageBox.Show("Success");
                return true;
            }
            catch { return false; }
        }

        public bool removeAxis() //NOT IMPLEMENTED
        {
            return false;
        }

        public Boolean ncAxisConsumeMap(ITcSmTreeItem axis, String xmlDoc)
        {
            try
            {
                //MessageBox.Show(xmlDoc.OuterXml);
                axis.ConsumeXml(xmlDoc);
                return true;
            }
            catch
            {
                return false;
            }
        }




    }
}
