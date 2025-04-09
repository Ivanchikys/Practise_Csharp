namespace EveningMovies.Models
{
    public class Movie
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Пожалуйста, введите название фильма")]
        public string Title { get; set; }
        public string Genre { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Пожалуйста, укажите, кто рекомендовал фильм")] 
        public string RecommendedBy { get; set; }
        public Movie()
        {
            Title = string.Empty;
            Genre = string.Empty;
            RecommendedBy = string.Empty;
        }
    }
}