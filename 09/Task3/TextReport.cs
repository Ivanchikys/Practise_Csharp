using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TextReport<T> : IReport<T>
    {
        public string Generate(T data)
        {
            return $"Данные отчета: {data.ToString()}";
        }
    }
}
