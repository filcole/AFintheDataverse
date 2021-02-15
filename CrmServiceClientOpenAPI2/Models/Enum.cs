using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ss.CrmServiceClientOpenAPI.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JourneyType
    {
        Train = 10,
        Bus = 20,
        Car = 30,
        Walk = 40,
    }
}
