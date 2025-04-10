using System.ComponentModel.DataAnnotations;

namespace EveningMovies.Models
{
    public class EveningMovie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название фильма")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Название должно содержать от 1 до 200 символов")]
        [Display(Name = "Название")]
        public string Title { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Жанр не должен превышать 200 символов")]
        [Display(Name = "Жанр(ы)")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите тег настроения")]
        [StringLength(100, ErrorMessage = "Тег настроения не должен превышать 100 символов")]
        [Display(Name = "Тег настроения")]
        public string MoodTag { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пожалуйста, укажите, кто добавил фильм")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Имя добавившего должно содержать от 1 до 100 символов")]
        [Display(Name = "Кем добавлен")]
        public string AddedBy { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [Display(Name = "Дата добавления")]
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}