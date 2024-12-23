using System.ComponentModel.DataAnnotations.Schema;

namespace SpendSmart.Models
{
    public class Product
    {
        public int ID { get; set; }

        //[Column(TypeName = "decimal(20,2)")]
        public decimal Value { get; set; }

       
        public string? Description { get; set; }
    }
}
