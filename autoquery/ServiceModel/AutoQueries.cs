using ServiceStack;
using System;

namespace autoquery.ServiceModel
{
    public class AutoQueries
    {
        [Route("/employees")]
        public class QueryEmployee : QueryDb<Employee> {
            public DateTime? BirthDate { get; set; }
        }
    }
}
