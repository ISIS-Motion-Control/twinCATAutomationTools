using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tcSln myTcSln = new tcSln(@"C:\Users\bem74844\tcSln\SolutionFolder", "myTwinCATSln");
            myTcSln.SlnBasePath = (@"C:\Users\bem74844\Desktop\gitCloneTest\bin\tc_generic_structure\solution");
            XmlTools myXmlTools = new XmlTools();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(myTcSln));      
        }
    }
}
