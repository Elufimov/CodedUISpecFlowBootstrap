using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

using System.Diagnostics;

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Utilities;

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
