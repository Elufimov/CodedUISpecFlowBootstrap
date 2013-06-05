using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUISpecFlowBootstrap.UIMaps
{
    public class CalculatorUIMapModel : BaseMapModel
    {
        public CalculatorUIMapModel(ApplicationUnderTest app) 
            : base(app)
        {
        }

        public WinMenuItem MenuViewButton
        {
            get
            {
                var control = new WinMenuItem(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Вид");
                return control;
            }
        }

        public WinMenuItem MenuHelpButton
        {
            get
            {
                var control = new WinMenuItem(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "MenuItem");
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Справка");
                return control;
            }
        }

        public WinMenuItem MenuEditButton
        {
            get
            {
                var control = new WinMenuItem(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "MenuItem");
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Правка");
                return control;
            }
        }


        public WinMenuItem SubMenuEngineeringButton
        {
            get
            {
                var control = new WinMenuItem(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Инженерный\tAlt+2");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "MenuItem");
                return control;
            }
        }

        public WinText ResultText
        {
            get
            {
                var control = new WinText(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Результат");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Text");
                return control;
            }
        }

        public WinButton MCButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Очистка памяти");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }

        }

        public WinButton MRButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Вызов из памяти");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton MSButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Сохранение в памяти");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton MPlusButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Добавление памяти");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton MMinusButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Вычитание памяти");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton BackspaceButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Backspace");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton CEButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Очистка записи");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton CButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Очистить");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton UnarMinusButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Унарный минус");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton SquareRootButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Квадратный корень");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton DivisionButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Деление");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton PercentButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Процент");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton MultiplicationButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Умножение");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton InverseButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Обратная величина");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton MinusButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Вычитание");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton PlusButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Сложение");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton DecimalSeparatorButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Десятичный разделитель");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton ResultButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "Равно");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton ZeroButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "0");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton OneButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "1");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton TwoButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "2");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton ThreeButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "3");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton FourButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "4");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton FiveButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "5");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton SixButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "6");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton SevenButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "7");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton EightButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "8");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public WinButton NineButton
        {
            get
            {
                var control = new WinButton(App) { TechnologyName = "MSAA" };
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, "9");
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "Button");
                return control;
            }
        }

        public string ContextMenuItemName { get; set; }

        public WinMenuItem ContextMenuItem
        {
            get
            {
                var viewButton = new WinMenuItem(App);
                viewButton.SearchProperties.Add(UITestControl.PropertyNames.Name, ContextMenuItemName);
                //viewButton.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "MenuItem");
                return viewButton;
            }
        }
    }
}
