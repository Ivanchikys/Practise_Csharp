using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person(string name, string city)
    {
        public string Name { get; set; } = name;
        public string City { get; set; } = city;
    }
}
