using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

namespace CodedUISpecFlowBootstrap.Helpers
{
    class MIASupport
    {
        public static void AddInstace(string number, string name)
        {
            var process = StartProcess(GetPathByName(name));
            string key = String.Format("{0} №{1}", name, number);
            ScenarioContext.Current[key] = process;
        }

        public static ApplicationUnderTest GetInstance(string number, string name)
        {
            string key = String.Format("{0} №{1}", name, number);
            return ApplicationUnderTest.FromProcess((Process)ScenarioContext.Current[key]);
        }

        private static Process StartProcess(string path)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            string fullPath = Path.GetFullPath(path);
            processInfo.FileName = fullPath;
            processInfo.WorkingDirectory = fullPath;
            Console.WriteLine(processInfo.FileName + " " + processInfo.WorkingDirectory);
            Process process = Process.Start(processInfo);
            return process;
        }

        private static string GetPathByName(string name)
        {
            string path = null;
            foreach (var app in Config.Configuration.Applications)
            {
                if (app.Name == name) { path = app.Path; break; }
                else { Assert.Fail(String.Format("Приложение {0} не найдено в конфиге.", name)); }
            }
            return path;
        }
    }
}
