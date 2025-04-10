﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class InvalidGradeException : Exception
    {
        public InvalidGradeException() : base("Оценка должна быть в диапазоне от 0 до 100.") { }
        public InvalidGradeException(string message) : base(message) { }
        public InvalidGradeException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
