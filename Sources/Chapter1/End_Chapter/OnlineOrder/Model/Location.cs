using System.Text.Json;

namespace OnlineOrder.Model
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressCountry { get; set; }
        public string AddressCity { get; set; }
        public string AddressCounty { get; set; }
        public string AddressStreet { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
