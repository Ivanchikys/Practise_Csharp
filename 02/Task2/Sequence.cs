using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2
{
    public class Sequence(int num)
    {
        public int Num = num;
        int firstDigit = num / 100;
        int secondDigit = num / 10 % 10;
        int thirdDigit = num % 10;
        public bool IsIncreasing()
        {
            if (firstDigit == secondDigit && secondDigit == thirdDigit) 
                return false;

            return firstDigit < secondDigit && secondDigit < thirdDigit;
        }

        public bool IsDescending()
        {
            if (firstDigit == secondDigit && secondDigit == thirdDigit)
                return false;

            return firstDigit > secondDigit && secondDigit > thirdDigit;
        }
    }
}
