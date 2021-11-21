using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02
{
    class Storage
    {
        public Product[] _products = new Product[15];

        public Storage()
        {
            for (var i = 0; i < _products.Length; i++)
            {
                var random = new Random();

                int price = random.Next(2, 60);
                int quantity = random.Next(5, 16);
                _products[i] = new Product(ProductNames.Names[i], price, quantity);
            
                Dimensions randomDimensions = new Dimensions();

                int choice = random.Next(0, 2);
                if (choice == 1)
                {
                    randomDimensions.height = random.Next(1, 15);
                }

                choice = random.Next(0, 2);
                if (choice == 1)
                {
                    randomDimensions.lenght = random.Next(1, 15);
                }

                choice = random.Next(0, 2);
                if (choice == 1)
                {
                    randomDimensions.height = random.Next(1, 15);
                }

                _products[i].SetDimensions(randomDimensions);
            }
        }

        public int CheckQuantity(string productName)
        {
            var index = FindProduct(productName);

            if (index > 0)
            {
                return CheckQuantity(index);
            }

            return -1;
        }

        public int CheckQuantity(int index)
        {
            return _products[index].CheckQuantity();
        }

        private int FindProduct(string productName)
        {
            for(var i = 0;  i <_products.Length; ++i)
            {
                if (_products[i].Name == productName)
                    return i;
            }

            return -1;
        }
    }
}
