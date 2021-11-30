using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson04
{
    static class SectionFind
    {
        public static void FindAnimal(this Section section, string name)
        {
            Console.WriteLine("\nResult:");
            Console.WriteLine("\n{0, 10} {1, 10} {2, 10}", "Name", "Type", "Weight(g)");

            int count = 0;
            for (int i = 0; i < section.Animals.Length; i++)
            {
                if (section.Animals[i].Name == name)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no such an animal");
                return;
            }

            for (int i = 0; i < section.Animals.Length; i++)
            {
                if (section.Animals[i].Name == name)
                {
                    section.Animals[i].PrintAnimal();
                }
            }
        }
    }
}

