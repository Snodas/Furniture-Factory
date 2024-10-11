using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Furniture_Factory.ShoppingServices
{
    public class ShoppingCart
    {
        private List<Furniture> shoppingCart = new List<Furniture>();

        //public ShoppingCart()
        //{
        //    shoppingCart = new List<Furniture>();
        //}

        public void AddItem(Furniture item)
        {
            shoppingCart.Add(item);
            Console.WriteLine($"{item.Name} has been added to your cart!");
            Console.WriteLine("Press to continue");
        }

        public decimal TotalCost()
        {
            return shoppingCart.Sum(item => item.CalculateCost());
        }

        public void AddToCart(Furniture item)
        {
            Console.WriteLine("Do you want to add this to your cart? (yes/no)");
            string input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                AddItem(item);
            }
            else
            {
                Console.WriteLine("Tråkigt...");
            }
        }

        public void PrintShoppingCart()
        {
            if (shoppingCart.Count == 0)
            {
                Console.WriteLine("Your cart is empty!");
            }
            else
            {
                var sortCartHighest = shoppingCart.OrderByDescending(item => item.CalculateCost()).ToList();

                foreach (var item in sortCartHighest)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine($"Total cost: ${TotalCost():0.00}");
            }
        }

        public void CheckOut()
        {
            Console.WriteLine("Do you want to proceed to checkout? (yes/no)");

            string checkOutInput = Console.ReadLine();

            if (checkOutInput == "yes")
            {

            }
            else
            {

            }
        }
    }
}
