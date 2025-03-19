using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class EvenNumbersFinder
    {
        private int A, B, X, Y;

        public EvenNumbersFinder(int a, int b, int x, int y)
        {
            if (a > b)
                Console.WriteLine("Ошибка: A должно быть меньше или равно B.");
            A = a;
            B = b;
            X = x;
            Y = y;
        }

        private bool IsValidNumber(int num)
        {
            return num % 2 == 0 && (num % 10 == X || num % 10 == Y);
        }

        public void PrintUsingWhile()
        {
            Console.WriteLine("\nИспользуем while:");
            int num = B;
            while (num >= A)
            {
                if (IsValidNumber(num))
                    Console.Write(num + " ");
                num--;
            }
            Console.WriteLine();
        }

        public void PrintUsingDoWhile()
        {
            Console.WriteLine("\nИспользуем do while:");
            int num = B;
            do
            {
                if (IsValidNumber(num))
                    Console.Write(num + " ");
                num--;
            } while (num >= A);
            Console.WriteLine();
        }

        public void PrintUsingFor()
        {
            Console.WriteLine("\nИспользуем for:");
            for (int num = B; num >= A; num--)
            {
                if (IsValidNumber(num))
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
