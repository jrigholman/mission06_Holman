using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Holman.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }  // Nullable foreign key to allow movies without categories

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }  

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }  

        public string? Notes { get; set; }

        // Navigation Property
        public Category? Category { get; set; }
    }
}
