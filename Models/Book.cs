using System.ComponentModel.DataAnnotations;

namespace LMSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Category { get; set; } = string.Empty;

        public int PublishedYear { get; set; }

        public bool IsAvailable { get; set; } = true;

        [Range(0, 9999)]
        public int TotalCopies { get; set; }

        [Range(0, 9999)]
        public int AvailableCopies { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [StringLength(300)]
        public string? CoverImageUrl { get; set; }
    }
}