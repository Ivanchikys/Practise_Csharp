using EveningMovies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EveningMovies.Services
{
    public interface IEveningMovieService
    {
        Task<IEnumerable<EveningMovieViewModel>> GetAllMoviesAsync();
        Task<IEnumerable<EveningMovieViewModel>> GetMoviesByGenreAsync(string genre);
        Task AddMovieAsync(EveningMovieViewModel movie);
        
    }
}