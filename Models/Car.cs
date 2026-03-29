using System.ComponentModel.DataAnnotations;

namespace WebAppAdvance.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string Brand { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Model { get; set; } = null!;
        [Required]
        [Range(1950,2080)]
        public int Year { get; set; }
        [Required]
        [Range(1,6)]
        public int Pasengers { get; set; }
        [Required]
        [Range(1,500)]
        public decimal PricePerDay { get; set; }


    }
}
