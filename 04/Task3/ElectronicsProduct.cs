using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public sealed class ElectronicsProduct : Product
    {
        public ElectronicsProduct(string name, decimal price, int stockQuantity)
       : base(name, "Electronics", price, stockQuantity) { }
    }
}
