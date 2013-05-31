using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UITesting;

using TechTalk.SpecFlow;

namespace CodedUISpecFlowBootstrap.StepDefinitions
{
    [Binding]
    public class Hooks1 :BaseStepDefinitions
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("CodedUI")]
        public static void SpecflowBeforeTestRun()
        {            
            Playback.Initialize();
        }

        [AfterScenario("CodedUI")]
        public static void SpecflowAfterTestRun()
        {
            Playback.Cleanup();
        }
    }
}
