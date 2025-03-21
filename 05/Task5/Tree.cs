using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Tree : Plant
    {
        public override void Grow()
        {
            Console.WriteLine("Дерево растёт");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Это дерево");
        }
    }
}
