using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AppServiceTokenStore
{
    public static class WhoAmI
    {
        [FunctionName("WhoAmI")]
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, string cdsToken, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cdsToken);
            return await client.GetAsync("https://ss2021pc.crm11.dynamics.com/api/data/v9.1/WhoAmI");
        }
    }
        
    // …with a corresponding function.json file entry:
    // {
    //       "name": "cdsToken",
    //       "type": "token",
    //       "direction": "in",
    //       "resource": "https://ss2021pc.crm11.dynamics.com",
    //       "identity": "userFromRequest"
    // }
}
