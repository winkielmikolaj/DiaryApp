using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }

        [Required]
        public required string? Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        //datetime.now == data, ktora jest teraz podczas tworzenia
    }
}
