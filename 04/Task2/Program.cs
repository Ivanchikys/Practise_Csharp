/*Создайте static классы, которые выполняют различные операции с массивами объектов, 
 * включая сортировку, фильтрацию, вычисление статистики и генерацию данных.
*/
/*Реализовать метод CountPeopleInCity, который подсчитывает количество людей в каждом городе.*/
using Task2;

List<Person> people = PeopleAnalytics.GenerateRandomPeople(10);

Console.WriteLine("Generated People:");
foreach (var person in people)
{
    Console.WriteLine($"Name: {person.Name}, City: {person.City}");
}

var sortedPeople = PeopleAnalytics.SortPeopleByName(people);
Console.WriteLine("\nSorted People by Name:");
foreach (var person in sortedPeople)
{
    Console.WriteLine($"Name: {person.Name}, City: {person.City}");
}

var cityCounts = PeopleAnalytics.CountPeopleInCity(people);
Console.WriteLine("\nPeople Count per City:");
foreach (var city in cityCounts)
{
    Console.WriteLine($"City: {city.Key}, Count: {city.Value}");
}

Console.WriteLine($"\nAverage People per City: {PeopleAnalytics.AveragePeoplePerCity(people):F2}");