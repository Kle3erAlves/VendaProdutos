using System;
using System.Globalization;
using VendaProdutos.Entities;
using System.Collections.Generic;

namespace VendaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) //for do valor digitado pelo usuario para saber quantos produtos
            //ira percorrer
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported (c/u/i)?? ");
                char prod = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (prod == 'i')
                {
                 Console.Write("Customs fee: ");
                 double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 list.Add(new ImportedProduct(name, price, fee));
                }

                else if (prod == 'u')
                {
                 Console.Write("Manufacture date (DD/MM/YYYY): ");
                 DateTime mdate = DateTime.Parse(Console.ReadLine());
                 list.Add(new UsedProduct(name, price, mdate));
                }

                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:  ");
            foreach (Product prd in list)
            {
                Console.WriteLine(prd.PriceTag());
            }


        }
    }
}
