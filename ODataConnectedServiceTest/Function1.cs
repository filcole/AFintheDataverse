using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace ODataConnectedServiceTest
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            var serviceRoot = "https://ss2021pc.crm11.dynamics.com/api/data/v9.2";
            var context = new Microsoft.Dynamics.CRM.System(new Uri(serviceRoot));

            var contacts = (from c in context.contacts
                            where c.firstname.StartsWith("Rob")
                            select new { c.fullname })
                            .Take(10).AsEnumerable();

            return req.CreateResponse(HttpStatusCode.OK, "Hello " + String.Join(", ", contacts));
        }

        static string GetToken()
        {
            // Use ADAL to get token
            return "xxxxx";
        }
    }
}
