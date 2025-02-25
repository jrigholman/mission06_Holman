using System.ComponentModel.DataAnnotations;

namespace Mission06_Holman.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;

        // Navigation Property
        public List<Movie>? Movies { get; set; }
    }
}
