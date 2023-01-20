namespace OnlineOrder.Model
{
    public class Revenue
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public DateTime LocalDate { get; set; }
        public decimal Sum { get; set; }
    }
}
