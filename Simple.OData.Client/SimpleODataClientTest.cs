using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Simple.OData.Client;

namespace ss.SimpleODataClientTest
{
    public static class SimpleODataClientTest
    {
        [FunctionName(nameof(SimpleODataClientTest))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Reference:
            // https://medium.com/capgemini-microsoft-team/access-tokens-for-dynamics-365-using-microsoft-authentication-library-2b16c9f794b
            // https://nishantrana.me/page/5/?eid=3797
            // https://github.com/simple-odata-client/Simple.OData.Client/wiki/Retrieving-data-matching-search-criteria

            var dataverseUrl = "https://ss2021pc.api.crm11.dynamics.com/api/data/v9.2/";
            var clientId = System.Environment.GetEnvironmentVariable("ClientId");
            var clientSecret = System.Environment.GetEnvironmentVariable("ClientSecret");
            string[] scope = new string[] { "https://ss2021pc.crm11.dynamics.com/.default" };
            string tenantId = "bc3febfa-48fd-4f72-9785-e28fa857658d";
            string authority = $"https://login.microsoftonline.com/{tenantId}";

            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                                .WithClientSecret(clientSecret)
                                .WithAuthority(new Uri(authority))
                                .Build();

            IConfidentialClientApplication app;
            app = ConfidentialClientApplicationBuilder.Create(clientId)
                                          .WithClientSecret(clientSecret)
                                          .WithAuthority(new Uri(authority))
                                          .Build();

            AuthenticationResult authResult = await clientApp.AcquireTokenForClient(scope).ExecuteAsync();

            var settings = new ODataClientSettings(new Uri(dataverseUrl));
            settings.BeforeRequest += delegate (HttpRequestMessage message)
            {
                // Probably should refresh token here
                message.Headers.Add("Authorization", "Bearer " + authResult.AccessToken);
            };

            var client = new ODataClient(settings);

            // Get fullname of contacts with firstname = Robert
            var contacts = await client
                .FindEntriesAsync("contacts?$select=contactid,fullname&$filter=firstname like 'Robert'");

            var numContacts = 0;
            foreach (var contact in contacts)
            {
                log.LogInformation("Id=" + contact["contactid"] + "  Fullname=" + contact["fullname"]);
                numContacts++;
            }

            string responseMessage = $"Found {numContacts} contacts";

            return new OkObjectResult(responseMessage);
        }
    }
}