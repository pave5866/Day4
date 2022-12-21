using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler ürün sepete eklendi: " + product.ProductName);
        }
    }
}
