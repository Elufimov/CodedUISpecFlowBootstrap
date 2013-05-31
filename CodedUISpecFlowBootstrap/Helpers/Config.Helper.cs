using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.RepresentationModel.Serialization;
using System.Diagnostics;

namespace CodedUISpecFlowBootstrap.Helpers
{
    class Config
    {
        public static void ConfigReader(string path)
        {
            var input = new StringReader(File.ReadAllText(path));

            var deserializer = new Deserializer();
            var config = (Configg)deserializer.Deserialize(input, typeof(Configg));
            foreach (var a in config.Applications)
            {
                Trace.WriteLine(a.Name.ToString());
                Trace.WriteLine(a.Path.ToString());
            }
        }

        private class Configg
        {
            public Application[] Applications { get; set; }
        }

        private class Application

        {
            public string Name { get; set; }
            public string Path { get; set; }
        }

      

    }
}
