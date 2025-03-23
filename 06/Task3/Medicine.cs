using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Medicine
    {
        public string Name { get; set; }
        public Medicine(string name) => Name = name;
    }
}
