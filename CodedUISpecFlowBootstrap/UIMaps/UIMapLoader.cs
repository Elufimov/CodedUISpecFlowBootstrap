using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUISpecFlowBootstrap.UIMaps
{
    class UIMapLoader
    {
        private static CalculatorUIMapModel _calculatorUIMapModel;
        private static ContextMenuUIMapModel _contextMenuUIMapModel;

        public static CalculatorUIMapModel CalculatorUIMapModel(ApplicationUnderTest app)
        {
            _calculatorUIMapModel = new CalculatorUIMapModel(app);
            return _calculatorUIMapModel;
        }

        public static ContextMenuUIMapModel ContextMenuUIMapModel(ApplicationUnderTest app)
        {
            _contextMenuUIMapModel = new ContextMenuUIMapModel(app);
            return _contextMenuUIMapModel;
        }
    }
}
