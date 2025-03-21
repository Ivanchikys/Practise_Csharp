using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Plant
    {
        public abstract void Grow();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("");
        }
    }
}
