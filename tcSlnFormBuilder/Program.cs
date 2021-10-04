using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CommandLine;


namespace tcSlnFormBuilder
{
    static class Program
    {

        [Verb("gui", isDefault: true, HelpText = "Default - no args given.")]
        public class GUIOptions { }


        [Verb("build", HelpText = "Build a given PLC solution.")]
        public class BuildOptions
        {
            [Option('v', "version", Required = true, HelpText = "Set MSCV version, eg VS_2019 for VS2019")]
            public String Version { get; set; }

            [Option('s', "sln_path", Required = true, HelpText = "The PLC solution path to build")]
            public String SlnPath { get; set; }

            [Option('c', "config_folder", Required = true, HelpText = "The config folder directory")]
            public String ConfigFolder { get; set; }
        }

        [Verb("run", HelpText = "Run built PLC solution.")]
        public class RunOptions
        {
            [Option('s', "sln_path", Required = true, HelpText = "The PLC solution path to build")]
            public String SlnPath { get; set; }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            tcSln myTcSln = new tcSln();

            Parser.Default.ParseArguments<GUIOptions, BuildOptions, RunOptions>(args).MapResult(
                (GUIOptions opts)=> ShowInGUI(myTcSln),
                (BuildOptions opts)=> BuildPLCSolution(myTcSln, opts),
                (RunOptions opts)=> RunPLCSolution(myTcSln, opts),
                Errors => 1);
            
        }

        private static int ShowInGUI(tcSln myTcSln)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(myTcSln));
            return 0; 
        }

        private static int BuildPLCSolution(tcSln myTcSln, BuildOptions opts) {
            Console.Out.WriteLine("Building without UI");
            myTcSln.versionString = opts.Version;
            myTcSln.SlnPath = opts.SlnPath;
            myTcSln.ConfigFolder = opts.ConfigFolder;
            myTcSln.setupTestCrate(true);

            return 0; }

        private static int RunPLCSolution(tcSln myTcSln, RunOptions opts) {
            myTcSln.SlnPath = opts.SlnPath;
            myTcSln.runPLCsolution();
            return 0; }


        //Generic exception non-handling handler
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }

}
