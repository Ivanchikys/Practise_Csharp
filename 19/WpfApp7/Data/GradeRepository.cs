using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherJournal.Models;

namespace TeacherJournal.Data
{
    public class GradeRepository
    {
        private readonly JournalContext _context;

        public GradeRepository(JournalContext context)
        {
            _context = context;
        }

        public async Task<List<GradeModel>> GetAllGradesAsync()
        {
            return await _context.Grades
                .Include(g => g.Enrollment)
                .ThenInclude(e => e.Student)
                .ToListAsync();
        }

        public async Task<GradeModel> GetGradeByIdAsync(int id)
        {
            return await _context.Grades
                .Include(g => g.Enrollment)
                .ThenInclude(e => e.Student)
                .FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<List<GradeModel>> GetGradesByEnrollmentIdAsync(int enrollmentId)
        {
            return await _context.Grades
                .Where(g => g.EnrollmentId == enrollmentId)
                .Include(g => g.Enrollment)
                .ThenInclude(e => e.Student)
                .ToListAsync();
        }

        public async Task AddGradeAsync(GradeModel grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGradeAsync(GradeModel grade)
        {
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGradeAsync(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade != null)
            {
                _context.Grades.Remove(grade);
                await _context.SaveChangesAsync();
            }
        }
    }
}