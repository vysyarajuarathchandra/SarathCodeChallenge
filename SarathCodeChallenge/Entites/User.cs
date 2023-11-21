using System.ComponentModel.DataAnnotations;

namespace SarathCodeChallenge.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string? UserName { get; set; }
        [Required]
        [StringLength(30)]
        public string?UserEmail { get; set; }
        [Required]
        [StringLength(10)]
        public string?Password { get; set; }
        public string?Role {  get; set; } 
    }
}
