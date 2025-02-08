using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    internal class Motorcycle : IVehicle
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public int ProductionYear { get; set; }

        public Motorcycle()
        {
            Type = "scooter";
            Brand = "unknown";
            ProductionYear = 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Year: {ProductionYear}");
        }
    }
}
