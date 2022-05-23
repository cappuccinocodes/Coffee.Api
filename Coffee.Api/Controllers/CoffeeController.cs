using Coffee.Api.Models;
using Coffee.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        [HttpGet(Name = "GetAllRecords")]
        public List<CoffeeRecord> Get()
        {
            return _coffeeRepository.Get();
        }
    }
}