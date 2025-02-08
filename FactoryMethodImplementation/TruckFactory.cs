using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    internal class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle() => new Truck();
    }
}
