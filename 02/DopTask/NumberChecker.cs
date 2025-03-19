using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopTask
{
    public class NumberChecker
    {
        public bool IsSumOfSquaresDivisibleBy13(int num)
        {
            int tens = num / 10;
            int ones = num % 10;
            int sumOfSquares = tens * tens + ones * ones;
            return sumOfSquares % 13 == 0;
        }
            
        public void FindNumbersWithCondition()
        {
            Console.WriteLine("Двузначные числа, сумма квадратов цифр которых кратна 13:");
            for (int num = 10; num <= 99; num++)
            {
                if (IsSumOfSquaresDivisibleBy13(num))
                    Console.WriteLine(num);
            }
        }
    }
}
