using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class FunctionTabulation
    {
        private double A, B, H;
        private int M;

        public FunctionTabulation(double a, double b, int m)
        {
            if (a >= b || m <= 0)
                Console.WriteLine("Ошибка: A должно быть меньше B, и M должно быть положительным числом."); 
            A = a;
            B = b;
            M = m;
            H = (B - A) / M;
        }

        public void Tabulate()
        {
            Console.WriteLine("Табуляция функции F(x) = cos(1/x) на отрезке [{0}, {1}]:", A, B);
            Console.WriteLine(" x      |  F(x) = cos(1/x) ");
            Console.WriteLine("---------------------------");

            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double fx = Math.Cos(1 / x);
                Console.WriteLine("{0:F4}  |  {1:F4}", x, fx);
            }
        }
    }
}
