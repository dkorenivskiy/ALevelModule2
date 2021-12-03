using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Rabbit : Animal
    {
        private int _earLength;
        public int EarLength
        {
            get
            {
                return _earLength;
            }
        }

        public Rabbit()
        {
            Name = "Rabbit";
            var random = new Random();
            Weight = random.Next(6, 10);
            _earLength = random.Next(3, 9);
            AddiotionalName = "Ear lenght";
        }

        public override void PrintAnimal()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} kg {3, 10}cm ({4, 10})", Name, Gender, Weight, _earLength, AddiotionalName);
        }
    }
}
