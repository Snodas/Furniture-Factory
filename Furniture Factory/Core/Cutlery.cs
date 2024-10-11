using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public class Cutlery : Furniture
    {
        public Cutlery()
        {
            Wood = false;
            Steel = true;
            Fabric = false;

            SteelCost = 125;
            SteelNeeded = 20;

            TypeOfFurniture = TypeOfFurniture.Cutlery;
            Name = "Kitchen Cutlery";
        }
        public override string ToString()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine("----Product Description----");
            description.AppendLine($"Product: {Name}");
            description.AppendLine($"Product Type: {TypeOfFurniture}");
            description.AppendLine("Materials:");

            if (Wood)
                description.AppendLine("- Wood");

            if (Steel)
                description.AppendLine("- Steel");

            if (Fabric)
                description.AppendLine("- Fabric");

            description.AppendLine("Note: PRODUCT WILL RUST AFTER WASHING");
            description.AppendLine($"Price: ${CalculateCost():0.00}");

            return description.ToString();
        }
    }
}
