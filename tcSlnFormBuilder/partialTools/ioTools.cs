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
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;
using System.Net.Http.Headers;

namespace tcSlnFormBuilder
{
    public partial class tcSln
    {
        private String _ioDirectory = @"\deviceXmls";
        public String IoDirectory
        {
            get { return _ioDirectory; }
            set { _ioDirectory = value; }
        }
        private String _ioFile = @"\io.xti";
        public String IoFile
        {
            get { return _ioFile; }
            set { _ioFile = value; }
        }
        private String _ioListFile = @"\ioList.csv";
        private String IoListFile
        {
            get { return _ioListFile; }
            set { _ioListFile = value; }
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
                Io.ImportChild(ConfigFolder + IoFile, "", true, "Device " + (Io.ChildCount + 1).ToString() + " (EtherCAT)");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Take in a list file to create "hardware children"
        /// CSV format: #subIndexLevel, #NameOfDevice, #subtype, #bStrBefore ,#ProductRevision
        /// #subtype is common for children of an EtherCAT Master (9099) - exceptions to this rule on pg69 of automation interface documentation
        /// #bStrBefore allows to specify position of insertion
        /// #wildcards can be used in product revision (latest will be used)
        /// </summary>
        public void importIoList()
        {
            //Should I check for existing IO first?

            //Check that the file exists first!
            if (!File.Exists(ConfigFolder + IoListFile))
            {
                throw new ApplicationException("IO CSV file not found in selected config directory");
            }

            //Parse IO CSV file to create 2d array of data
            List<string[]> ioDataList = new List<string[]>();          
                using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(ConfigFolder + IoListFile))
                {
                    parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        ioDataList.Add(parser.ReadFields());
                    }
                }
                string[][] ioDataListArray = ioDataList.ToArray();
            
            //To create children we need to keep references to the parents to use later
            List<ITcSmTreeItem> termLevel = new List<ITcSmTreeItem>();
            //For each "row/device" in array
            for (int i = 0; i < ioDataListArray.GetLength(0); i++)
            {
                //Convert "null" strings in sub-array to null 
                for (int j = 0; j < ioDataListArray[i].GetLength(0); j++)
                {
                    if (ioDataListArray[i][j] == "null")
                    {
                        ioDataListArray[i][j] = null;
                    }
                }

                //Find our indent/Index level
                int terminalLevelIndex = Int32.Parse(ioDataListArray[i][0]);
                //If 0 index, new EtherCAT device
                if (terminalLevelIndex == 0)
                {
                    //Clear the list
                    termLevel.Clear();
                    //Create a new EtherCAT device and add to empty list
                    termLevel.Add(Io.CreateChild(ioDataListArray[i][1], Int32.Parse(ioDataListArray[i][2]), ioDataListArray[i][3], ioDataListArray[i][4]));
                }
                else
                {
                    //If we try to specify an N level device without an N-1 level device, throw exception
                    if (termLevel.Count < terminalLevelIndex)
                    {
                        throw new ApplicationException($"No Level {terminalLevelIndex - 1} device found for entry {ioDataListArray[i][1]}.");
                    }   
                    //If more list entries than our index level we need to remove list items as have lowered our index (sub level no longer needed)
                    if (termLevel.Count > terminalLevelIndex)
                    {
                        while (termLevel.Count > terminalLevelIndex)
                        {
                            try
                            {
                                termLevel.RemoveAt(terminalLevelIndex);
                            }
                            catch
                            {
                                break;
                            }
                        }
                    }
                    //If our list length is equal to index level we have a new index level so need to add this potential parent to the list
                    if (termLevel.Count == terminalLevelIndex)
                    {
                        termLevel.Add(termLevel[terminalLevelIndex - 1].CreateChild(ioDataListArray[i][1], Int32.Parse(ioDataListArray[i][2]), ioDataListArray[i][3], ioDataListArray[i][4]));
                    }                   
                    else //just add the new terminal
                    {
                        termLevel.RemoveAt(terminalLevelIndex);
                        termLevel.Add(termLevel[terminalLevelIndex - 1].CreateChild(ioDataListArray[i][1], Int32.Parse(ioDataListArray[i][2]), ioDataListArray[i][3], ioDataListArray[i][4]));
                    }
                }
            }
        }

        /// <summary>
        /// Run through all files in deviceXml folder of config folder and import
        /// </summary>
        public void importAllIoXmls()
        {
            string deviceFolder = ConfigFolder + @"\deviceXmls\";
            if (!Directory.Exists(deviceFolder))
            {
                throw new ApplicationException($"Folder not found: {deviceFolder}");
            }

            foreach (string file in Directory.GetFiles(deviceFolder))
            {
                importIoXmls(file);
            }
        }

        /// <summary>
        /// Import an xml file for an IO device
        /// </summary>
        /// <param name="xmlFile"></param>
        public void importIoXmls(string xmlFile)
        {
            if (!File.Exists(xmlFile))
            {
                throw new ApplicationException($"IO Xml file {xmlFile} could not be found.");
            }
           
            string deviceName = Path.GetFileNameWithoutExtension(xmlFile);
            ITcSmTreeItem currentIo = null;

            //Need to look for a match "somewhere"
            //Top level first
            try
            {
                currentIo = Io.LookupChild(deviceName);
            }
            catch
            {
                //do nothing
            }
            //If not found, search next level
            if (currentIo == null)
            {
                for (int i=1; i <= Io.ChildCount; i++)
                {
                    try
                    {
                        currentIo = Io.Child[i].LookupChild(deviceName);
                        if (currentIo != null)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        //do nothing, go for next run
                    }
                }
            }
            //If still not found, go for next level
            if (currentIo == null)
            {
                for (int i=1; i <= Io.ChildCount; i++)
                {
                    for (int j=1; j<=Io.Child[i].ChildCount; i++)
                    {
                        try
                        {
                            currentIo = Io.Child[i].Child[j].LookupChild(deviceName);
                            if (currentIo != null)
                            {
                                break;
                            }
                        }
                        catch
                        {
                            //do nothing, go for next run
                        }
                    }
                }
            }

            //we've looked everywhere dude
            if (currentIo==null)
            {
                throw new ApplicationException($"Could not find device {deviceName}");
            }

            XmlDocument ioXml = new XmlDocument();
            ioXml.Load(xmlFile);
            try
            {
                currentIo.ConsumeXml(ioXml.OuterXml);
            }
            catch
            {
                throw new ApplicationException($"Failed to load xml for {deviceName}");
            }
            
        }

        /// <summary>
        /// Returns the child count for top level IO
        /// </summary>
        /// <returns></returns>
        public int getIoCount()
        {
            return Io.ChildCount;
        }

        /// <summary>
        /// Delete all IO from project
        /// </summary>
        public void deleteIo()
        {
            if (getIoCount()==0)
            {
                throw new ApplicationException("Already no devices in tree");
            }
            while (getIoCount()!=0)
            {
                try
                {
                    Io.DeleteChild(Io.Child[1].Name);
                }
                catch
                {
                    throw new ApplicationException($"Unable to delete {Io.Child[1].Name}.");
                }
                
            }
        }

        /// <summary>
        /// Export all IO devices in solution to config folder
        /// </summary>
        public void exportAllIoXmls()
        {
            int tier1DeviceLayer;   //number of devices in IO tree
            int tier2CouplerLayer; //number of couplers and terminals under a device
            int tier3TerminalLayer; //number of terminals under a coupler
            ITcSmTreeItem ioName;

            tier1DeviceLayer = Io.ChildCount;
            for (int i = 1; i<=tier1DeviceLayer; i++)
            {
                ioName = Io.Child[i];
                exportIoXml(ioName);
                tier2CouplerLayer = Io.Child[i].ChildCount;

                for (int j =1; j<=tier2CouplerLayer; j++)
                {
                    ioName = Io.Child[i].Child[j];
                    exportIoXml(ioName);
                    tier3TerminalLayer = Io.Child[i].Child[j].ChildCount;
                    //Iterate here
                    
                    for (int k = 1; k<=tier3TerminalLayer; k++)
                    {
                        ioName = Io.Child[i].Child[j].Child[k];
                        exportIoXml(ioName);
                    }
                    //Then add child count to tier2
                    j += tier3TerminalLayer;
                }               
            }
        }

        /// <summary>
        /// Export an IO device XML file to the config directory
        /// </summary>
        /// <param name="ioName"></param>
        public void exportIoXml(ITcSmTreeItem ioName)
        {         
            string xmlDescription = ioName.ProduceXml();
            File.WriteAllText(ConfigFolder + @"\" + IoDirectory + @"\" + ioName.Name + @".xml", xmlDescription);
        }

        /// <summary>
        /// Export IO List to config directory
        /// </summary>
        public void exportIoList()
        {
            int tier1DeviceLayer;   //number of devices in IO tree
            int tier2CouplerLayer; //number of couplers and terminals under a device
            int tier3TerminalLayer; //number of terminals under a coupler
            ITcSmTreeItem ioName;
            List<string> ioList = new List<string>();

            tier1DeviceLayer = Io.ChildCount;
            for (int i = 1; i <= tier1DeviceLayer; i++)
            {
                ioName = Io.Child[i];
                ioList.Add(getIoData("0", ioName));
                tier2CouplerLayer = Io.Child[i].ChildCount;

                for (int j = 1; j <= tier2CouplerLayer; j++)
                {
                    ioName = Io.Child[i].Child[j];
                    ioList.Add(getIoData("1", ioName));
                    tier3TerminalLayer = Io.Child[i].Child[j].ChildCount;

                    for (int k = 1; k <= tier3TerminalLayer; k++)
                    {
                        ioName = Io.Child[i].Child[j].Child[k];
                        ioList.Add(getIoData("2", ioName));
                    }
                    //Then add child count to tier2
                    j += tier3TerminalLayer;
                }
            }
            String path = ConfigFolder + @"\ioList.csv";
            File.WriteAllLines(path, ioList.ToArray());
        }

        /// <summary>
        /// Produces a string of data for use in the IO List file
        /// </summary>
        /// <param name="tierLevel"></param>
        /// <param name="ioName"></param>
        /// <returns></returns>
        public String getIoData(String tierLevel, ITcSmTreeItem ioName)
        {
            //Need to get product revision from XML
            XmlDocument ioXml = new XmlDocument();
            ioXml.LoadXml(ioName.ProduceXml());
            String productRevision;
            String name;
            String subType;
            String strB4; //not utilised but needs to be set. Can be used to state where in tree the device should appear when created.
            String ioListString;

            name = ioName.Name;
            subType = (ioName.ItemSubType).ToString();

            var node = ioXml.SelectSingleNode("TreeItem/EtherCAT/Slave/Info/ProductRevision");
            if (node != null)
            {
                strB4 = " ";
                productRevision = node.InnerText;
            }
            else
            {
                strB4 = "null";
                productRevision = "null";
            }
            ioListString = tierLevel + "," + name + "," + subType + "," + strB4 + "," + productRevision;
            return ioListString;
        }

    }
}

