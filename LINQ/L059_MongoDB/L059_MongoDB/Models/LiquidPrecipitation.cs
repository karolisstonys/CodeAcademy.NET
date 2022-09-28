using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L059_MongoDB.Models
{
    public class LiquidPrecipitation
    {

        [JsonProperty("period")]
        public LPPeriod Period { get; set; }

        [JsonProperty("depth")]
        public LPDepth Depth { get; set; }

        [JsonProperty("condition")]
        public LPCondition Condition { get; set; }
    }
}
