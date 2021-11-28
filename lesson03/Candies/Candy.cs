using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    enum TypeCandy
    {
        Nuts,
        Chocolate,
        Coconut
    }

    class Candy : IComparable<Candy>
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected int _weight;
        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        protected TypeCandy _type;
        public TypeCandy Type
        {
            get
            {
                return _type;
            }
        }

        public Candy()
        {
            _name = "Roshen";
            _weight = 15;
            _type = TypeCandy.Chocolate;
        }

        public void PrintCandy()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} g", _name, _type, _weight);
        }

        public int CompareTo(Candy other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
