using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserInstaller
{
    public interface IBrowserPolicy
    {
        string GetPolicyString();
    }

    // запрет на доступ к about:addons
    public class BlockAboutAddons : IBrowserPolicy
    {
        private bool value;

        public BlockAboutAddons(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"BlockAboutAddons\": " + value.ToString().ToLowerInvariant();
        }
    }

    // запрет на доступ к about:config
    public class BlockAboutConfig : IBrowserPolicy
    {
        private bool value;

        public BlockAboutConfig(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"BlockAboutConfig\": " + value.ToString().ToLowerInvariant();
        }
    }

    // запрет на доступ к about:profiles
    public class BlockAboutProfiles : IBrowserPolicy
    {
        private bool value;

        public BlockAboutProfiles(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"BlockAboutProfiles\": " + value.ToString().ToLowerInvariant();
        }
    }

    // запрет на доступ к about:support
    public class BlockAboutSupport : IBrowserPolicy
    {
        private bool value;

        public BlockAboutSupport(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"BlockAboutSupport\": " + value.ToString().ToLowerInvariant();
        }
    }

    // настройка обновления браузера
    public class DisableAppUpdate : IBrowserPolicy
    {
        private bool value;

        public DisableAppUpdate(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"DisableAppUpdate\": " + value.ToString().ToLowerInvariant();
        }
    }

    // настройка отправки телеметрии
    public class DisableTelemetry : IBrowserPolicy
    {
        private bool value;

        public DisableTelemetry(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"DisableTelemetry\": " + value.ToString().ToLowerInvariant();
        }
    }

    // настройка предложения сохранения паролей и логинов
    public class OfferToSaveLogins : IBrowserPolicy
    {
        private bool value;

        public OfferToSaveLogins(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"OfferToSaveLogins\": " + value.ToString().ToLowerInvariant();
        }
    }

    // настройка режима инкогнито
    public class DisablePrivateBrowsing : IBrowserPolicy
    {
        private bool value;

        public DisablePrivateBrowsing(bool value)
        {
            this.value = value;
        }

        public string GetPolicyString()
        {
            return "\"DisablePrivateBrowsing\": " + value.ToString().ToLowerInvariant();
        }
    }

    // установка расширений
    public class Extensions : IBrowserPolicy
    {
        private List<string> sources;

        public Extensions(List<string> sources)
        {
            this.sources = new List<string>();
            foreach (string temp in sources)
                this.sources.Add("\"" + temp + "\"");
        }


        private string GetSourcesString()
        {
            string result = String.Empty;

            foreach (string temp in sources)
                result += temp + ",";

            result = result.Remove(result.Length - 1);

            return result;
        }

        public string GetPolicyString()
        {
            return "\"Extensions\": {\r\n      " +
                "\"Install\": [" + GetSourcesString() + "]\r\n    }";
        }
    }

    // настройка прокси
    public class Proxy : IBrowserPolicy
    {
        private string mode, ip, port;
        private bool locked, useForAll;

        public Proxy(string mode, string ip, string port, bool locked, bool useForAll)
        {
            this.mode = "\"" + mode + "\"";
            this.ip = "\"" + ip + ":";
            this.port = port + "\"";
            this.locked = locked;
            this.useForAll = useForAll;
        }
        public string GetPolicyString()
        {
            return "\"Proxy\": {\r\n      \"Mode\":" + mode +
                ",\r\n        \"Locked\":" + locked.ToString().ToLowerInvariant() +
                ",\r\n        \"HTTPProxy\":" + ip + port +
                ",\r\n        \"UseHTTPProxyForAllProtocols\":" + useForAll.ToString().ToLowerInvariant() +
                "\r\n    }";
        }
    }
}
