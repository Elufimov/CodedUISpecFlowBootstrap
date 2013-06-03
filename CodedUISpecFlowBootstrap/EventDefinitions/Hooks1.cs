using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

using CodedUISpecFlowBootstrap.Helpers;

namespace CodedUISpecFlowBootstrap.EventDefinitions
{
    [Binding]
    public class Hooks1
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Config.ConfigReader("config.json"); 
        }

        [BeforeScenario("CodedUI")]
        public static void CodedUIBeforeScenario()
        {            
            Playback.Initialize();        
        }

        [AfterScenario("CodedUI")]
        public static void CodedUIAfterScenario()
        {
            Playback.Cleanup();
        }
    }
}
