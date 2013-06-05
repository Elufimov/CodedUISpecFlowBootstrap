using System.IO;

using Newtonsoft.Json;

namespace CodedUISpecFlowBootstrap.Helpers
{
    public class Config
    {
        public static ConfigObject Configuration { get; set; }
        
        public static void ConfigReader(string path)
        {
            Configuration = JsonConvert.DeserializeObject<ConfigObject>(File.ReadAllText(path)); 
        }

        public class ConfigObject
        {
            public Application[] Applications { get; set; }
        }

        public class Application
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
    }
}
