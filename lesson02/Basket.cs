using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02
{
    class Basket
    {
        private List<Product> _products = new List<Product>();

        public int GetProductsCount()
        {
            return _products.Count(); 
        }

        public void AddProduct(Product product)
        {
            if(_products.Count > 9)
            {
                Console.WriteLine("Maximum size of cart = 10");
                return;
            }

            _products.Add(product);
        }

        public void ShowProducts()
        {
            if (_products.Any())
            {
                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10}", "Id", "Name", "Price", "Quantity", "Width", "Height", "Lenght");

                int index = 0;
                foreach (var product in _products)
                {
                    product.ShowProduct(index);
                    Console.WriteLine("{0, 10}Total price for this = {1}", "", product.CountPrice());
                    index++;
                }
            }
            else
            {
                Console.WriteLine("Empty");
                Console.WriteLine();
            }
        }

        public Product FindProd(string name)
        {
            foreach (var product in _products)
            {
                if (product.Name == name)
                    return product;
            }

            return null;
        }

        public void IncreaseProduct(string choiceName, int quantity)
        {
            foreach (var product in _products)
            {
                if (product.Name == choiceName)
                {
                    product.Quantity += quantity;
                    return;
                }
            }
        }

        public void DecreaseProduct(string choiceName, int quantity)
        {
            foreach (var product in _products)
            {
                if (product.Name == choiceName)
                {
                    product.Quantity -= quantity;

                    if (product.Quantity == 0)
                        RemoveProduct(choiceName);

                    return;
                }
            }
        }

        public int RemoveProduct(string choiceName)
        {
            int toStorageQuantity = 0;
            int index = 0;
            foreach (var product in _products)
            {
                if (product.Name == choiceName)
                {
                    index = _products.IndexOf(product);
                    toStorageQuantity = product.Quantity;
                    break;
                }
            }

            _products.RemoveAt(index);

            return toStorageQuantity;
        }

        public void RemoveAllProducts()
        {
            _products.RemoveRange(0, _products.Count);
        }
    }
}
