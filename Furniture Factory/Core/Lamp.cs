using Furniture_Factory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Furniture_Factory.Core
{
    public class Lamp : Furniture, IComparable<Lamp>
    {
        public double Current {  get; set; }

        public Lamp()
        {
            Wood = false;
            Steel = true;
            Fabric = false;

            SteelCost = 125;
            SteelNeeded = 10;

            TypeOfFurniture = TypeOfFurniture.Ceilinglamp;
            Name = "Kitchen Ceilinglamp";
            Current = 60; //ampere
        }
        public override string ToString()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine("----Product Description----");
            description.AppendLine($"Product: {Name}");
            description.AppendLine($"Product Type: {TypeOfFurniture}");
            description.AppendLine($"This lamp: {Name} has a current of {Current}: ampere.");
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
        public int CompareTo(Lamp other)
        {
            return other.Current.CompareTo(this.Current);
        }
    }    
}
