using System;
using System.ComponentModel.DataAnnotations;
namespace EveningMovies.Models
{
    public class EveningMovieViewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите название фильма")]
        [Display(Name = "Название")] 
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Жанр(ы)")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите время начала")]
        [DataType(DataType.Time)]
        [Display(Name = "Время начала")]
        public TimeOnly StartTime { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, кто рекомендовал фильм")]
        [Display(Name = "Кем рекомендован")]
        public string RecommendedBy { get; set; } = string.Empty;
    }
}