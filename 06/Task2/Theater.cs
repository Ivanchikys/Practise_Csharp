using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Theater(string name, string stageName, List<Actor> actors)
    {
        public string Name { get; set; } = name;
        public Stage Stage { get; } = new Stage(stageName);
        public List<Actor> Actors { get; } = actors;
        public List<Audience> Audiences { get; } = new List<Audience>();
        public void AddAudience(Audience audience)
        {
            Audiences.Add(audience);
        }

        public void PerformPlay()
        {
            Console.WriteLine($"{Name} представляет спектакль на {Stage}!");
            Console.WriteLine("Актеры:");
            foreach (var actor in Actors)
            {
                Console.WriteLine($" - {actor}");
            }
            Console.WriteLine($"Зрителей: {Audiences.Count}\n");
        }
    }

}
