﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Actor
    {
        public string Name { get; set; }
        public Actor(string name) => Name = name;
        public override string ToString() => Name;
    }
}
