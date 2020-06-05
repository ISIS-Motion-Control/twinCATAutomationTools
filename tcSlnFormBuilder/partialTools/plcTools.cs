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
    /*PLC TOOLS
     *Ideas:  
     * adding declaration area variables
     * adding *?* area code
     * 
     */
    public partial class tcSln
    {

        private ITcSmTreeItem _plcPou;
        private ITcSmTreeItem _plc;
        private ITcSmTreeItem _plcMain;
        private ITcSmTreeItem _plcGvlApp;
        private String _mainDecFile = @"\mainDeclaration.txt";
        private String _gvlAppDecFile = @"\gvlAppDeclaration.txt";
        private String _plcDirectory = @"\plc";

        public ITcSmTreeItem PlcPou
        {
            get { return _plcPou ?? (_plcPou = SystemManager.LookupTreeItem("TIPC^tc_project_app^tc_project_app Project^POUs^MAIN")); }
            set { _plcPou = value; }
        }

        public ITcSmTreeItem Plc
        {
            get { return _plc ?? (_plc = SystemManager.LookupTreeItem("TIPC")); }
            set { _plc = value; }
        }

        public ITcSmTreeItem PlcMain
        {
            //get { return _plcMain; }
            get { return _plcMain ?? (_plcMain = SystemManager.LookupTreeItem("TIPC^" + Plc.Child[1].Name + "^" + Plc.Child[1].Name + " Project^POUs^MAIN")); }
            set { _plcMain = value; }
        }

        public ITcSmTreeItem PlcGvlApp
        {
            get { return _plcGvlApp ?? (_plcGvlApp = SystemManager.LookupTreeItem("TIPC^" + Plc.Child[1].Name + "^" + Plc.Child[1].Name + " Project^GVLs^GVL_APP")); }
            set { _plcGvlApp = value; }
        }

        private String MainDecFile
        {
            get { return _mainDecFile; }
            set { _mainDecFile = value; }
        }
        private String GvlAppDecFile
        {
            get { return _gvlAppDecFile; }
            set { _gvlAppDecFile = value; }
        }

        private String PlcDirectory
        {
            get { return _plcDirectory; }
            set { _plcDirectory = value; }
        }

        public int plcItemCount()
        {
            MessageBox.Show(Plc.ChildCount.ToString());
            return Plc.ChildCount;
        }
        
        
        public void plcAddMainDeclaration()
        {

            //PlcMain = SystemManager.LookupTreeItem("TIPC^" + Plc.Child[1].Name + "^" + Plc.Child[1].Name + " Project^POUs^MAIN");
            ITcPlcPou mainPou = (ITcPlcPou)PlcMain;
             ITcPlcDeclaration mainPouDec = (ITcPlcDeclaration)mainPou;
             String declarationText = mainPouDec.DeclarationText;
             String newDecText;
             //Need to change this to add from /plc/mainDeclaration now
             try
             {
                 newDecText = File.ReadAllText(ConfigFolder + PlcDirectory + MainDecFile);
             }
             catch
             {
                 throw new ApplicationException("Could not find Main Declaration file");
             }


             declarationText = declarationText + Environment.NewLine + newDecText;
             mainPouDec.DeclarationText = declarationText;
             
        }

        public void plcNewGvlAppDeclaration()
        {
            ITcPlcDeclaration gvlAppDec = (ITcPlcDeclaration)PlcGvlApp;
            String newDecText;
            try
            {
                newDecText = File.ReadAllText(ConfigFolder + PlcDirectory + GvlAppDecFile);
            }
            catch
            {
                throw new ApplicationException("Could not find GVL_App declaration file");
            }
            gvlAppDec.DeclarationText = newDecText;
            //gvlAppDec.DeclarationText= "{attribute 'qualified_only'}" + Environment.NewLine + "VAR_GLOBAL" + Environment.NewLine + Environment.NewLine + "END_VAR" + Environment.NewLine + Environment.NewLine + "VAR_GLOBAL CONSTANT" + Environment.NewLine + "    nAXIS_NUM : UINT:=2;" + Environment.NewLine + "END_VAR";
        }
    }
}
