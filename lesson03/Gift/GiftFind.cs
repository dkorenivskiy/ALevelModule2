using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    static class GiftFind
    {
        public static void FindCandy(this Gift gift, string name)
        {
            Console.WriteLine("\nResult:");
            Console.WriteLine("\n{0, 10} {1, 10} {2, 10}", "Name", "Type", "Weight(g)");

            int count = 0;
            for (int i = 0; i < gift.Candies.Length; i++)
            {
                if (gift.Candies[i].Name == name)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no such a Candy");
                return;
            }

            im

            for (int i = 0; i < gift.Candies.Length; i++)
            {
                if (gift.Candies[i].Name == name)
                {
                    gift.Candies[i].PrintCandy();
                }
            }
        }
    }
}
