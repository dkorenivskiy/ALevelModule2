using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class SectionUI
    {
        public void Run()
        {
            string choice;
            Animal[] animals = new Animal[10];
            Random random = new Random();
            int animalChoice;

            for (int i = 0; i < animals.Length; i++)
            {
                animalChoice = random.Next(1, 4);

                switch (animalChoice)
                {
                    case 1:
                        animals[i] = new Rabbit();
                        break;

                    case 2:
                        animals[i] = new Elephant();
                        break;

                    default:
                        animals[i] = new Animal();
                        break;
                }
            }

            ISection section = new Section(animals);

            do
            {
                section.PrintAnimals();

                Console.WriteLine("1 - Sort animals by name");
                Console.WriteLine("2 - Sort animals by weight");
                Console.WriteLine("3 - Find animals by name");
                Console.WriteLine("exit - Exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        section.SortAnimalsByName();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        section.SortAnimalsByWeight();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Write the name");
                        string name = Console.ReadLine();

                        SectionFind.FindAnimal((Section)section, name);

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
