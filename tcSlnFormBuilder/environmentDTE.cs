using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcSlnFormBuilder
{

    class environmentDTE
    {
        public EnvDTE.DTE dte;
        public EnvDTE.DTE getDTE(VSVersion version, bool supressUI, bool windowVisible)
        {
            Type VSType = System.Type.GetTypeFromProgID(version.DTEDesc);
            EnvDTE.DTE dte = (EnvDTE.DTE)System.Activator.CreateInstance(VSType);
            dte.SuppressUI = supressUI;
            dte.MainWindow.Visible = windowVisible;
            return dte;
        }
        
        public dynamic CreateDTE(string appID, bool ideVisible, bool suppressUI, bool userControl)
        {
            Type tp = Type.GetTypeFromProgID(VSVersion.ReturnVersion(appID));
            if (tp == null)
                throw new ApplicationException($"AppID '{appID}' not found!");
            dynamic dte = System.Activator.CreateInstance(tp, true);
            if (!MessageFilter.IsRegistered)
                MessageFilter.Register();
            dte.MainWindow.WindowState = 0;
            dte.MainWindow.Visible = ideVisible;
            dte.SuppressUI = suppressUI;
            dte.UserControl = userControl;
            return dte;

        }

    }


}