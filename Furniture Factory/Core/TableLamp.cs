using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public class TableLamp : Furniture
    {
        public TableLamp()
        {
            Wood = true;
            Steel = true;
            Fabric = false;

            WoodCost = 100;
            WoodNeeded = 2;

            SteelCost = 125;
            SteelNeeded = 10;

            TypeOfFurniture = TypeOfFurniture.TableLamp;
            Name = "Tablelamp";
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

            description.AppendLine($"Price: ${CalculateCost():0.00}");

            return description.ToString();
        }
    }
}
