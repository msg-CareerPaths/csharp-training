using Products.Controllers;
using Products.Models;
using System.Collections.Concurrent;

namespace Products.Services
{
    public class ProductInMemoryService : IProductInMemoryService
    {
        private List<Product> _products;
        private readonly ILogger<IProductInMemoryService> _logger;

        public ProductInMemoryService(ILogger<IProductInMemoryService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
