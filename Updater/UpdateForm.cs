﻿using Ionic.Zip;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdateForm : Form
    {
        string[] arg;
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
        bool errorState = false;

        string appName = "Crypto Notepad.exe";
        string zipName = "Crypto-Notepad-Update.zip";
        string updateDownloadPath = "https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/Crypto-Notepad-Update.zip";
        string releaseNotesLink = "https://github.com/Crypto-Notepad/Crypto-Notepad/wiki/Release-Notes";

        public UpdateForm(string[] args)
        {
            arg = args;
            InitializeComponent();
            releaseNotesLabel.TabStop = false;
        }

        #region ExtractZip
        public void ExtractFileToDirectory(string zipFileName, string outputDirectory)
        {
            ZipFile zip = ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            zip.ExtractAll(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
        }
        #endregion

        void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                System.Media.SystemSounds.Beep.Play();
                errorState = true;
                updateButton.Enabled = true;
                descriptionLabel.Text = "There was some errors during the update, please try again later.";
            }

            if (e.Error == null)
            {
                var pr = new Process();
                ExtractFileToDirectory(exePath + zipName, exePath);
                pr.StartInfo.FileName = exePath + appName;
                pr.Start();
                Application.Exit();
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            Text = Path.GetFileNameWithoutExtension(appName) + " Updater";
            StringBuilder sb = new StringBuilder(string.Empty);
            sb.AppendLine("1) Close "+ Path.GetFileNameWithoutExtension(appName) +" if it's running.");
            sb.AppendLine("2) Click Update button.");
            sb.AppendLine(Path.GetFileNameWithoutExtension(appName) + " will update and run automatically.");
            descriptionLabel.Text = sb.ToString();
            if (arg.Length == 0)
            {
                Close();
            }
            else if (arg[0] == "/u")
            {
                return;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            isAppRunningTimer.Stop();
            if (errorState == false)
            {
                var pr = new Process();
                updateButton.Enabled = false;
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Downloader_DownloadFileCompleted);
                webClient.DownloadFileAsync(new Uri(updateDownloadPath), exePath + zipName);
            }
            if (errorState == true)
            {
                var pr = new Process();
                pr.StartInfo.FileName = exePath + appName;
                pr.Start();
                Application.Exit();
            }
        }

        private void ReleaseNotesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(releaseNotesLink);
        }

        private void IsAppRunningTimer_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(appName));
            if (pname.Length > 0)
            {
                updateButton.Enabled = false;
            }
            else
            {
                updateButton.Enabled = true;
            }
        }
    }
}
