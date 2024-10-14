using Furniture_Factory.Core;
using Furniture_Factory.ShoppingServices;

namespace KitchenFurnitureFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>
            {
                new Table { Name = "Dining Table", AreaOfTable = 30000},
                new Table { Name = "Coffe Table", AreaOfTable = 12000},
                new Table { Name = "Dining Table", AreaOfTable = 20000}
            };
            
            List<Lamp> lamps = new List<Lamp>
            {
                new Lamp { Name = "Floor Lamp", Current = 180},
                new Lamp { Name = "Desk Lamp", Current = 40},
                new Lamp { Name = "Table Lamp", Current = 120}
            };

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
                Console.WriteLine("5: Desks");
                Console.WriteLine("6: Show Cart");
                Console.WriteLine("7: Checkout");
                Console.WriteLine("8: Show all tables");
                Console.WriteLine("9: Show all lamps");

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

                        Lamp ceilingLamp = new Lamp();
                        Console.WriteLine(ceilingLamp.ToString());
                        cart.AddToCart(ceilingLamp);
                        Console.ReadKey();

                        break;

                    case 4:

                        TableLamp tableLamp = new TableLamp();
                        Console.WriteLine(tableLamp.ToString());
                        cart.AddToCart(tableLamp);
                        Console.ReadKey();

                        break;

                    case 5:

                        Desk desk = new Desk();
                        Console.WriteLine(desk.ToString());
                        cart.AddToCart(desk);
                        Console.ReadKey();

                        break;

                    case 6:

                        Console.Clear();
                        cart.PrintShoppingCart();
                        Console.ReadKey();

                        break;

                    case 7:

                        Console.Clear();
                        cart.CheckOut();
                        Console.ReadKey();

                        break;

                    case 8:

                        Console.Clear();
                        tables.Sort();

                        foreach(var sortedTables in tables)
                        {
                            Console.WriteLine(sortedTables.ToString());
                        }
                        
                        Console.ReadKey();
                        break;

                    case 9:

                        Console.Clear();
                        lamps.Sort();

                        foreach (var sortedLamps in lamps)
                        {
                            Console.WriteLine(sortedLamps.ToString());
                        }
                        Console.ReadKey();

                        break;

                    default:

                        Console.WriteLine("Invalid option...");
                        Console.WriteLine("Click to continue");
                        Console.ReadKey();

                        break;
                };
            }






        }

        


        //public static void SortTables(List<Table> tables)
        //{
        //    var sortedTables = tables.OrderByDescending(table => table.CalculateCost()).ToList();

        //    Console.WriteLine("----Highest Price First----");
        //    foreach(var table in sortedTables)
        //    {
        //        Console.WriteLine(table.ToString());
        //    }
        //}
        //public static void SortLamps(List<Lamp> lamps)
        //{
        //    var sortedLamps = lamps.OrderByDescending(table => table.CalculateCost()).ToList();

        //    Console.WriteLine("----Highest Price First----");
        //    foreach (var table in sortedLamps)
        //    {
        //        Console.WriteLine(table.ToString());
        //    }
        //}
    }
}
