using Products.Controllers;
using Products.Models;
using System.Collections.Concurrent;

namespace Products.Services
{
    public class ProductInMemoryService : IProductService
    {
        private List<Product> _products = new();
        private readonly ILogger<IProductService> _logger;

        public ProductInMemoryService(ILogger<IProductService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
