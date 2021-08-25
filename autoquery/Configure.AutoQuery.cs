using ServiceStack;
using System.Linq;

namespace AutoQueryBugReport
{
    public class ConfigureAutoQuery : IConfigureAppHost
    {
        public void Configure(IAppHost appHost)
        {
            var includeOnlyTables = new[] { "Employee", "EmployeeTerritory" };

            appHost.Plugins.Add(new AutoQueryFeature {
                MaxLimit = 1000,
                //IncludeTotal = true,
                //GenerateCrudServices = new GenerateCrudServices
                //{
                //    IncludeCrudOperations = new System.Collections.Generic.List<string>() { "GET" },
                //    IncludeType = type => includeOnlyTables.Contains(type.Name)
                //},
                
            });
        }
    }
}
