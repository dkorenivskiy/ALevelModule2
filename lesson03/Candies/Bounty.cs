using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    class Bounty : Candy
    {
        private int CoconutWeight = 2;

        public Bounty()
        {
            _name = "Bounty";
            _weight = 10 + CoconutWeight;
            _type = TypeCandy.Coconut;
        }
    }
}
