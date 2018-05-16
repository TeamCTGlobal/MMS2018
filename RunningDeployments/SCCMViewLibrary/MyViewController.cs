
using Microsoft.ConfigurationManagement.AdminConsole.Views.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace SCCMViewLibrary
{
    public class MyViewController : OverviewControllerBase
    {
        public MyViewController() : base() { }
        public override void EndInit() {

            base.EndInit();

            //Get from main folder
            try
            {
                string configPath = AppDomain.CurrentDomain.BaseDirectory + "SCCMRunningDeployments.json";

                if (File.Exists(configPath))
                {
                    string json = File.ReadAllText(configPath);
                    Configuration config = JsonConvert.DeserializeObject<Configuration>(json);
                    string url = config.TargetURL;

                    var browser = new WebBrowser();

                    browser.Navigate(url);

                    Content = browser;

                }
                else
                {
                    Content = new Label() { Content = "URL to Configuration: " + configPath + "could not be found" };
                }

            }
            catch(Exception ex)
            {
                Content = new Label() { Content = "Error: " + ex.InnerException };
            }
            
            //string url = Properties.Resources.ViewNodeURL;
            
           
            

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
