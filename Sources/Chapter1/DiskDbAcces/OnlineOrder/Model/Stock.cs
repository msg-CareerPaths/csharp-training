namespace OnlineOrder.Model
{
    public class Stock
    {
        public Product Product { get; set; }
        public Location Location { get; set; }
        public int Quantity { get; set; }
    }
}
