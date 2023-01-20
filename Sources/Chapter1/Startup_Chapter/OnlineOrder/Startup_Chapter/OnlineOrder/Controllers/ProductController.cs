using Microsoft.AspNetCore.Mvc;
using OnlineOrder.Model;

namespace OnlineOrder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductCollection _products;

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductCollection products)
        {
            _logger = logger;
            _products = products;
          
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }




        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Product product = _products.Find(id);
            if (product == null)      return "Not Found";
            return product.ToString();
        }

       
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _products.Add(value);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            Product product = _products.Find(id);
            product.Edit(value);
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product product = _products.Find(id);
            _products.Remove(product);  
        }

        

    }
}