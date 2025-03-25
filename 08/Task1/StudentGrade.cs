using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudentGrade
    {
        public static double CalculateAverage(List<int> grades)
        {
            if (grades == null || grades.Count == 0)
                throw new ArgumentException("Список оценок не может быть пустым.");
            foreach (var grade in grades)
            {
                if (grade < 0 || grade > 100)
                {
                    throw new InvalidGradeException($"Некорректная оценка: {grade}");
                }
            }
            return grades.Average();
        }
    }
}
