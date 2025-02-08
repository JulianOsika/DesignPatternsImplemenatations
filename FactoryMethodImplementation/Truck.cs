using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    internal class Truck : IVehicle
    {
        public Truck()
        {
            Name = "Basic truck";
            Description = "4 wheels lol";
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Vehicle: {Name}");
            Console.WriteLine($"Description:");
            Console.WriteLine(Description);
        }
    }
}
