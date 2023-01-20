namespace OnlineOrder.Model
{
    public class ProductCollection : List<Product>, IProductCollection
    {
        public ProductCollection()
        {
        }

        public new bool Add(Product product)
        {
            // check for duplicates 
            base.Add(product);

            return true;//  this.Add(product);  
        }


        public Product Find(int id)
        {
            foreach (Product product in this)
            {
                if (product.Id == id) return product;
            }
            return null;
        }
    }
}
