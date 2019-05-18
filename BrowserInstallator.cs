using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BrowserInstaller
{
    public class BrowserInstallator
    {
        private const string fileName = "Firefox Installer.exe", 
            downloadURL = "https://cdn.stubdownloader.services.mozilla.com/builds/firefox-stub/ru/win/2b9c6503a8447ed666d33ade9ddf20e60af36e77923a5d6cd454fc10b92372ba/Firefox%20Installer.exe";

        public BrowserInstallator() { }

        public void DownloadInstallator()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(downloadURL, fileName);
        }

        public bool InstallatorExist()
        {
            return File.Exists(fileName);
        }

        private void CloseBrowser()
        {
            Process[] processes = Process.GetProcessesByName("Firefox");
            foreach (Process process in processes)
                process.Kill();
        }

        public void ExecuteInstall()
        {
            Process installProcess = new Process();

            installProcess.StartInfo.FileName = fileName;
            installProcess.Start();
            installProcess.WaitForExit();

            CloseBrowser();
        }

        public async Task ExecuteInstallAsync()
        {
            await Task.Run(() => ExecuteInstall());
        }
    }
}
