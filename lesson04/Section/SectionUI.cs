using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class SectionUI
    {
        private IAnimalRepository _animalRepository;
        private ISection _section;

        public SectionUI(IAnimalRepository animalRepository, ISection section)
        {
            _animalRepository = animalRepository;
            _section = section;
        }

        public void Run()
        {
            string choice;
            
            Random random = new Random();
            int animalChoice;

            for (int i = 0; i < 10; i++)
            {
                animalChoice = random.Next(1, 4);

                switch (animalChoice)
                {
                    case 1:
                        _animalRepository.AddAnimal(new Rabbit());
                        break;

                    case 2:
                        _animalRepository.AddAnimal(new Elephant());
                        break;

                    default:
                        _animalRepository.AddAnimal(new Animal());
                        break;
                }
            }

            do
            {
                _section.PrintAnimals();

                Console.WriteLine("1 - Sort animals by name");
                Console.WriteLine("2 - Sort animals by weight");
                Console.WriteLine("3 - Find animals by name");
                Console.WriteLine("exit - Exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _animalRepository.SortAnimalsByName();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        _animalRepository.SortAnimalsByWeight();
                        Console.WriteLine("\nType any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Write the name");
                        string name = Console.ReadLine();

                        _animalRepository.FindAnimalByName(name);

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
