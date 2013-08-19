using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Docnectify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void esegui(string cmd)
        {
            string output;
            cmd = "/C " + cmd;
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", cmd);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true; 
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);
            output = process.StandardOutput.ReadToEnd();

            Output.Text = Output.Text + output + "\r\n";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Ssid.Text.Length > 0)
            {
                if (Password.Text.Length >= 8)
                {
                    string cmd = "netsh wlan set hostednetwork mode=allow ssid=" + Ssid.Text + " key=" + Password.Text + " keyUsage=persistent";
                    esegui(cmd);
                    cmd = "netsh wlan start hostednetwork";
                    esegui(cmd);
                    Start.Enabled = false;
                    Stop.Enabled = true;
                }
                else
                    MessageBox.Show("Inserire una password di almeno 8 caratteri (oh, è colpa di windows, eh...)", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Inserire un nome per la rete", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            string cmd = "netsh wlan stop hostednetwork";
            esegui(cmd);
            cmd = "netsh wlan set hostednetwork mode=disallow";
            esegui(cmd);
            Start.Enabled = true;
            Stop.Enabled = false;
        }

        private void Pulisci_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

    }
}
