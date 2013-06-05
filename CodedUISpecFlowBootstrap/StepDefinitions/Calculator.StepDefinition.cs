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
        [Given(@"In №'(.*)' of '(.*)' I have entered '(.*)' into the calculator")]
        [When(@"In №'(.*)' of '(.*)' I have entered '(.*)' into the calculator")]
        public void WhenInIOpenViewMenu(string number, string name, string value)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            var characters = value.ToCharArray();
            foreach (var a in characters)
            { 
                if (a == '0') { Mouse.Click(calc.ZeroButton); }
                if (a == '1') { Mouse.Click(calc.OneButton); }
                if (a == '2') { Mouse.Click(calc.TwoButton); }
                if (a == '3') { Mouse.Click(calc.ThreeButton); }
                if (a == '4') { Mouse.Click(calc.FourButton); }
                if (a == '5') { Mouse.Click(calc.FiveButton); }
                if (a == '6') { Mouse.Click(calc.SixButton); }
                if (a == '7') { Mouse.Click(calc.SevenButton); }
                if (a == '8') { Mouse.Click(calc.EightButton); }
                if (a == '9') { Mouse.Click(calc.NineButton); }
                //else {Assert.Fail(String.Format("Символ {0} содержит недопустимые символы.", a));}
            }
        }

        [Given(@"In №'(.*)' of '(.*)' I press add")]
        public void GivenInOfIPressAdd(string number, string name)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Mouse.Click(calc.PlusButton);
        }

        [When(@"In №'(.*)' of '(.*)' I press result")]
        public void WhenInOfIPressResult(string number, string name)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Mouse.Click(calc.ResultButton);
        }

        [Then(@"In №'(.*)' of '(.*)'the result should be '(.*)' on the screen")]
        public void ThenInOfTheResultShouldBeOnTheScreen(string number, string name, string result)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            Assert.AreEqual(result, calc.ResultText.DisplayText);
        }

        [Given(@"In №'(.*)' of '(.*)' I copy result to clipboard")]
        public void GivenInOfICopyResultToClipboard(string number, string name)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);
            var contextMenu = UIMapLoader.ContextMenuUIMapModel(app);
            contextMenu.ContextMenuItemName = "Копировать";
            Mouse.Click(calc.ResultText, MouseButtons.Right);
            Mouse.Click(contextMenu.ContextMenuItem);
        }

        [Given(@"In №'(.*)' of '(.*)' I insert value from clipboard")]
        public void GivenInOfIInsertValueFromClipboard(string number, string name)
        {
            var app = MIASupport.GetInstance(number, name);
            var calc = UIMapLoader.CalculatorUIMapModel(app);                     
            Mouse.Click(calc.ResultText, MouseButtons.Right);
            var contextMenu = UIMapLoader.ContextMenuUIMapModel(app);
            contextMenu.ContextMenuItemName = "Вставить";
            Mouse.Click(contextMenu.ContextMenuItem);
        }

    }
}
