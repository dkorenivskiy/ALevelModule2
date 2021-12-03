using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    interface IAnimalRepository
    {
        List<IAnimal> GetAnimals();

        void AddAnimal(IAnimal animal);

        public void SortAnimalsByWeight();

        public void SortAnimalsByName();

        public void FindAnimalByName(string name);
    }
}
