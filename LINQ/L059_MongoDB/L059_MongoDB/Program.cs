using L059_MongoDB.Database.Repositories;
using L059_MongoDB.Models;
using Newtonsoft.Json;

namespace L059_MongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, MongoDB!");

            //var jsonFromFile = File.ReadAllText("mongo_wether.json");

            //Weather weather = JsonConvert.DeserializeObject<Weather>(jsonFromFile);

            WeatherRepository repository = new WeatherRepository();

            Console.WriteLine(repository.Count());


        }
    }
}