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

        public bool createNcTask(ITcSysManager13 systemManager)
        {
            try
            {
                ITcSmTreeItem ncConfig = systemManager.LookupTreeItem("TINC");
                ncConfig.CreateChild("NC-Task", 1);
                MessageBox.Show("Task created");
                return true;
            }
            catch
            {
                MessageBox.Show("Failed to create NC", "OH DEAR");
                return false ;
            }
        }
        public bool addNcAxis(ITcSysManager13 systemManager)
        {
            try
            {
                ITcSmTreeItem axes = systemManager.LookupTreeItem("TINC").Child[1].LookupChild("Axes");
                MessageBox.Show((axes.ChildCount).ToString());
                axes.CreateChild("Axis " + (axes.ChildCount + 1).ToString(), (axes.ChildCount + 1));
                MessageBox.Show("That somehow worked");
                return true;
            }
            catch
            {
                MessageBox.Show("Not a chance sonny");
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




    }
}
