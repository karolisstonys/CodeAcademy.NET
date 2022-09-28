using L059_MongoDB.Services;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace L059_MongoDB.Models
{
    public class Weather
    {

        [OnDeserialed]
        protected void OnDeseriazedMethod(StreamingContext context)


        [BsonElement("airTemperature")]
        [JsonIgnore]
        public AirTemperature? AirTemperature { get; set; }

        [JsonElement("airTemperature")]
        [BsonIgnore]
        public AirTemperature? AirTemperature_string { get; set; }

        [BsonElement("atmosphericPressureChange")]
        public AtmosphericPressureChange AtmosphericPressureChange { get; set; }

        [BsonElement("atmosphericPressureObservation")]
        public string? AtmosphericPressureObservation { get; set; }

        [BsonElement("callLetters")]
        public string CallLetters { get; set; }

        [BsonElement("dataSource")]
        public int DataSource { get; set; }

        [BsonElement("dewPoint")]
        [JsonConverter(typeof(MongoJsonConverter<DewPoint>))]
        public DewPoint DewPoint { get; set; }

        [BsonElement("elevation")]
        public int Elevation { get; set; }

        [BsonElement("liquidPrecipitation")]
        public LiquidPrecipitation LiquidPrecipitation { get; set; }

        [BsonElement("pastWeatherObservationManual")]
        public PastWeatherObservationManual PastWeatherObservationManual { get; set; }


        


    }
}
