using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Animal : IAnimal
    {
        public string Name { get; protected set; }
        
        public int Weight { get; protected set; }

        public string Gender { get; protected set; }

        public string AddiotionalName { get; protected set; }

        public Animal()
        {
            var random = new Random();

            Name = "Monkey";
            Weight = random.Next(0, 15);

            int choice = random.Next(0, 2);
            if (choice == 0)
                Gender = "male";
            else
                Gender = "female";

            AddiotionalName = "none";
        }

        public virtual void PrintAnimal()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} kg {3, 11 }", Name, Gender, Weight, AddiotionalName);
        }

        public int CompareTo(IAnimal other)
        {
            return string.Compare(this.Name, other.Name);
        }
    }
}
