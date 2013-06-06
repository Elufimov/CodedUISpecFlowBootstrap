using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

namespace CodedUISpecFlowBootstrap.EventDefinitions
{
    [Binding]
    public class CodedUISpecificHooks
    {
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
