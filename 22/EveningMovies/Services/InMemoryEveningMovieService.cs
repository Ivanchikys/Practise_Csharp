using EveningMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveningMovies.Services
{
    public class InMemoryEveningMovieService : IEveningMovieService
    {
        private static List<EveningMovieViewModel> _movies = new List<EveningMovieViewModel>
        {
            new EveningMovieViewModel { Title = "Начало", Genre = "Научная фантастика, Триллер", StartTime = new TimeOnly(20, 00), RecommendedBy = "ElgodBro" },
            new EveningMovieViewModel { Title = "Голяк", Genre = "Повседневность, Драма, Комедия", StartTime = new TimeOnly(21, 30), RecommendedBy = "Pan_yanok" },
            new EveningMovieViewModel { Title = "Паразиты", Genre = "Триллер, Драма, Комедия", StartTime = new TimeOnly(19, 00), RecommendedBy = "ElgodBro" },
            new EveningMovieViewModel { Title = "Зеленая книга", Genre = "Драма, Комедия, Биография", StartTime = new TimeOnly(20, 30), RecommendedBy = "Evrej" },
            new EveningMovieViewModel { Title = "Контратака", Genre = "Боевик", StartTime = new TimeOnly(22, 00), RecommendedBy = "Pan_yanok" }
        };
        public Task<IEnumerable<EveningMovieViewModel>> GetAllMoviesAsync()
        {
            return Task.FromResult(_movies.ToList().AsEnumerable());
        }

        public Task<IEnumerable<EveningMovieViewModel>> GetMoviesByGenreAsync(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return Task.FromResult(Enumerable.Empty<EveningMovieViewModel>());
            }

            var filteredMovies = _movies
                .Where(m => m.Genre != null &&
                            m.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Task.FromResult(filteredMovies.AsEnumerable());
        }

        public Task AddMovieAsync(EveningMovieViewModel movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }
            _movies.Add(movie); 
            return Task.CompletedTask;
        }
    }
}