using System;
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
            var key = String.Format("{0} №{1}", name, number);
            ScenarioContext.Current[key] = process;
        }

        public static void SetInstance(string number, string name)
        {
            var key = String.Format("{0} №{1}", name, number);
            ApplicationUnderTest.FromProcess((Process) ScenarioContext.Current[key]);
        }

        public static void KillInstance(string number, string name)
        {
            var key = String.Format("{0} №{1}", name, number);
            ApplicationUnderTest.FromProcess((Process)ScenarioContext.Current[key]).Close();            
        }

        private static Process StartProcess(string path)
        {
            var processInfo = new ProcessStartInfo();
            var fullPath = Path.GetFullPath(path);
            processInfo.FileName = fullPath;
            processInfo.WorkingDirectory = fullPath;
            Console.WriteLine(processInfo.FileName + " " + processInfo.WorkingDirectory);
            var process = Process.Start(processInfo);
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
