using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Tooling.Connector;
using Newtonsoft.Json;
using PhoneNumbers;
using ss.CEEntityModel;

using Aliencube.AzureFunctions.Extensions.OpenApi.Core.Attributes;
using Aliencube.AzureFunctions.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;

namespace ss.CrmServiceClientOpenAPI
{
    public static class GetContacts
    {

        [FunctionName(nameof(GetContacts))]
        [OpenApiOperation(nameof(GetContacts), Summary = "Get Contacts with firstname and phone number", 
            Description = "Description goes here", Visibility = OpenApiVisibilityType.Important)]

        [OpenApiParameter("FirstName", Type = typeof(string),
            In = ParameterLocation.Query, Required = false, Visibility = OpenApiVisibilityType.Important, Explode = true,
            Summary = "First name to search", Description = "The first name of the contact to search for")]
        [OpenApiParameter("number", Type = typeof(string),
            In = ParameterLocation.Query, Required = false, Visibility = OpenApiVisibilityType.Important, Explode = true,
            Summary = "Phone number to search for", Description = "The phone number to search for")]

        [OpenApiResponseWithBody(HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<GetContactsResponse>),
            Description = "Matched contacts")]
        [OpenApiResponseWithoutBody(HttpStatusCode.NotFound, Description = "Contact not found", Summary = "Contact not found")]
        [OpenApiResponseWithBody(HttpStatusCode.BadRequest, contentType: "text/plain", bodyType: typeof(string),
            Description = "Error message if bad data provided or configuration issues")]
        [OpenApiResponseWithBody(HttpStatusCode.InternalServerError, contentType: "text/plain", bodyType: typeof(string),
            Summary = "Unexpected failure", Description = "This shouldn't happen!")]

        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // parse query parameter
            string requestedNumber = req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "number", true) == 0)
                .Value;

            string requestedFirstName = req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "firstname", true) == 0)
                .Value;

            if (requestedNumber == null || requestedFirstName == null)
            {
                return req.CreateResponse(HttpStatusCode.BadRequest, "Please supply both firstname and number");
            }

            // Connect to the dataverse
            var dataverseUrl = Environment.GetEnvironmentVariable("DataverseUrl", EnvironmentVariableTarget.Process);
            var tokenProviderConnectionString = Environment.GetEnvironmentVariable("TokenProviderConnectionString", EnvironmentVariableTarget.Process);

            var azureTokenProvider = new AzureServiceTokenProvider(tokenProviderConnectionString);

            CrmServiceClient.AuthOverrideHook = new CrmClientOverrideAuthHookWrapper(azureTokenProvider);

            var client = new CrmServiceClient(new Uri(dataverseUrl), true);

            if (!client.IsReady)
            {
                throw new Exception($"CrmService not ready! {client.LastCrmError}");
            }

            var context = new XrmServiceContext(client);

            var phoneUtil = PhoneNumberUtil.GetInstance();
            var phoneNumber = phoneUtil.Parse(requestedNumber, "GB");

            List<GetContactsResponse> response = (from c in context.ContactSet
                                                  where c.FirstName.Equals(requestedFirstName)
                                                  select new GetContactsResponse
                                                  {
                                                      ContactId = c.Id,
                                                      FullName = c.FullName,
                                                      FirstName = c.FirstName,
                                                      LastName = c.LastName,
                                                      MobilePhone = c.MobilePhone,
                                                  }).ToList();

            // Supplement the data
            foreach (var row in response)
            {
                var rowPhoneNumber = phoneUtil.Parse(row.MobilePhone, "GB");
                if (phoneUtil.IsNumberMatch(phoneNumber, rowPhoneNumber) == PhoneNumberUtil.MatchType.EXACT_MATCH)
                {
                    // Populate Journeys with static data for demo purposes
                    row.Journeys = new List<Models.Journey>();
                    row.Journeys.Add(new Models.Journey
                    {
                        From = "London",
                        To = "Glasgow",
                        JourneyType = Models.JourneyType.Train,
                        Date = new DateTime(2020, 02, 15)
                    });
                }
            }

            // Return complex object
            return (response.Count == 0)
                ? req.CreateResponse(HttpStatusCode.NotFound)
                : req.CreateResponse(HttpStatusCode.OK, response, "application/json");
        }
    }
}