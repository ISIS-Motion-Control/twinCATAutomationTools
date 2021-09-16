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
        static void Main(string[] args)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            tcSln myTcSln = new tcSln();

            if (args.Length > 0) {
                //Run without a UI
                //Arguments are VS version, solution, config area
                Console.Out.WriteLine("Running without UI");
                myTcSln.versionString = args[0];

                myTcSln.SlnPath = args[1];

                myTcSln.xmlFolderPath = args[2];
                myTcSln.ConfigFolder = args[2];

                myTcSln.setupTestCrate(true);

            } else {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(myTcSln));
            }
        }


        //Generic exception non-handling handler
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }

}
