using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EveningMovies.Data;
using EveningMovies.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic; 

namespace EveningMovies.Controllers
{
    public class EveningMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EveningMoviesController> _logger;

        public EveningMoviesController(ApplicationDbContext context, ILogger<EveningMoviesController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string? moodTag) 
        {
            ViewBag.CurrentFilter = moodTag; 

            IQueryable<EveningMovie> moviesQuery = _context.EveningMovies.AsQueryable();

            if (!string.IsNullOrEmpty(moodTag))
            {
                moviesQuery = moviesQuery.Where(m => m.MoodTag.ToLower() == moodTag.ToLower());
            }

            ViewBag.MoodTags = await _context.EveningMovies
                                       .Select(m => m.MoodTag)
                                       .Distinct()
                                       .OrderBy(tag => tag)
                                       .ToListAsync();

            var movies = await moviesQuery.OrderByDescending(m => m.DateAdded).ToListAsync();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new EveningMovie());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Title,Genre,MoodTag,AddedBy")] EveningMovie eveningMovie) 
        {
            if (eveningMovie == null)
            {
                return BadRequest("Invalid movie data.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    eveningMovie.DateAdded = DateTime.UtcNow;
                    _context.Add(eveningMovie);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation("Фильм '{MovieTitle}' успешно добавлен.", eveningMovie.Title);
                    TempData["SuccessMessage"] = $"Фильм '{eveningMovie.Title}' успешно добавлен!";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(ex, "Ошибка при сохранении фильма в БД: {MovieTitle}", eveningMovie.Title);
                    ModelState.AddModelError("", "Не удалось сохранить фильм. Попробуйте еще раз.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Непредвиденная ошибка при добавлении фильма: {MovieTitle}", eveningMovie.Title);
                    ModelState.AddModelError("", "Произошла непредвиденная ошибка при добавлении фильма.");
                }
            }
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                _logger.LogWarning("Ошибка валидации при добавлении фильма: {ValidationErrors}", string.Join(", ", errors));
            }
            ViewBag.ErrorMessage = "Пожалуйста, исправьте ошибки в форме.";
            return View(eveningMovie);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eveningMovie = await _context.EveningMovies
                .FirstOrDefaultAsync(m => m.Id == id);

            if (eveningMovie == null)
            {
                _logger.LogWarning("Попытка удаления несуществующего фильма с ID: {MovieId}", id);
                TempData["ErrorMessage"] = "Фильм для удаления не найден.";
                return RedirectToAction(nameof(Index));
            }

            return View(eveningMovie); 
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eveningMovie = await _context.EveningMovies.FindAsync(id);
            if (eveningMovie == null)
            {
                _logger.LogWarning("Попытка подтверждения удаления несуществующего фильма с ID: {MovieId}", id);
                TempData["ErrorMessage"] = "Фильм для удаления не найден.";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                string deletedTitle = eveningMovie.Title;
                _context.EveningMovies.Remove(eveningMovie);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Фильм '{MovieTitle}' (ID: {MovieId}) успешно удален.", deletedTitle, id);
                TempData["SuccessMessage"] = $"Фильм '{deletedTitle}' успешно удален.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Ошибка при удалении фильма из БД: {MovieId}", id);
                TempData["ErrorMessage"] = "Не удалось удалить фильм. Возможно, он связан с другими данными.";
                return RedirectToAction(nameof(Delete), new { id = id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Непредвиденная ошибка при удалении фильма: {MovieId}", id);
                TempData["ErrorMessage"] = "Произошла непредвиденная ошибка при удалении фильма.";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}