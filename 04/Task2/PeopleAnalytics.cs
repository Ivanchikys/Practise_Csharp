using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте static классы, которые выполняют различные операции с массивами объектов, 
 * включая сортировку, фильтрацию, вычисление статистики и генерацию данных.
*/
/*Реализовать метод CountPeopleInCity, который подсчитывает количество людей в каждом городе.*/
namespace Task2
{
    public static class PeopleAnalytics
    {
        public static Dictionary<string, int> CountPeopleInCity(List<Person> people)
        {
            if (people == null || people.Count == 0)
                return new Dictionary<string, int>();

            return people.GroupBy(p => p.City)
                         .ToDictionary(g => g.Key, g => g.Count());
        }

        public static List<Person> SortPeopleByName(List<Person> people)
        {
            return people.OrderBy(p => p.Name).ToList();
        }

        public static List<Person> FilterPeopleByCity(List<Person> people, string city)
        {
            return people.Where(p => p.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static double AveragePeoplePerCity(List<Person> people)
        {
            if (people == null || people.Count == 0)
                return 0;

            var cityCounts = CountPeopleInCity(people);
            return cityCounts.Values.Average();
        }

        public static List<Person> GenerateRandomPeople(int count)
        {
            string[] names = { "Alice", "Alpha", "Charlie", "Vano", "Masho", "Pavlo", "Kirillo" };
            string[] cities = { "Grodno", "Minsk", "Mogilyv", "Brest", "Vitebsk" };
            return Enumerable.Range(1, count)
                             .Select(_ => new Person(names[Random.Shared.Next(names.Length)], cities[Random.Shared.Next(cities.Length)]))
                             .ToList();
        }
    }
}
