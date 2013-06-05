using TechTalk.SpecFlow;

using CodedUISpecFlowBootstrap.Helpers;

namespace CodedUISpecFlowBootstrap.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions
    {
        [Given(@"I start instance №'(.*)' of '(.*)'")]
        public void GivenIStartInstance(string number, string name)
        {
            MIASupport.AddInstace(number, name);
        }

        [Given(@"I close instance №'(.*)' of '(.*)'")]
        public void GivenICloseInstanceOf(string number, string name)
        {
            MIASupport.KillInstance(number, name);
        }

    }
}
