using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BrowserInstaller
{
    public class BrowserAddon
    {
        private readonly string defaultUrl = @"https://addons.mozilla.org/ru/firefox/search/?platform=windows&q=",
            rootDirectory = Environment.CurrentDirectory;

        private string GetURLContent(string url)
        {
            string content = String.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Accept-Language", "ru-ru,ru;q=0.8,en-us;q=0.5,en;q=0.3");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            content = sr.ReadToEnd();
            sr.Close();

            return content;
        }

        private int GetPageNumber(string content)
        {
            Regex reg = new Regex(@"(?<=Страница 1 из )(\d*)");
            Match match = reg.Match(content);

            if (match.Value == String.Empty)
                return 1;

            return Int32.Parse(match.ToString());
        }

        private string GetAddonLink(string code)
        {
            Regex regex = new Regex("(?<=SearchResult-link\" href=\")(.*?)(?=\")");

            return @"https://addons.mozilla.org" + regex.Match(code).ToString();
        }

        private string GetAddonFilePath(string code)
        {
            Regex regex = new Regex("(?<=AMInstallButton-button Button--puffy\" href=\")(.*?)(?=\")");

            return regex.Match(GetURLContent(GetAddonLink(code))).ToString().Replace("?src=search", String.Empty); ;
        }

        private string GetAddonName(string code)
        {
            Regex regex = new Regex("(?<=SearchResult-name\">)(.*?)(?=</h2)");

            return regex.Match(code).ToString();
        }

        public Dictionary<string, string> GetSearchResult(string request)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string url = defaultUrl + request,
                content = GetURLContent(url),
                addonName;
            int pageCount = GetPageNumber(content);
            Regex regex;
            MatchCollection matches;


            for (int i = 1; i <= pageCount; ++i)
            {
                content = GetURLContent(url + "&page=" + i.ToString());
                regex = new Regex("(<li class=\"SearchResult)(.*?)(</li)");

                matches = regex.Matches(content);
                foreach (Match match in matches)
                {
                    addonName = GetAddonName(match.ToString());
                    if (!result.ContainsKey(addonName))
                        result.Add(addonName, GetAddonFilePath(match.ToString()));
                }
            }

            return result;
        }

        public async Task<Dictionary<string, string>> GetSearchResultAsync(string request)
        {
            return await Task.Run(() => GetSearchResult(request));
        }

        private string DoubleSlash(string path)
        {
            string result = String.Empty;
            string[] buf = rootDirectory.Split('\\');

            for (int i = 0; i < buf.Length; ++i)
                result += buf[i] + "\\\\";

            result += "OfflineAddons\\\\";

            return result;
        }

        private KeyValuePair<string, string> OfflineAddonNamePath(string line)
        {
            Regex reg = new Regex(@"(?<=\[)(.*?)(?=\])");
            MatchCollection matches = reg.Matches(line);
            string path = DoubleSlash(rootDirectory);

            if (matches.Count != 2)
                throw new WrongFileException("Ошибка в файле списка дополнений");

            

            return new KeyValuePair<string, string>(matches[0].ToString(), path + matches[1].ToString());
        }

        public Dictionary<string, string> LoadOfflineAddons()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            StreamReader sr = new StreamReader(@"OfflineAddons\AddonsList.txt", Encoding.Default);
            KeyValuePair<string, string> temp;
            string buf;

            while ((buf = sr.ReadLine()) != null)
            {
                temp = OfflineAddonNamePath(buf);
                result.Add(temp.Key, temp.Value);
            }

            sr.Close();

            return result;
        }
    }
}
