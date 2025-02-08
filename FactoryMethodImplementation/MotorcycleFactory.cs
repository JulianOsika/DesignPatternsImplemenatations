using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    internal class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Motorcycle output = new Motorcycle();
            output.Brand = "MyBrand";
            output.Type = "Motocross";
            output.ProductionYear = 2012;
            return output;
        }
    }
}
