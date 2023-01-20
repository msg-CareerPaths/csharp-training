using Microsoft.AspNetCore.Mvc;
using OnlineOrder.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private IDictionary<string,Location> _locations;

        private readonly ILogger<ProductController> _logger;

        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<Location> Get()
        {
           return _locations.Values.ToList<Location>();
        }

        // GET api/<LocationController>/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return _locations[name].ToString();
        }

        // POST api/<LocationController>
        [HttpPost]
        public void Post([FromBody] Location value)
        {
            _locations.Add(value.Name, value);
        }

        // PUT api/<LocationController>/5
        [HttpPut("{name}")]
        public void Put(string name,  [FromBody] Location value)
        {
            _locations[name] = value;
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            _locations.Remove(name);
        }
    }
}
