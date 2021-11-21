using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02
{
    struct Dimensions
    {
        public int? width;
        public int? lenght;
        public int? height;
    }

    enum Names
    {
        ChupaChups,
        Chips,
        BubbleGum,
        Water,
        Tea,
        Coffee,
        Spoone,
        Forks,
        Knives,
        Bread,
        BlackBread,
        Pizza,
        Sushi,
        Milk,
        Apple
    }

    public static class ProductNames
    {
        public static string[] Names { get; } = new string[]
        {
            "ChupaChups",
            "Chips",
            "BubbleGum",
            "Water",
            "Tea",
            "Coffee",
            "Spoone",
            "Forks",
            "Knives",
            "Bread",
            "BlackBread",
            "Pizza",
            "Sushi",
            "Milk",
            "Apple"
        };
    }

    class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; set; }        
        private Dimensions _dimensions;
        
        public Dimensions Dimensions
        { 
            get
            {
                return _dimensions;
            }
        }

        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void SetDimensions(Dimensions dimensions)
        {
            _dimensions.width = dimensions.width;
            _dimensions.lenght = dimensions.lenght;
            _dimensions.height = dimensions.height;
        }

        public void ShowProduct(int index)
        {
            if (_dimensions.width == null)
                _dimensions.width = 0;

            if (_dimensions.height== null)
                _dimensions.height= 0;

            if (_dimensions.lenght == null)
                _dimensions.lenght= 0;

            Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10}", index, Name, Price, Quantity, _dimensions.width, _dimensions.height, _dimensions.lenght);
        }

        public int CheckQuantity()
        {
            if (Quantity <= 0)
            {
                return -1;
            }

            return Quantity;
        }

        public int CountPrice()
        {
            return Quantity * Price;
        }
    }
}
