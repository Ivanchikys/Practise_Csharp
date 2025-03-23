using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Stage
    {
        public string Name { get; }
        public Stage(string name) => Name = name;
        public override string ToString() => $"Сцена: {Name}";
    }
}
