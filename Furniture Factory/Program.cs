using Furniture_Factory.Core;
using Furniture_Factory.ShoppingServices;

namespace KitchenFurnitureFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;

            ShoppingCart cart = new ShoppingCart();
          
            while (programRunning == true)
            {
                Console.Clear();    
                Console.WriteLine("----FurnitureFactory----");
                Console.WriteLine("----Products----");
                Console.WriteLine("1: Chairs");
                Console.WriteLine("2: Tables");
                Console.WriteLine("3: Ceilinglamps");
                Console.WriteLine("4: Coasters");
                Console.WriteLine("5: Cutlery");
                Console.WriteLine("6: Show Cart");
                Console.WriteLine("7: ");

                int userInput = Convert.ToInt32(Console.ReadLine());
               
                switch (userInput)
                {
                    case 1:
                        
                        Chair chair = new Chair();
                        Console.WriteLine(chair.ToString());
                        cart.AddToCart(chair);
                        Console.ReadKey();

                        break;

                    case 2:

                        Table table = new();
                        Console.WriteLine(table.ToString()); 
                        cart.AddToCart(table);
                        Console.ReadKey();

                        break;


                    case 3:

                        CeilingLamp ceilingLamp = new CeilingLamp();
                        Console.WriteLine(ceilingLamp.ToString());
                        cart.AddToCart(ceilingLamp);
                        Console.ReadKey();

                        break;

                    case 4:

                        Coaster coaster = new Coaster();
                        Console.WriteLine(coaster.ToString());
                        cart.AddToCart(coaster);
                        Console.ReadKey();

                        break;

                    case 5:

                        Cutlery cutlery = new Cutlery();
                        Console.WriteLine(cutlery.ToString());
                        cart.AddToCart(cutlery);
                        Console.ReadKey();

                        break;

                    case 6:

                        Console.Clear();
                        cart.PrintShoppingCart();
                        Console.ReadKey();

                        break;

                    case 7:


                        break;

                    default:

                        Console.WriteLine("Invalid option...");
                        Console.WriteLine("Click to continue");
                        Console.ReadKey();

                        break;


                };


            }



        }
    }
}
