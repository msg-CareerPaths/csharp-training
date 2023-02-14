using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Products.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public decimal Weight { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
