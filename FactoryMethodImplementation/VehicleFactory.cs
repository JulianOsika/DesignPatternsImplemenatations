using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImplementation
{
    abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
