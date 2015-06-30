using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    using TechTalk.SpecFlow;

    [Binding]
    public class Class1
    {
        [BeforeScenario("InitiativeExport")]
        public void InitializeInitiativeExport()
        {
            Console.WriteLine("InitiativeExport");
        }

        [BeforeScenario("TargetExport")]
        public void InitializeTargetExport()
        {
            Console.WriteLine("TargetExport");
            
        }

        [BeforeScenario("TargetExportConnections")]
        public void InitializeConnectionsExport()
        {
            Console.WriteLine("TargetExportConnections");
        }
    }
}
