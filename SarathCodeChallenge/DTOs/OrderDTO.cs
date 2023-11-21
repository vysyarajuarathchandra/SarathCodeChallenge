using SarathCodeChallenge.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarathCodeChallenge.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
       
        public int ProductId { get; set; }
        public int userId { get; set; }
    }
}
