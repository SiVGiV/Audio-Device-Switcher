using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioDeviceChanger
{
    public partial class MainWindow : Form
    {
        private bool headphones = !Settings.defaultDevice.ToLower().Equals("headphones");
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            changeDevice(null, null);
            notifyIcon.Visible = true;
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            updateInputs();
        }
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                this.Visible = false;
            }
        }
        
        private void changeDevice(object sender, EventArgs e)
        {
            this.headphones = !this.headphones;
            if (this.headphones)
            {
                notifyIcon.Icon = new Icon(Environment.CurrentDirectory + "/Files/headphone.ico");
                notifyIcon.Text = "Headphones";
                for (int i = 0; i < 3; i++)
                {
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.headphones + "\" 0");
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.headphones + "\" 1");
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.headphones + "\" 2");
                }
                

            }
            else
            {
                notifyIcon.Icon = new Icon(Environment.CurrentDirectory + "/Files/speaker.ico");
                notifyIcon.Text = "Speakers";
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.speakers + "\" 0");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.speakers + "\" 1");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AudioDeviceChanger\\NirCMD\\nircmd.exe", "setdefaultsounddevice \"" + Settings.speakers + "\" 2");

            }

        }
        private void openApp(object sender, EventArgs e)
        {
            changeDevice(null, null);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void onChangeDefault(object sender, EventArgs e)
        {
            if (this.defaultHeadphones.Checked)
                Settings.defaultDevice = "headphones";
            else Settings.defaultDevice = "speakers";
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Settings.updateSettings(this.headphonesBox.Text, this.speakersBox.Text, this.defaultHeadphones.Checked);
        }
        private void updateInputs()
        {
            this.headphonesBox.Text = Settings.headphones;
            this.speakersBox.Text = Settings.speakers;
            this.defaultHeadphones.Checked = Settings.defaultDevice.Equals("headphones");
            this.defaultSpeakers.Checked = Settings.defaultDevice.Equals("speakers");
        }
    }
}
