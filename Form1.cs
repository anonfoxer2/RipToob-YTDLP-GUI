using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RipTube_YTDLP_GUI
{
    public partial class Form1 : Form
    {
        private string downloadArgs = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (fileWav.Checked)
            {
                 downloadArgs = "-x --audio-format=wav {0}";
            }
        }

        private void fileMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (fileMp3.Checked)
            {
                downloadArgs = "-x --audio-format=wav {0}";
            }
        }

        private void fileMp4_CheckedChanged(object sender, EventArgs e)
        {
            if (fileMp4.Checked)
            {
                downloadArgs = "-S res,ext:mp4:m4a --recode mp4 {0}";
            }
        }

        private void downLoadButton_Click(object sender, EventArgs e)
        {
            string url = linkText.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a YouTube video URL.");
                return;
            }

            if (string.IsNullOrWhiteSpace(downloadArgs))
            {
                MessageBox.Show("Please select an option.");
                return;
            }

            string arguments = string.Format(downloadArgs, url);
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yt-dlp.exe");

            if (!File.Exists(exePath))
            {
                MessageBox.Show("yt-dlp.exe not found in application directory.");
                return;
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    MessageBox.Show(output + "\n" + error, "yt-dlp Output");
                    MessageBox.Show("RipToob > Operation successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing yt-dlp: " + ex.Message);
            }
        }
    }
}
