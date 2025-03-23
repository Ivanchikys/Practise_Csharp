using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Planet : CelestialBody
    {
        public Planet(string name) : base(name) { }
        public override string GetTypeName() => "Планета";
    }
}
