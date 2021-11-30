﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Elephant : Animal
    {
        private int _trunkLength;
        public int TrunkLength
        {
            get
            {
                return _trunkLength;
            }
        }

        public Elephant()
        {
            _name = "Elephant";
            var random = new Random();
            _weight = random.Next(4000, 4500);
            _trunkLength = random.Next(125, 160);
            AddiotionalName = "Trunk Length";
        }

        public override void PrintAnimal()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} kg {3, 10}cm ({4, 10})", _name, _gender, _weight, _trunkLength, AddiotionalName);
        }
    }
}
