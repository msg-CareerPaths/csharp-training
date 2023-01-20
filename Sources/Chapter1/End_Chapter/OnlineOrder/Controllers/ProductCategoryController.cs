using Microsoft.AspNetCore.Mvc;
using OnlineOrder.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {

        private IDictionary<string, ProductCategory> _category;

        private readonly ILogger<ProductController> _logger;
        public ProductCategoryController(IDictionary<string, ProductCategory> category,ILogger<ProductController> logger)
        {
            _category = category;
            _logger = logger;
        }
        // GET: api/<ProductCategoryController>
        [HttpGet]
        public IEnumerable<ProductCategory> Get()
        {
            return _category.Values.ToList<ProductCategory>();
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return _category[name].ToString();
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public void Post([FromBody] ProductCategory value)
        {
            _category.Add(value.Name,value);
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut("{name}")]
        public void Put(string name, [FromBody] ProductCategory value)
        {
            _category[name]=value;
        }

        // DELETE api/<ProductCategoryController>/5
        [HttpDelete("{name}")]
        public void Delete(int name)
        {
        }
    }
}
