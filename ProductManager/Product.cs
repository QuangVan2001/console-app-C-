using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public string CategoryID { get; set; }
        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Desc}-{CategoryID}-{UnitPrice}";
        }

        public Product(string id, string name, string desc, string categoryID, double unitPrice)
        {
            Id = id;
            Name = name;
            Desc = desc;
            CategoryID = categoryID;
            UnitPrice = unitPrice;
        }

        public Product()
        {
        }
    }
}
