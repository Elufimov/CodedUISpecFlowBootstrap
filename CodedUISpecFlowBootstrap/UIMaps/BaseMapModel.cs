using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUISpecFlowBootstrap.UIMaps
{

    public class BaseMapModel
    {
        protected BaseMapModel(ApplicationUnderTest application)
        {
            App = application;
        }

        public ApplicationUnderTest App { get; set; }
    }
}
