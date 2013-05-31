namespace CodedUISpecFlowBootstrap.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.Windows.Input;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UITest.Common.UIMap;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;

    using TechTalk.SpecFlow;

    using CodedUISpecFlowBootstrap.UIMaps;



    [Binding]
    public class StepDefinition1 : BaseStepDefinitions
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            App = ApplicationUnderTest.Launch(@"C:\Windows\System32\calc.exe");
            CalculatorUIMap = new CalculatorUIMapModel(App);
            //Console.WriteLine(CalculatorUIMap.ViewButton.ClassName);
            
            Mouse.Click(CalculatorUIMap.ViewButton);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
    }
}
