using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 }; //bu şekilde de yazılabilir.

            //PascalCase   //camelCase
            //case sensitive
            //    ↓              ↓
            ProductManager productManager = new ProductManager(); //bunu string isim = "Esma"; , int x = 5; gibi düşün. Farkı new'liyor olman.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

       
        }
    }
}
