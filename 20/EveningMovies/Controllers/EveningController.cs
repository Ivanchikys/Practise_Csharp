using Microsoft.AspNetCore.Mvc;
using EveningMovies.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EveningMovies.Controllers
{
    public class EveningController : Controller
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Title = "Начало", Genre = "Научная фантастика, Триллер", RecommendedBy = "ElgodBro" },
            new Movie { Title = "Голяк", Genre = "Повседневность, Драма, Комедия", RecommendedBy = "Pan_yanok" },
            new Movie { Title = "Паразиты", Genre = "Триллер, Драма, Комедия", RecommendedBy = "ElgodBro" },
            new Movie { Title = "Зеленая книга", Genre = "Драма, Комедия, Биография", RecommendedBy = "Evrej" },
            new Movie { Title = "Контратака", Genre = "Боевик", RecommendedBy = "Pan_yanok" }
        };

        [HttpGet]
        public IActionResult Index()
        {
            var allMovies = _movies.ToList(); 
            return View(allMovies);
        }

        [HttpGet("Evening/ByFriend/{name}")] 
        public IActionResult ByFriend(string name)
        {
            var friendMovies = _movies
                .Where(m => m.RecommendedBy.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
            ViewBag.FriendName = name;
            return View(friendMovies);
        }
 
        [HttpGet]
        public IActionResult Suggest()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Suggest(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movies.Add(movie);
                return RedirectToAction("Index", "Evening");
            }

            return View(movie);
        }
    }
}