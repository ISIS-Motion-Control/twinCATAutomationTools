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
        private String _ioFile = @"\io.xti";
        public String IoFile
        {
            get { return _ioFile; }
            set { _ioFile = value; }
        }

        private ITcSmTreeItem _io;
        public ITcSmTreeItem Io
        {
            get { return _io ?? (_io = SystemManager.LookupTreeItem("TIID")); }
            set { _io = value; }
        }


        /// <summary>
        /// Export xti file for a given device number under the IO (Will retain mappings by default)
        /// </summary>
        /// <param name="deviceNumber"></param>       
        public Boolean exportHardwareXTI(int deviceNumber)
        { 
            try
            {
                //ITcSmTreeItem io = SystemManager.LookupTreeItem("TIID");
                ITcSmTreeItem deviceName = Io.Child[deviceNumber];
                Io.ExportChild(deviceName.Name, ConfigFolder + IoFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Export xti file for first device
        /// </summary>
        public void exportDevice1XTI()
        {
            exportHardwareXTI(1);
        }
        
        /// <summary>
        /// Import XTI File
        /// </summary>
        /// <returns></returns>
        public Boolean importIoXti()
        {
            try
            {               
                Io.ImportChild(ConfigFolder + IoFile,"",true,"Device "+ (Io.ChildCount + 1).ToString()+ " (EtherCAT)");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

