using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task5
{
    public class Polygon(double a, double b, double c)
    {
        public void CheckSide()
        {
            if(a == b && b == c)
                Console.WriteLine("Равносторонний");
            else Console.WriteLine("Не равносторонний");
        }
    }
}
