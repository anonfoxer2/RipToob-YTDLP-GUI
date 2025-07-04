﻿using System;
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
        // Stores the yt-dlp arguments selected by the user based on format selection
        private string downloadArgs = "";

        public Form1()
        {
            InitializeComponent();
        }

        /* -------ASYNC PROCESS EXECUTION-------*/
        //This creates a method we can call at any time to run yt-dlp.exe. We use it to be able to stream live console output to the app.
        // Asynchronously runs a process (yt-dlp.exe) with live output streamed to the UI
        private async Task RunYtDlpProcessAsync(string exePath, string arguments)
        {
            // Create a ProcessStartInfo object to configure how the external process runs
            var processInfo = new ProcessStartInfo
            {
                FileName = exePath,                  // Path to the yt-dlp.exe executable
                Arguments = arguments,               // Command-line arguments (e.g., "-U" or download options)
                RedirectStandardOutput = true,       // Capture standard output stream
                RedirectStandardError = true,        // Capture error output stream
                UseShellExecute = false,             // Required to redirect streams
                CreateNoWindow = true                // Hide the external console window
            };

            using (var process = new Process())
            {
                process.StartInfo = processInfo;

                // Attach event handlers to capture output as it's written
                process.OutputDataReceived += (s, e) => AppendOutput(e.Data); // For standard output
                process.ErrorDataReceived += (s, e) => AppendOutput(e.Data);  // For error output

                process.Start();                    // Start the process
                process.BeginOutputReadLine();      // Begin reading output stream asynchronously
                process.BeginErrorReadLine();       // Begin reading error stream asynchronously

                // Wait for the process to exit asynchronously so the UI stays responsive
                await Task.Run(() => process.WaitForExit());
            }
        }

        // Safely appends text to the RichTextBox output window from any thread
        private void AppendOutput(string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            // Check if we're on the UI thread; if not, marshal the update to the UI thread
            if (outputBox.InvokeRequired)
            {
                outputBox.Invoke(new Action(() => outputBox.AppendText(text + Environment.NewLine)));
            }
            else
            {
                outputBox.AppendText(text + Environment.NewLine);
            }
        }

        /* -------EVENT HANDLERS------- */

        // Event handler when the WAV radio button is selected
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (fileWav.Checked)
            {
                // Set yt-dlp args for downloading and extracting WAV audio
                downloadArgs = "-x --audio-format=wav {0}";
            }
        }

        // Event handler when the MP3 radio button is selected
        private void fileMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (fileMp3.Checked)
            {
                // Set yt-dlp args for downloading and extracting mp3 audio 
                downloadArgs = "-x --audio-format=mp3 {0}";
            }
        }

        // Event handler when the MP4 radio button is selected
        private void fileMp4_CheckedChanged(object sender, EventArgs e)
        {
            if (fileMp4.Checked)
            {
                // Set yt-dlp args for downloading best resolution and converting to MP4 format
                downloadArgs = "-S res,ext:mp4:m4a --recode mp4 {0}";
            }
        }

        /* -------DOWNLOAD HANDLERS------- */
        private async void downLoadButton_Click(object sender, EventArgs e)
        {
            // Clear any previous output from the RichTextBox
            outputBox.Clear();

            // Get the trimmed video URL from the textbox
            string url = linkText.Text.Trim();

            // Validate input: URL must not be empty
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a YouTube video URL.");
                return;
            }

            // Validate format selection: must choose WAV, MP3, or MP4
            if (string.IsNullOrWhiteSpace(downloadArgs))
            {
                MessageBox.Show("Please select an option.");
                return;
            }

            // Get the full path to yt-dlp.exe in the application's directory
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yt-dlp.exe");

            // Verify yt-dlp.exe exists
            if (!File.Exists(exePath))
            {
                MessageBox.Show("yt-dlp.exe not found in application directory.");
                return;
            }

            try
            {
                // Inform the user in the output window that an update is starting
                AppendOutput("RipToob > Updating yt-dlp...");
                await RunYtDlpProcessAsync(exePath, "-U"); // Run yt-dlp.exe -U with live output

                // Inform the user the download is starting
                AppendOutput("RipToob > Starting download...");

                // Format the yt-dlp command with the selected options and video URL
                string arguments = string.Format(downloadArgs, url);

                // Start the actual download process with live output
                await RunYtDlpProcessAsync(exePath, arguments);

                // Final confirmation message
                AppendOutput("RipToob > Operation successful.");
            }
            catch (Exception ex)
            {
                // Show a message box if something goes wrong (e.g., process fails)
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
