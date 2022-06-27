using System;
using System.Collections;

namespace PracticalTest
{

    class Program
    {
        static List<Product> productLists = new List<Product>();
        static void Main(string[] args)
        {
            try
            {
                int choose;
                do
                {
                    ShowMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            DisplayProduct();
                            break;
                        case 3:
                            DeleteProductToID();
                            break;
                        case 4:
                            Console.WriteLine("Exit Program!!!");
                            break;
                        default:
                            Console.WriteLine("Please you choose again!!! ");
                            break;
                    }
                }
                while (choose != 4);
            }
            catch (Exception e)
            {
                Console.WriteLine("Only enter Number !!!");
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Enter product id: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            decimal Price = decimal.Parse(Console.ReadLine());

            Product product = new Product(productID, productName, Price);

            productLists.Add(product);

        }

        static void DisplayProduct()
        {
            foreach (Product product in productLists)
            {
                Console.WriteLine(product.ToString());
            }

        }

        static void DeleteProductToID()
        {
            Console.WriteLine("Enter product id you want delete: ");
            int productID = int.Parse(Console.ReadLine());

            

        }

        static void ShowMenu()
        {
            Console.WriteLine(" 1. Add product records");
            Console.WriteLine(" 2. Display product records");
            Console.WriteLine(" 3. Delete product records");
            Console.WriteLine(" 4. Exit");
            Console.WriteLine(" Choose: ");

        }

    }

    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, decimal Price)
        {
            this.productID = productID;
            this.productName = productName;
            this.Price = Price;
        }

        public override string ToString()
        {
            return "{ Product: \tProductID: " + productID + " ProductName: " + productName + " Price: " + Price + "}"; 
        } 
    }
}




