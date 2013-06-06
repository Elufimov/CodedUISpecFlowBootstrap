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
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            var characters = value.ToCharArray();
            foreach (var a in characters)
            {
                switch (a)
                {
                    case '0':
                        Mouse.Click(calc.UICalculatorWindow.UIZeroButtonControl.UIZeroButton);
                        break;
                    case '1':
                        Mouse.Click(calc.UICalculatorWindow.UIOneButtonControl.UIOneButton);
                        break;
                    case '2':
                        Mouse.Click(calc.UICalculatorWindow.UITwoButtonControl.UITwoButton);
                        break;
                    case '3':
                        Mouse.Click(calc.UICalculatorWindow.UIThreeButtonControl.UIThreeButton);
                        break;
                    case '4':
                        Mouse.Click(calc.UICalculatorWindow.UIFourButtonControl.UIFourButton);
                        break;
                    case '5':
                        Mouse.Click(calc.UICalculatorWindow.UIFiveButtonControl.UIFiveButton);
                        break;
                    case '6':
                        Mouse.Click(calc.UICalculatorWindow.UISixButtonControl.UISixButton);
                        break;
                    case '7':
                        Mouse.Click(calc.UICalculatorWindow.UISevenButtonControl.UISevenButton);
                        break;
                    case '8':
                        Mouse.Click(calc.UICalculatorWindow.UIEightButtonControl.UIEightButton);
                        break;
                    case '9':
                        Mouse.Click(calc.UICalculatorWindow.UINineButtonControl.UINineButton);
                        break;
                    default:
                        Assert.Fail(String.Format("Символ {0} содержит недопустимые символы.", a));
                        break;
                }
            }
        }

        [Given(@"In №'(.*)' of '(.*)' I press add")]
        public void GivenInOfIPressAdd(string number, string name)
        {
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            Mouse.Click(calc.UICalculatorWindow.UIPlusButtonControl.UIPlusButton);
        }

        [When(@"In №'(.*)' of '(.*)' I press result")]
        public void WhenInOfIPressResult(string number, string name)
        {
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            Mouse.Click(calc.UICalculatorWindow.UIResultButtonControl.UIResultButton);
        }

        [Then(@"In №'(.*)' of '(.*)'the result should be '(.*)' on the screen")]
        public void ThenInOfTheResultShouldBeOnTheScreen(string number, string name, string result)
        {
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            Assert.AreEqual(result, calc.UICalculatorWindow.UIResultTextControl.UIResultText.DisplayText);
        }

        [Given(@"In №'(.*)' of '(.*)' I copy result to clipboard")]
        public void GivenInOfICopyResultToClipboard(string number, string name)
        {
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            var contextMenu = UIMapLoader.ContextMenu;
            Mouse.Click(calc.UICalculatorWindow.UIResultTextControl.UIResultText, MouseButtons.Right);
            Mouse.Click(contextMenu.UIContextMenuWindow.UIContextMenu.UICopyMenuItem);
        }

        [Given(@"In №'(.*)' of '(.*)' I insert value from clipboard")]
        public void GivenInOfIInsertValueFromClipboard(string number, string name)
        {
            MIASupport.SetInstance(number, name);
            var calc = UIMapLoader.Calculator;
            var contextMenu = UIMapLoader.ContextMenu;
            Mouse.Click(calc.UICalculatorWindow.UIResultTextControl.UIResultText, MouseButtons.Right);
            Mouse.Click(contextMenu.UIContextMenuWindow.UIContextMenu.UIPasteMenuItem);
        }

    }
}
