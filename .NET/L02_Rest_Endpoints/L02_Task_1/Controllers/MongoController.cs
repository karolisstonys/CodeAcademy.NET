using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace L02_Task_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MongoController : ControllerBase
    {
        [HttpGet("TestGet")]
        [EnableCors("corsforfood")]
        public List<string> TestGet()
        {
            var res = new List<string>();

            MongoClient dbClient = new MongoClient("...");

            var dbList = dbClient.ListDatabases().ToList();

            foreach (var db in dbList)
            {
                res.Add(db.ToString());
            }

            return res;
        }
    }
}
