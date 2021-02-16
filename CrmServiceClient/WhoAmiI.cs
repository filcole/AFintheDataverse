using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using Newtonsoft.Json;

namespace pgc.CrmServiceClientDemo
{
    public static class WhoAmiI
    {
        [FunctionName(nameof(WhoAmiI))]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req,
            TraceWriter log)
        {
            var dataverseUrl = System.Environment.GetEnvironmentVariable("DataverseUrl");
            var clientId = System.Environment.GetEnvironmentVariable("ClientId");
            var clientSecret = System.Environment.GetEnvironmentVariable("ClientSecret");
            
            var client = new CrmServiceClient(new System.Uri(dataverseUrl), clientId, clientSecret, false, "");

            //// Could also use ConnectionString here
            //string connectionString = $"Url={dataverseUrl};ClientId={clientId};Secret={clientSecret};AuthType=ClientSecret";
            //var client = new CrmServiceClient(connectionString);

            if (!client.IsReady)
            {
                return req.CreateResponse(HttpStatusCode.Unauthorized, "Could not connect to the dataverse");
            };

            WhoAmIResponse whoAmIResponse = (WhoAmIResponse)client.Execute(new WhoAmIRequest());

            log.Info($"whoAmIResponse={JsonConvert.SerializeObject(whoAmIResponse)}");
            return req.CreateResponse(HttpStatusCode.OK, $"I am {whoAmIResponse.UserId}");
        }
    }
}