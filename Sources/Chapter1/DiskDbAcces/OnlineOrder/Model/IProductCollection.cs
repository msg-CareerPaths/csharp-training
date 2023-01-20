namespace OnlineOrder.Model
{
    public interface IProductCollection : IList<Product> 
    {
        new bool Add(Product product);
        Product Find(int id);
    }
}