using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss.CrmServiceClientOpenAPI.Models
{
    public class Journey
    {
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public JourneyType JourneyType { get; set; }
    }
}
