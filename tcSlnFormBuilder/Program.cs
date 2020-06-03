using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace tcSlnFormBuilder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            //tcSln myTcSln = new tcSln(@"C:\Users\bem74844\tcSln\SolutionFolder", "myTwinCATSln");
            tcSln myTcSln = new tcSln();
            myTcSln.SlnPath = @"C:\Users\bem74844\tcSln\SolutionFolder";
            myTcSln.SlnName = "myTwinCATSln";
            myTcSln.SlnBasePath = (@"C:\Users\bem74844\Desktop\gitCloneTest\bin\tc_generic_structure\solution");
            myTcSln.xmlFolderPath = (@"C:\Users\SCooper - work\Documents\Git Repos\TEST CRATE HARDWARE\");
            //XmlTools myXmlTools = new XmlTools();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(myTcSln));
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }

}
