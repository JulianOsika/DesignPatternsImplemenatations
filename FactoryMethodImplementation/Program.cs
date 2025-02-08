using FactoryMethodImplementation;
using System.Xml.Serialization;

Console.WriteLine("Choose vehicle type:");
Console.WriteLine("1 - Truck");
Console.WriteLine("2 - Car");
Console.WriteLine("3 - Motorcycle");

int input = int.Parse(Console.ReadLine());

VehicleFactory vehicleFactory = input switch
{
    1 => new TruckFactory(),
    2 => new CarFactory(),
    3 => new MotorcycleFactory()
};

IVehicle vehicle = vehicleFactory.CreateVehicle();

vehicle.ShowInfo();

