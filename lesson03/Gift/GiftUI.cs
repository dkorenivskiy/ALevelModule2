using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    class GiftUI
    {
        public void Run()
        {
            string choice;
            Gift gift = new Gift();

            do
            {
                gift.PrintCandiesInGift();

                Console.WriteLine("1 - Sort candies by name");
                Console.WriteLine("2 - Sort candies by weight");
                Console.WriteLine("3 - Find candies by name");
                Console.WriteLine("exit - Exit");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        gift.SortCandyByName();

                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        gift.SortCandy();

                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Write the name");
                        string name = Console.ReadLine();
                        GiftFind.FindCandy(gift, name);

                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Wrong value!");
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice != "exit");
        }
    }
}
