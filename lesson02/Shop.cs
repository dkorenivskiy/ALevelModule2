using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02
{
    class Shop
    {
        private Storage _storage = new Storage();
        private Basket _basket = new Basket();

        public void ShowAllProducts()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10}", "Id", "Name", "Price", "Quantity", "Width", "Height", "Lenght");

            for (int i = 0; i < _storage._products.Length; i++)
            {
                if (_storage._products[i].Quantity == 0)
                    continue;

                _storage._products[i].ShowProduct(i);
            }
        }

        public void ShowProductsInCart()
        {
            _basket.ShowProducts();
        }
        
        public void AddProduct()
        {
            if (_basket.GetProductsCount() > 9)
            {
                Console.WriteLine("Maximum size of cart = 10");
                return;
            }

            int choice = 0;
            int fromStorageQuantity = 0;

            Console.WriteLine("What product(index of product) do you want to buy?");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice < _storage._products.Length)
            {
                if (_storage.CheckQuantity(choice) == -1)
                {
                    Console.WriteLine("Not available");
                }
                else
                {
                    Console.WriteLine("How many?");
                    string intValue = Console.ReadLine();
                    if (int.TryParse(intValue, out fromStorageQuantity) == false)
                    {
                        Console.WriteLine("Wrong value!");
                        return;
                    }

                    if (_storage.CheckQuantity(choice) - fromStorageQuantity < 0)
                    {
                        Console.WriteLine("Not available");
                    }
                    else
                    {
                        Product product = new Product(_storage._products[choice].Name, _storage._products[choice].Price, fromStorageQuantity);
                        product.SetDimensions(_storage._products[choice].Dimensions);

                        _storage._products[choice].Quantity -= fromStorageQuantity;
                        _basket.AddProduct(product);
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no such an item");
            }
        }

        public void IncreaseProductInCart()
        {
            string choiceName;
            Console.WriteLine("What product quantity(name of product) do you want to increase?");
            choiceName = Console.ReadLine();

            if (_basket.FindProd(choiceName) == null)
            {
                Console.WriteLine("There is no such an item in cart");
            }
            else
            {
                for (int i = 0; i < _storage._products.Length; i++)
                {
                    if (_storage._products[i].Name == choiceName)
                    {
                        Console.WriteLine("How many?");
                        int fromStorageQuantity = Convert.ToInt32(Console.ReadLine());

                        if (_storage._products[i].Quantity - fromStorageQuantity < 0)
                        {
                            Console.WriteLine("Not available");
                        }
                        else
                        {
                            _basket.IncreaseProduct(choiceName, fromStorageQuantity);
                            _storage._products[i].Quantity -= fromStorageQuantity;
                        }

                    }
                }
            }
        }

        public void DecreaseProductInCart()
        {
            string choiceName;
            Console.WriteLine("What product quantity(name of product) do you want to decrease?");
            choiceName = Console.ReadLine();

            if (_basket.FindProd(choiceName) == null)
            {
                Console.WriteLine("There is no such an item in cart");
            }
            else
            {
                for (int i = 0; i < _storage._products.Length; i++)
                {
                    if (_storage._products[i].Name == choiceName)
                    {
                        if (_basket.FindProd(choiceName).CheckQuantity() == -1)
                        {
                            Console.WriteLine("Not available");
                        }
                        else
                        {
                            Console.WriteLine("How many?");
                            int toStorageQuantity = Convert.ToInt32(Console.ReadLine());

                            if (_basket.FindProd(choiceName).Quantity - toStorageQuantity < 0)
                            {
                                Console.WriteLine("Not available");
                            }
                            else
                            {
                                _basket.DecreaseProduct(choiceName, toStorageQuantity);
                                _storage._products[i].Quantity += toStorageQuantity;
                            }
                        }
                    }
                }
            }
        }

        public void RemoveProductFromCart()
        {
            string choiceName;
            Console.WriteLine("What product(name of product) do you want to remove?");
            choiceName = Console.ReadLine();

            if (_basket.FindProd(choiceName) == null)
            {
                Console.WriteLine("There is no such an item in cart");
            }
            else
            {
                for (int i = 0; i < _storage._products.Length; i++)
                {
                    if (_storage._products[i].Name == choiceName)
                    {
                        _storage._products[i].Quantity += _basket.RemoveProduct(choiceName);
                    }
                }
            }
        }

        public void BuyCart()
        {
            var random = new Random();

            int dealNumber = random.Next(1000000, 9999999);

            Console.WriteLine("Thanks for purchase!");
            Console.WriteLine($"Your number of deal {dealNumber}");
            
            _basket.RemoveAllProducts();
        }
    }
}
