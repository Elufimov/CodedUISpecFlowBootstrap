using System.Diagnostics;
using CodedUISpecFlowBootstrap.UIMaps;
using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

using CodedUISpecFlowBootstrap.Helpers;

namespace CodedUISpecFlowBootstrap.EventDefinitions
{
    [Binding]
    public class GlobalHooks
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
