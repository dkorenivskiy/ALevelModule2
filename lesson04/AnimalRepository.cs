using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class AnimalRepository : IAnimalRepository
    {
        private List<IAnimal> _animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public List<IAnimal> GetAnimals()
        {
            return _animals;
        }

        public void SortAnimalsByName()
        {
            for (int i = 0; i < _animals.Count - 1; i++)
            {
                for (int j = i + 1; j < _animals.Count; j++)
                {
                    if (_animals[i].CompareTo(_animals[j]) == 1)
                    {
                        IAnimal buffer = _animals[i];
                        _animals[i] = _animals[j];
                        _animals[j] = buffer;
                    }
                }
            }
        }

        public void SortAnimalsByWeight()
        {
            for (int i = 0; i < _animals.Count - 1; i++)
            {
                for (int j = i + 1; j < _animals.Count; j++)
                {
                    if (_animals[i].Weight < _animals[j].Weight)
                    {
                        IAnimal buffer = _animals[i];
                        _animals[i] = _animals[j];
                        _animals[j] = buffer;
                    }
                }
            }
        }

        public void FindAnimalByName(string name)
        {
            Console.WriteLine("\nResult:");
            Console.WriteLine("\n{0, 10} {1, 10} {2, 10}", "Name", "Type", "Weight(g)");

            int count = 0;
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].Name == name)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no such an animal");
                return;
            }

            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].Name == name)
                {
                    _animals[i].PrintAnimal();
                }
            }
        }
    }
}
