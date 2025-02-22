using System.ComponentModel.DataAnnotations;

namespace Mission06_Holman.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown: G, PG, PG-13, R

        public bool Edited { get; set; } = false; // Default to false


        public string? LentTo { get; set; } // Optional

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional (Max 25 characters)
    }
}
