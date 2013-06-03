using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUISpecFlowBootstrap.UIMaps
{
    class UIMapLoader
    {
        private static CalculatorUIMapModel _calculatorUIMapModel;

        public static CalculatorUIMapModel CalculatorUIMapModel(ApplicationUnderTest app)
        {
            _calculatorUIMapModel = new CalculatorUIMapModel(app);
            return _calculatorUIMapModel;
        }
    }
}
