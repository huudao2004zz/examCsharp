using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[6];


            products[0] = new Book("001", "Book 1", 10.79, "nhà xuất bản 1");
            products[1] = new Book("002", "Book 2", 14.79, "nhà xuất bản 2");
            products[2] = new Book("003", "Book 3", 12.79, "nhà xuất bản 3");
            products[3] = new MobilePhone("004", "Phone 1", 109.69, "Chế tạo 1");
            products[4] = new MobilePhone("005", "phone 2", 108.79, "nhà chế tạo 2");
            products[5] = new MobilePhone("006", "phone 3", 107.89, "nhà chế tạo 3");

            double totalBook = 0;
            double totalPhone = 0;

            int i = 0;
            while (i < products.Length)
            {
                Product product = products[i];

                if (product is Book)
                {
                    totalBook += product.ComputeTax();
                }
                else if (product is MobilePhone)
                {
                    totalPhone += product.ComputeTax();
                }

                i++;
            }
            Console.WriteLine("Total tax of books :  " + totalBook);
            Console.WriteLine("Total tax of Phones :  " + totalPhone);
            Console.ReadLine();
        }
    }
}
