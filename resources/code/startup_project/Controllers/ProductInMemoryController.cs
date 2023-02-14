using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Products.Models;
using Products.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInMemoryController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductInMemoryController> _logger;

        public ProductInMemoryController(ILogger<ProductInMemoryController> logger,IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.Get();
        }
    }
}
