namespace OnlineOrder.Model
{
    public class ProductCollection : List<Product>, IProductCollection
    {
        public ProductCollection()
        {
            this.Add(new Product()
            {
                Name = "p1",
                Description = "big",
                Id = 1,
                UnitPrice = 1,
                Weight = 1
            });
            this.Add(new Product()
            {
                Name = "apple",
                Description = "big",
                Id = 2,
                UnitPrice = 4,
                Weight = 2
            });
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
