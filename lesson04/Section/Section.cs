using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Section : ISection
    {
        private Animal[] _animals;
        public Animal[] Animals
        {
            get
            {
                return _animals;
            }
        }

        public Section(Animal[] animals) 
        {
            _animals = animals;
        }

        public void PrintAnimals()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 20}", "Name", "Gender", "Weight(kg)", "Additional");
            foreach (var animal in _animals)
            {
                animal.PrintAnimal();
            }
        }

        public void SortAnimalsByName()
        {
            Array.Sort<Animal>(_animals);
        }

        public void SortAnimalsByWeight()
        {
            for (int i = 0; i < _animals.Length - 1; i++)
            {
                for (int j = i + 1; j < _animals.Length; j++)
                {
                    if (_animals[i].Weight < _animals[j].Weight)
                    {
                        Animal buffer = _animals[i];
                        _animals[i] = _animals[j];
                        _animals[j] = buffer;
                    }
                }
            }
        }
    }
}
