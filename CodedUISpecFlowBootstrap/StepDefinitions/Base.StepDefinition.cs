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


namespace CodedUISpecFlowBootstrap.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions
    {
        private const string CurrentPageKey = "Current.UIMap";
        public static ApplicationUnderTest App { get; set; }

        protected CalculatorUIMapModel CalculatorUIMap
        {
            get { return (CalculatorUIMapModel)ScenarioContext.Current[CurrentPageKey]; }
            set { ScenarioContext.Current[CurrentPageKey] = value; }
        }
    }
}
