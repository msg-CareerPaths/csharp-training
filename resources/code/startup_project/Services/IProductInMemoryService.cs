using Products.Models;

namespace Products.Services
{
    public interface IProductInMemoryService
    {
        IEnumerable<Product> Get();
    }
}
