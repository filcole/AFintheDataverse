using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ss.CrmServiceClientOpenAPI.Models;

namespace ss.CrmServiceClientOpenAPI
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class GetContactsResponse
    {
        public Guid ContactId { get; set; }
        public string FullName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public List<Journey> Journeys { get; set; }
    }
}
