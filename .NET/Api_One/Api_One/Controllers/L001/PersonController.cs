using Api_One.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_One.Controllers.L001
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person { Id = 1, Name = "Petras", Surmane = "Petraitis" },
                new Person { Id = 2, Name = "Jonas", Surmane = "Jonaitis" },
                new Person { Id = 3, Name = "Tomas", Surmane = "Tomaitis" }
            };
        }
    }
}
