using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class ProductCalculator
    {
        private int A, B;
        public ProductCalculator(int a, int b)
        {
            if (a < 1 || b < 1 || a >= b || a > 10 || b > 10)
                Console.WriteLine("Ошибка: A и B должны быть целыми числами от 1 до 10, и A < B.");
            A = a;
            B = b;
        }
        public int CalculateProduct()
        {
            int product = 1;
            for (int i = A; i <= B; i++)
            { product *= i;}
            return product;
        }
    }
}
