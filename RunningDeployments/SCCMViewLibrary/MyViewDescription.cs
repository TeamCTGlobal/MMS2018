using Microsoft.ConfigurationManagement.AdminConsole;
using Microsoft.ConfigurationManagement.AdminConsole.Schema;
using Microsoft.EnterpriseManagement.UI.WpfViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SCCMViewLibrary
{
    public class MyViewDescription : IConsoleView2
    {
        
        public Type TypeOfViewController { get { return typeof(MyViewController); } }
        public Type TypeOfView { get { return typeof(Overview); } }

        public bool TryConfigure(ref XmlElement persistedConfigurationData) { return false; }
        new public bool TryInitialize(ScopeNode scopeNode, AssemblyDescription resourceAssembly, ViewAssemblyDescription viewAssemblyDescription) { return true; }
    }
}
