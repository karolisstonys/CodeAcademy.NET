using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L059_MongoDB.Models
{
    public class PastWeatherObservationManual
    {

        [JsonProperty("atmosphericCondition")]
        public PWOMAtmosphericCondition AtmosphericCondition { get; set; }
    }
}
