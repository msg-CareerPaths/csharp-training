using Products.Models;

namespace Products.Services
{
    public interface IProductService
    {
        IEnumerable<Product> Get();
    }
}
