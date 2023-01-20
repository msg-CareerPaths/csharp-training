namespace OnlineOrder.Model
{
    public class OrderDetail
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
