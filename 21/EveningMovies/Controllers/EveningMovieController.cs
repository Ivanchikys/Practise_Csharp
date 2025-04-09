using Microsoft.AspNetCore.Mvc;
using EveningMovies.Models;
using EveningMovies.Services;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace EveningMovies.Controllers
{
    public class EveningMovieController : Controller
    {
        private readonly IEveningMovieService _movieService;

        public EveningMovieController(IEveningMovieService movieService)
        {
            _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.PageMessage = "Добро пожаловать в список фильмов на вечер!";
            var allMovies = await _movieService.GetAllMoviesAsync();
            return View(allMovies);
        }

        [HttpGet("EveningMovie/ByGenre/{genre}")]
        public async Task<IActionResult> ByGenre(string genre)
        {
            var genreMovies = await _movieService.GetMoviesByGenreAsync(genre);
            ViewBag.GenreName = genre;
            ViewBag.PageMessage = $"Фильмы в жанре: {genre}";
            return View(genreMovies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new EveningMovieViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(EveningMovieViewModel movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _movieService.AddMovieAsync(movie);
                    TempData["SuccessMessage"] = $"Фильи '{movie.Title}' успешно добавлен!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка добавления фильма: {ex.Message}");
                    ModelState.AddModelError("", "Произошла ошибка при добавлении фильма.");
                }
            }
            ViewBag.ErrorMessage = "Пожалуйста, исправьте ошибки в форме.";
            return View(movie);
        }
        [HttpGet("EveningMovie/ByRecommender/{name}")]
        public async Task<IActionResult> ByRecommender(string name)
        {
            var allMovies = await _movieService.GetAllMoviesAsync();
            var friendMovies = allMovies
                .Where(m => m.RecommendedBy.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            ViewBag.RecommenderName = name; 
            ViewBag.PageMessage = $"Фильмы, рекомендованные {name}";
            return View(friendMovies);
        }
    }
}