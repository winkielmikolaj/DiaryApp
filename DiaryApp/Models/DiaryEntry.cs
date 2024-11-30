using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Title!")]
        //[StringLength(100, MinimumLength = 3, ErrorMessage ="Title must be between 3 and 100 characters")]
        public required string? Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Description!")]
        //[StringLength(400, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 400 characters")]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        //datetime.now == data, ktora jest teraz podczas tworzenia
    }
}
