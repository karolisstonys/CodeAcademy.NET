using MongoDB.Bson;
using MongoDB.Driver;
using P059_MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L059_MongoDB.Database.Repositories
{
    public class WeatherRepository
    {
        private readonly IMongoCollection<BsonDocument> _collection;
        private readonly IMongoCollection<WeatherData> _obj_collection;

        public WeatherRepository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var sample_weather = client.GetDatabase("sample_weather");

            _collection = sample_weather.GetCollection<BsonDocument>("WeatherData");
            _obj_collection = sample_weather.GetCollection<WeatherData>("WeatherData");

        }

        public long Count()
        {
            return _collection.CountDocuments(new BsonDocument());
        }


        public long CountObj()
        {
            return _obj_collection.AsQueryable().Count();
        }











    }
}
