using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUISpecFlowBootstrap.UIMaps
{
    public class ContextMenuUIMapModel : BaseMapModel
    {
        public ContextMenuUIMapModel(ApplicationUnderTest app)
            : base(app)
        {
        }

        public string ContextMenuItemName { get; set; }

        public WinMenuItem ContextMenuItem
        {
            get
            {
                var control = new WinMenuItem(UITestControl.Desktop);
                control.SearchProperties.Add(UITestControl.PropertyNames.Name, ContextMenuItemName);
                control.SearchProperties.Add(UITestControl.PropertyNames.ControlType, "MenuItem");
                return control;
            }
        }
    }
}
