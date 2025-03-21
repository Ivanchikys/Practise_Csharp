using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public sealed class ClothingProduct : Product
    {
        public ClothingProduct(string name, decimal price, int stockQuantity)
        : base(name, "Clothing", price, stockQuantity) { }
    }
}
