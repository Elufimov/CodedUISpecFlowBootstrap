using Microsoft.VisualStudio.TestTools.UITesting;

using CodedUISpecFlowBootstrap.UIMaps.CalculatorClasses;
using CodedUISpecFlowBootstrap.UIMaps.ContextMenuClasses;

namespace CodedUISpecFlowBootstrap.UIMaps
{
    class UIMapLoader
    {
        private static Calculator _calculator;
        private static ContextMenu _contextMenu;

        public static Calculator Calculator
        {
            get
            {
                _calculator = new Calculator();
                return _calculator;
            }
            set { _calculator = value; }
        }

        public static ContextMenu ContextMenu
        {
            get
            {
                _contextMenu =new ContextMenu();
                return _contextMenu;
            }
            set { _contextMenu = value; }
        }
    }
}
