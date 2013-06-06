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
    }
}
