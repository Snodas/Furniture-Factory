using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public class Chair : Furniture
    {
        public Chair()
        {
            Wood = true;
            Steel = false;
            Fabric = true;

            WoodCost = 50;
            WoodNeeded = 2;

            FabricCost = 10;
            FabricNeeded = 1;

            TypeOfFurniture = TypeOfFurniture.Chair;
            Name = "Kitchen Chair";
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

            description.AppendLine("Note: WILL BREAK WHEN LEANING BACK!");
            description.AppendLine($"Price: ${CalculateCost():0.00}");

            return description.ToString();
        }
    }
}
