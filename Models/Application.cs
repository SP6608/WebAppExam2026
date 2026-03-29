using System.ComponentModel.DataAnnotations;
using WebAppAdvance.Data;

namespace WebAppAdvance.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SelectedCar { get; set; } = null!;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public AppUser? User { get; set; }
    }
}
