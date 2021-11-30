using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Animal : IComparable<Animal>, IAnimal
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected int _weight;
        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        protected string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
        }
        public string AddiotionalName { get; protected set; }

        public Animal()
        {
            var random = new Random();

            _name = "Monkey";
            _weight = random.Next(0, 15);

            int choice = random.Next(0, 2);
            if (choice == 0)
                _gender = "male";
            else
                _gender = "female";

            AddiotionalName = "none";
        }

        public virtual void PrintAnimal()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} kg {3, 11 }", _name, _gender, _weight, AddiotionalName);
        }

        public int CompareTo(Animal other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
