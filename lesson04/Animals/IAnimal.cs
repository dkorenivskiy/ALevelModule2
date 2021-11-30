using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    interface IAnimal
    {
        public string Name { get; }
        public int Weight { get; }
        public string Gender { get; }
        public void PrintAnimal();
    }
}
