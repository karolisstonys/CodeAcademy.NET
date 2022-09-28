using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L059_MongoDB.Models
{
    public class AtmosphericPressureChange
    {
        [JsonProperty("atmosphericPressureChange")]
        public APCTendency Tendency { get; set; }
    }
}
