using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02
{
    class ShopUI
    {
        public void Run()
        {
            Shop shop = new Shop();
            string choice;

            do
            {
                Console.WriteLine("Welcome to the Shop!");
                Console.WriteLine("\nThere are some products");
                shop.ShowAllProducts();
                Console.WriteLine("Your cart:");
                shop.ShowProductsInCart();
                Console.WriteLine();

                Console.WriteLine("1 - Add product to the cart");
                Console.WriteLine("2 - Increase product quantity from the cart");
                Console.WriteLine("3 - Decrease product quantity from the cart");
                Console.WriteLine("4 - Remove product from the cart");
                Console.WriteLine("5 - Buy products in cart");
                Console.WriteLine("exit - Exit");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        shop.AddProduct();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        shop.IncreaseProductInCart();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        shop.DecreaseProductInCart();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        shop.RemoveProductFromCart();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        shop.BuyCart(); 
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("\nWrong value!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice != "exit");
        }
    }
}
