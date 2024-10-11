using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public class Coaster : Furniture
    {
        public Coaster()
        {
            Wood = false;
            Steel = false;
            Fabric = true;

            FabricCost = 25;
            FabricNeeded = 1;

            TypeOfFurniture = TypeOfFurniture.Coaster;
            Name = "Dining Coasters";
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

            description.AppendLine("Note: EXTREMLY FLAMABLE, KEEP AWAY FROM CANDLES!");
            description.AppendLine($"Price: ${CalculateCost():0.00}");

            return description.ToString();
        }
    }
}
