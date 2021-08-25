using ServiceStack;

namespace autoquery.ServiceModel
{
    public class AutoQueries
    {
        [Route("/employees")]
        public class QueryEmployee : QueryDb<Employee> { }
    }
}
