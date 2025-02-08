using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    internal class Car :IVehicle
    {
        public Car()
        {
            Name = "Family car";
            Color = "White";
            doorsNumber = 5;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int doorsNumber { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Doors: {doorsNumber.ToString()}");
        }
    }
}
