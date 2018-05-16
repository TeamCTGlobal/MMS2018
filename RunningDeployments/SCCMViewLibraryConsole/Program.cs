using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCMViewLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentFolder = AppDomain.CurrentDomain.BaseDirectory;

            
            string configPath = currentFolder + "SCCMRunningDeployments2.json";
            Console.WriteLine(configPath);

            if (File.Exists(configPath))
            {
                string json = File.ReadAllText(configPath);
                Configuration config = JsonConvert.DeserializeObject<Configuration>(json);
                Console.WriteLine("URL: " + config.TargetURL);

            }
            
           
            
            Console.ReadLine();

            
        }
    }

    class Configuration
    {
        /// <summary>
        /// Target URL
        /// </summary>
        [JsonProperty("TargetURL")]
        public string TargetURL { get; set; }
    }
}
