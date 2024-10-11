using Furniture_Factory.ShoppingServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public abstract class Furniture
    {
        //public List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();

        public bool Wood { get; set; }
        public decimal WoodCost { get; set; }
        public decimal WoodNeeded { get; set; }

        public bool Steel { get; set; }
        public decimal SteelCost { get; set; }
        public decimal SteelNeeded { get; set; }

        public bool Fabric { get; set; }
        public decimal FabricCost { get; set; }
        public decimal FabricNeeded { get; set; }

        public TypeOfFurniture TypeOfFurniture { get; set; }
        public double StoreMarkUp { get; set; }
        public string Name { get; set; }

        public Furniture()
        { 

            WoodCost = 0;
            WoodNeeded = 0;

            SteelCost = 0;
            SteelNeeded = 0;

            FabricCost = 0;                       
            FabricNeeded = 0;
            
            StoreMarkUp = 1.25; // 25%
        }

        public decimal CalculateCost()
        {
            decimal totalMaterialCost = 0;

            if (Wood)
                totalMaterialCost += WoodCost * WoodNeeded;
            
            if (Steel)
                totalMaterialCost += SteelCost * SteelNeeded;
            
            if (Fabric)
                totalMaterialCost += FabricCost * FabricNeeded;

            decimal finalPrice = totalMaterialCost * (decimal)StoreMarkUp;

            return finalPrice;
        }
    }
    public enum TypeOfFurniture
    {
        Chair,
        Table,
        Ceilinglamp,
        Coaster,
        Cutlery,
    }

    
}
