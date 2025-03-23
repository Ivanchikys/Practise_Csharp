using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Antibiotic : Medicine, IPill
    {
        public Antibiotic(string name) : base(name) { }
        public void TakePill() => Console.WriteLine($"Принять таблетку {Name}");
    }
}
