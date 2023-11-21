using SarathCodeChallenge.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarathCodeChallenge.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
