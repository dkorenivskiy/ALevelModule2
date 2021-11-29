using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    class Gift : IGift
    {
        private int _weight;
        private Candy[] _candies = new Candy[20];
        public Candy[] Candies
        {
            get
            {
                return _candies;
            }
        }

        public Gift()
        {
            Random random = new Random();
            int choice;

            for (int i = 0; i < _candies.Length; i++)
            {
                choice = random.Next(1, 5);

                switch (choice)
                {
                    case 1:
                        _candies[i] = new Snickers();
                        break;

                    case 2:
                        _candies[i] = new Twix();
                        break;

                    case 3:
                        _candies[i] = new Bounty();
                        break;

                    default:
                        _candies[i] = new Candy();
                        break;
                }
            }

            foreach (var candy in _candies)
            {
                _weight += candy.Weight;
            }
        }

        public void PrintCandiesInGift()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10}", "Name", "Type", "Weight(g)");
            foreach (var candy in _candies)
            {
                candy.PrintCandy();
            }

            Console.WriteLine($"Total weight = {_weight} g");
        }

        public void SortCandy()
        {
            for(int i = 0; i < _candies.Length - 1; i++)
            {
                for (int j = i + 1; j < _candies.Length; j++)
                {
                    if(_candies[i].Weight < _candies[j].Weight)
                    {
                        Candy buffer = _candies[i];
                        _candies[i]= _candies[j];
                        _candies[j]= buffer;
                    }
                }
            }
        }

        public void SortCandyByName()
        {
            Array.Sort<Candy>(_candies);
        }
    }
}
