using System.ComponentModel.DataAnnotations;

namespace Mission06_Holman.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public int? CategoryId { get; set; } // Use CategoryId, not Category

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
