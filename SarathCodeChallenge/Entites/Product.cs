using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarathCodeChallenge.Entites
{
    public class Product
    {
        [Key]
        public int ProductId {  get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public User Supplier{ get; set; }
        [ForeignKey(nameof(SupplierId))]

        public int SupplierId { get; set; }

    }
}
