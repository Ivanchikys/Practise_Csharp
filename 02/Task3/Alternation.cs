using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Alternation(byte n)
    {
        public void Result()
        {
            StringBuilder sb = new StringBuilder();

            double result = 0;
            byte power = 2;
            for (double i = 1.1; i <= n; i += 0.1)
            {
                double power2 = i * Math.Pow((-1), power);
                result += power2;
                sb.Append(power2 > 0 ? " + " : " - ").Append($"{i:F1}");
                power++;
            }
            sb.Remove(0, 3);
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"{result:F4}");
        }
    }
}
