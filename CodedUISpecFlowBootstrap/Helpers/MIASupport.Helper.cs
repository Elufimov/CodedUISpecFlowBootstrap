using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

namespace CodedUISpecFlowBootstrap.Helpers
{
    class MIASupport
    {
        public static void AddNewInstace(string number, string name, ApplicationUnderTest app )
        {
            string key = String.Format("{0} №{1}", name, number);
            ScenarioContext.Current[key] = app;
        }

        public static ApplicationUnderTest GetInstance(string number, string name)
        {
            string key = String.Format("{0} №{1}", name, number);
            return (ApplicationUnderTest)ScenarioContext.Current[key];
        }
    }
}
