using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcSlnFormBuilder
{
    class environmentDTE
    {
        //opens the visual studio environment
        public EnvDTE.DTE dte;
        public EnvDTE.DTE getDTE(VSVersion version, bool supressUI, bool windowVisible)
        {
            Type VSType = System.Type.GetTypeFromProgID(version.DTEDesc);
            EnvDTE.DTE dte = (EnvDTE.DTE)System.Activator.CreateInstance(VSType);
            dte.SuppressUI = supressUI;
            dte.MainWindow.Visible = windowVisible;
            return dte;
        }
    }
}