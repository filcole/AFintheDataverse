using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Crm.Sdk.Messages;
using Newtonsoft.Json;
using System.Diagnostics;
using System;

namespace pgc.CrmServiceClientDemo
{
    public static class WhoAmiI
    {
        [FunctionName(nameof(WhoAmiI))]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var dataverseUrl = System.Environment.GetEnvironmentVariable("DataverseUrl");
            var clientId = System.Environment.GetEnvironmentVariable("ClientId");
            var clientSecret = System.Environment.GetEnvironmentVariable("ClientSecret");

            log.Info($"dataverseUrl={dataverseUrl}   clientId={clientId}   clientSecret={clientSecret}");
            var client = new CrmServiceClient(new System.Uri(dataverseUrl), clientId, clientSecret, false, "");

            if (!client.IsReady)
            {
                return req.CreateResponse(HttpStatusCode.Unauthorized, "Could not connect to the dataverse");
            };

            WhoAmIResponse whoAmIResponse = (WhoAmIResponse)client.Execute(new WhoAmIRequest());

            stopWatch.Stop();
            log.Info($"whoAmIResponse={JsonConvert.SerializeObject(whoAmIResponse)}");

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            log.Info("RunTime " + elapsedTime);

            return req.CreateResponse(HttpStatusCode.OK, $"I am {whoAmIResponse.UserId}");
        }
    }
}
