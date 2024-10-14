using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Factory.Core
{
    public class Table : Furniture, IComparable<Table> 
    {
        public decimal AreaOfTable { get; set; }

        public Table()
        {
            Wood = true;
            Steel = false;
            Fabric = false;

            WoodCost = 50;
            WoodNeeded = 20;

            TypeOfFurniture = TypeOfFurniture.Table;
            Name = "Kitchen Table";
            AreaOfTable = 22000; //cm2
        }

        public override string ToString()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine("----Product Description----");
            description.AppendLine($"Product: {Name}");
            description.AppendLine($"Product Type: {TypeOfFurniture}");
            description.AppendLine($"This table: {Name} has an surface area of {AreaOfTable} cm2.");
            description.AppendLine("Materials:");

            if (Wood)
                description.AppendLine("- Wood");

            if (Steel)
                description.AppendLine("- Steel");

            if (Fabric)
                description.AppendLine("- Fabric");

            description.AppendLine("Note: LEGS NOT INCLUDED!");
            description.AppendLine($"Price: ${CalculateCost():0.00}");

            return description.ToString();
        }
        public int CompareTo(Table other)
        {
            return other.AreaOfTable.CompareTo(this.AreaOfTable);
        }
    }
}
