using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserInstaller
{
    public partial class mainFrom : Form
    {
        private BrowserInstallator browserInstallator;
        private BrowserAddon browserAddon;
        private Dictionary<string, string> possibleAddons, addonsToInstall;
        private BrowserPolicies policies;
                
        public mainFrom()
        {
            InitializeComponent();
            policies = new BrowserPolicies();
            addonsToInstall = new Dictionary<string, string>();
            possibleAddons = new Dictionary<string, string>();
            browserInstallator = new BrowserInstallator();
            browserAddon = new BrowserAddon();
            EnabledProxy(false);
            offlineButton.Checked = true;
        }

        private void DisableAllSettings(bool flag)
        {
            settingsBox.Enabled = !flag;
            proxyBox.Enabled = !flag;
            addonsBox.Enabled = !flag;
            possibleAddonsListBox.Visible = !flag;
            addonsToInstallListbox.Visible = !flag;
        }

        private bool CheckIP(List<string> ipBytes)
        {
            int temp;
            foreach (string ipByte in ipBytes)
            {
                if (!Int32.TryParse(ipByte, out temp))
                    return false;

                if ((temp < 0) || (temp > 255))
                    return false;
            }

            return true;
        }

        private bool CheckPort(string port)
        {
            int temp;

            if (!Int32.TryParse(port, out temp))
                return false;

            if ((temp < 0) || (temp > 65535))
                return false;

            return true;
        }

        private bool CheckProxyPing(List<string> ipBytes)
        {
            string ip = ipBytes[0] + "." + ipBytes[1] + "." + ipBytes[2] + "." + ipBytes[3];

            return (new Ping().Send(ip).Status.ToString() == "TimedOut") ? false : true;
        }

        private bool CheckInputData()
        {
            if (enableProxyCheckBox.Checked)
            {
                if (!CheckIP(new List<string> { ipProxy1.Text, ipProxy2.Text, ipProxy3.Text, ipProxy4.Text }))
                {
                    MessageBox.Show("Некорректный IP-адрес");
                    return false;
                }

                if (!CheckPort(portProxy.Text))
                {
                    MessageBox.Show("Некорректный порт");
                    return false;
                }

                if (!CheckProxyPing(new List<string> { ipProxy1.Text, ipProxy2.Text, ipProxy3.Text, ipProxy4.Text }))
                {
                    MessageBox.Show("Прокси-сервер недоступен");
                    return false;
                }
            }

            return true;
        }

        private string GetProxyIP()
        {
            return ipProxy1.Text + "." + ipProxy2.Text + "." +
                ipProxy3.Text + "." + ipProxy4.Text;
        }

        private List<string> GetAddonsSources()
        {
            List<string> result = new List<string>();

            foreach (KeyValuePair<string, string> addon in addonsToInstall)
                result.Add(addon.Value);

            return result;
        }

        private List<IBrowserPolicy> CollectPolicies()
        {
            List<IBrowserPolicy> result = new List<IBrowserPolicy>();

            result.Add(new BlockAboutAddons(aboutAddonsCheckBox.Checked));
            result.Add(new BlockAboutConfig(aboutConfigCheckBox.Checked));
            result.Add(new BlockAboutProfiles(aboutProfilesCheckBox.Checked));
            result.Add(new BlockAboutSupport(aboutSupportCheckBox.Checked));
            result.Add(new DisableAppUpdate(updateAppCheckBox.Checked));
            result.Add(new DisableTelemetry(telemetryCheckBox.Checked));
            result.Add(new DisablePrivateBrowsing(privateModeCheckBox.Checked));
            result.Add(new OfferToSaveLogins(!savePasswordsCheckBox.Checked));

            if (enableProxyCheckBox.Checked)
            {
                result.Add(new Proxy("manual", GetProxyIP(),
                    portProxy.Text, lockedProxyCheckBox.Checked, true));
            }

            if (addonsToInstall.Count > 0)
                result.Add(new Extensions(GetAddonsSources()));

            return result;
        }

        private void ClearAddons()
        {
            possibleAddonsListBox.Items.Clear();
            possibleAddons.Clear();
            //addonsToInstallListbox.Items.Clear();
            //addonsToInstall.Clear();
        }

        private void EnabledOnlineAddons(bool flag)
        {
            searchAddonTextBox.Enabled = flag;
            searchAddonButton.Enabled = flag;
            ClearAddons();
        }

        private void ControlsInSearching(bool flag)
        {
            searchAddonButton.Enabled = !flag;
            offlineButton.Enabled = !flag;
            onlineButton.Enabled = !flag;
        }

        private void EnabledProxy(bool flag)
        {
            lockedProxyCheckBox.Enabled = flag;
            ipProxyLabel.Enabled = flag;
            portProxyLabel.Enabled = flag;
            ipProxy1.Enabled = flag;
            ipProxy2.Enabled = flag;
            ipProxy3.Enabled = flag;
            ipProxy4.Enabled = flag;
            portProxy.Enabled = flag;
        }

        private void ShowPossibleAddons()
        {
            possibleAddonsListBox.Items.Clear();

            foreach (KeyValuePair<string, string> pair in possibleAddons)
                possibleAddonsListBox.Items.Add(pair.Key);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadButton.Enabled = false;
            browserInstallator.DownloadInstallator();
            downloadButton.Enabled = true;
            MessageBox.Show("Скачано");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enableProxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EnabledProxy(enableProxyCheckBox.Checked);
        }

        private void possibleAddonsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = possibleAddonsListBox.IndexFromPoint(new Point(e.X, e.Y));
            if ((index >= 0) && (index < 65535) && (e.Clicks == 2))
            {
                string item = possibleAddonsListBox.SelectedItem.ToString();
                if (!addonsToInstallListbox.Items.Contains(item))
                {
                    addonsToInstallListbox.Items.Add(item);
                    addonsToInstall.Add(item, possibleAddons[item]);
                }
            }
        }

        private void possibleAddonsListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(possibleAddonsListBox.Items[e.Index].ToString(),
                possibleAddonsListBox.Font,
                possibleAddonsListBox.Width).Height;
        }

        private void possibleAddonsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (possibleAddonsListBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(possibleAddonsListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void addonsToInstallListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(addonsToInstallListbox.Items[e.Index].ToString(),
                addonsToInstallListbox.Font,
                addonsToInstallListbox.Width).Height;
        }

        private void addonsToInstallListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (addonsToInstallListbox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(addonsToInstallListbox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void addonsToInstallListbox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = addonsToInstallListbox.IndexFromPoint(new Point(e.X, e.Y));

            if ((index >= 0) && (index < 65535) && (e.Clicks == 2))
            {
                string item = addonsToInstallListbox.SelectedItem.ToString();
                addonsToInstall.Remove(item);
                addonsToInstallListbox.Items.Remove(item);
            }
        }

        private void offlineButton_CheckedChanged(object sender, EventArgs e)
        {
            if (offlineButton.Checked)
            {
                EnabledOnlineAddons(false);
                possibleAddons = browserAddon.LoadOfflineAddons();
                ShowPossibleAddons();
            }
        }

        private void onlineButton_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineButton.Checked)
                EnabledOnlineAddons(true);
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            installButton.Enabled = false;

            if (!browserInstallator.InstallatorExist())
            {
                MessageBox.Show("Инсталлятор не найден. Скачайте или перенесите его в папку с программой");
                installButton.Enabled = true;
                return;
            }

            if (!policies.PolicyFileExist() && configAlreadyExists.Checked)
            {
                MessageBox.Show("Файл конфигураций не найден");
                installButton.Enabled = true;
                return;
            }

            if (CheckInputData())
            {
                var awaiter = browserInstallator.ExecuteInstallAsync().GetAwaiter();
                awaiter.OnCompleted(() =>
                {
                    policies.ApplyPolicies(CollectPolicies(), configAlreadyExists.Checked);
                    installButton.Enabled = true;
                });              
            }
            else
                installButton.Enabled = true;
        }

        private void configAlreadyExists_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllSettings(configAlreadyExists.Checked);
        }

        private void searchAddonButton_Click(object sender, EventArgs e)
        {
            if (searchAddonTextBox.TextLength != 0)
            {
                ControlsInSearching(true);
                var awaiter = browserAddon.GetSearchResultAsync(searchAddonTextBox.Text).GetAwaiter();

                awaiter.OnCompleted(() =>
                {
                    possibleAddons = awaiter.GetResult();
                    ShowPossibleAddons();
                    ControlsInSearching(false);
                });
            }
            else
                MessageBox.Show("Введите запрос");            
        }
    }
}
