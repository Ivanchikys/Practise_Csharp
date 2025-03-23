using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Asteroid : CelestialBody
    {
        public Asteroid(string name) : base(name) { }
        public override string GetTypeName() => "Астероид";
    }
}
