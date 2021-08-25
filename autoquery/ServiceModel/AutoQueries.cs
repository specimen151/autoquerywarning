using ServiceStack;
using System;

namespace autoquery.ServiceModel
{
    public class AutoQueries
    {
        [Route("/employees")]
        public class QueryEmployee : QueryDb<Employee> {
            // explicitly adding this will remove any warning about "missing property"
            // (as AutoQuery adds properties on-the-fly, properties not explicitly listed here will give a warning, which is problematic, if you follow up logs, looking for _real_ warnings/errors)
//            public DateTime? BirthDateGreaterThan { get; set; }     // no longer necessary 5.12.1 (redownload if you need to) -- fixed my @mythz
        }
    }
}
