using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     public class Calculator(double x, double y)
    {
        public double X = x;
        public double Y = y;
        public double Sum()
        {
            return x + y;
        }

        public double Difference()
        {
            return x - y;
        }

        public double Multiply()
        {
            return x * y;
        }

        public double Divide()
        {
            return x / y;
        }
        
    }
}
