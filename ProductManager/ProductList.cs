using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
   
    internal class ProductList
    {
         List<Product> products;
        public ProductList() 
        {
            products = new List<Product>();
        }

        public void InputData()
        {
            while (true)
            {
                Product product = new Product();
                Console.WriteLine("Input information of product:");
                product.Id = Validation.GetString(0, 2000, "Input Id of product: ");
                product.Name = Validation.GetString(0, 2000, "Input Name of product: ");
                product.Desc = Validation.GetString(0, 2000, "Input Description of Product: ");
                product.CategoryID = Validation.GetString(0, 2000, "Input CategoryID of Product: ");
                product.UnitPrice = Validation.GetDouble(0, 9999999, "Input UnitPrice of Product:");
            }
        }

        public void AddData() 
        { 
            InputData();
            products.Add(new Product());
        }

        public void Display()
        {
            Console.WriteLine("List of products: ");
            foreach (Product product in products)
                Console.WriteLine(product);
        }


    }
}
