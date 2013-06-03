
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
    using CodedUISpecFlowBootstrap.Helpers;


namespace CodedUISpecFlowBootstrap.StepDefinitions
{
    [Binding]
    public class StepDefinition
    {

        [When(@"In '(.*)' №'(.*)' I open View menu")]
        public void WhenInIOpenViewMenu(string name, string number)
        {
            var app = Helpers.MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Mouse.Click(calc.ViewButton);
        }

        [When(@"In '(.*)' №'(.*)' I open Help menu")]
        public void WhenInIOpenHelpMenu(string name, string number)
        {
            var app = Helpers.MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Mouse.Click(calc.HelpButton);
        }

        [When(@"In '(.*)' №'(.*)' I click on EngineeringButton")]
        public void WhenInIClickOnEngineeringButton(string name, string number)
        {
            var app = Helpers.MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Mouse.Click(calc.EngineeringButton);
        }

        [Then(@"Wait (.*)")]
        public void ThenWait(int p0)
        {
            Playback.Wait(p0);
        }


    }
}
