using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FunctionY(double x)
    {
        public double y = 0;

        public void Calculator()
        {
            if (x > 6.7)
            {
                 y = 4 - Math.Exp(4 * x);

            }
            else if (x <= 6.7)
            {
                y = Math.Log10(3.5 + x);
            }
        }
    }
}
