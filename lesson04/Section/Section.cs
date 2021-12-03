using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    class Section : ISection
    {
        private List<IAnimal> _animals;

        public Section(IAnimalRepository animalRepository) 
        {
            _animals = animalRepository.GetAnimals();
        }

        public void PrintAnimals()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 20}", "Name", "Gender", "Weight(kg)", "Additional");
            foreach (var animal in _animals)
            {
                animal.PrintAnimal();
            }
        }
    }
}
