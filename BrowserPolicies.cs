using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserInstaller
{
    public class BrowserPolicies
    {
        private readonly string distributionPath = @"C:\Program Files\Mozilla Firefox\distribution",
            policiesFileName = "policies.json",
            policiesFilePath = @"C:\Program Files\Mozilla Firefox\distribution\policies.json";

        private string InitPolicies()
        {
            return "{\r\n  \"policies\": {\r\n";
        }

        private string FinishPolicies()
        {
            return "\r\n  }\r\n}";
        }

        private string GetPoliciesData(List<IBrowserPolicy> policies)
        {
            string result = InitPolicies();

            foreach (IBrowserPolicy policy in policies)
                result += "    " + policy.GetPolicyString() + ",\r\n";

            result = result.Remove(result.Length - 3);

            result += FinishPolicies();

            return result;
        }

        private void CreatePoliciesFile(List<IBrowserPolicy> policies)
        {
            StreamWriter sw = new StreamWriter("policies.json");
            sw.Write(GetPoliciesData(policies));
            sw.Close();
        }

        private void CreateDistributionDir()
        {
            if (!Directory.Exists(distributionPath))
                Directory.CreateDirectory(distributionPath);
        }

        private void AddPoliciesFile()
        {
            if (File.Exists(policiesFilePath))
                File.Delete(policiesFilePath);

            FileInfo fn = new FileInfo(policiesFileName);
            fn.CopyTo(policiesFilePath);
        }

        public bool PolicyFileExist()
        {
            return File.Exists(policiesFileName);
        }

        public void ApplyPolicies(List<IBrowserPolicy> policies, bool configAlreadyExists)
        {
            if (!configAlreadyExists)
                CreatePoliciesFile(policies);

            CreateDistributionDir();
            AddPoliciesFile();
        }      
    }
}
