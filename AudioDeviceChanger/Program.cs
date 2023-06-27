using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace AudioDeviceChanger
{

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            System.IO.DirectoryInfo appDir;
            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger"))//If the app's dir doesn't exist create it.
            {
                appDir = System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger");
                appDir.CreateSubdirectory(".\\NirCMD");
                Settings.directory = appDir;
                string[] NirCMDFiles = System.IO.Directory.GetFiles(Environment.CurrentDirectory + "\\Files\\NirCMD");
                foreach (string file in NirCMDFiles)
                {
                    System.IO.File.Copy(file, appDir.FullName + "\\NirCMD\\" + System.IO.Path.GetFileName(file));
                }
                Settings.saveToXML(appDir.FullName + "\\Settings.xml");

            }
            else { 
                appDir = System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger");
                Settings.directory = appDir;
                Settings.updateFromXML(appDir.FullName + "\\Settings.xml");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
