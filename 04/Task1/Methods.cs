using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс А с целочисленными полями а и b и двумя методами согласно варианту.
 * Внутри класса реализовать конструктор для инициализации a и b.
 * Создать объект класса и продемонстрировать работу со всеми элементами класса.
*/
/*Метод вычисления значения выражения (1/a)+(1/sqrt(b)) ,  метод вычисления  a^6. */

namespace Task1
{
    public class Methods(int a, int b)
    {
        int A = a;
        int B = b;

        public void Methods1()
        {
            double result1 = (1 / a) + (1 / Math.Sqrt(b));
            Console.WriteLine(result1);
        }

        public void Methods2()
        {
            int result2 = (int)Math.Pow(a, 6);
            Console.WriteLine(result2);
        }
    }
}
