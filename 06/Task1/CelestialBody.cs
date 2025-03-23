using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class CelestialBody(string name)
    {
        public string Name { get; set; } = name;
        public abstract string GetTypeName();
        public override string ToString()
        {
            return $"{Name} - {GetTypeName()}";
        }
    }
}
