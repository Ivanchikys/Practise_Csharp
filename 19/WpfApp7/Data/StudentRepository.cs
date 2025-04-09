using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeacherJournal.Models;

namespace TeacherJournal.Data
{
    public class StudentRepository
    {
        private readonly JournalContext _context;

        public StudentRepository(JournalContext context)
        {
            _context = context;
        }

        public async Task<List<StudentModel>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<StudentModel> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task AddStudentAsync(StudentModel student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStudentAsync(StudentModel student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}