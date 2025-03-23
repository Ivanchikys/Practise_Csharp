using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class CoughSyrup : Medicine, ILiquidMedicine
    {
        public CoughSyrup(string name) : base(name) { }
        public void Drink() => Console.WriteLine($"Выпить сироп {Name}");
    }
}
