using Coffee.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {

        public CoffeeController()
        {
           
        }

        [HttpGet(Name = "GetAllRecords")]
        public List<CoffeeRecord> Get()
        {
            return new List<CoffeeRecord>();
        }
    }
}