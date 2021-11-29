using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    class Snickers : Candy
    {
        private int NutWeight = 1;

        public Snickers()
        {
            _name = "Snickers";
            _weight = 20 + NutWeight;
            _type = TypeCandy.Nuts;
        }
    }
}
