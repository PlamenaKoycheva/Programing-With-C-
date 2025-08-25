//Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
//Define a class Truck with the following properties: Brand, Model, and Weight.
//Define a class Car with the following properties: Brand, Model, and Horse Power.
//Define a class Catalog with the following properties: Collections of Trucks and Cars.
//You must read the input, until you receive the "end" command. It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
//In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
//"Cars:
//{ Brand}: { Model}
//- { Horse Power}
//hp
//Trucks:
//{ Brand}: { Model}
//- { Weight}
//kg"

string command = Console.ReadLine();
Catalog catalog = new Catalog();
while (command != "end")
{
    string[] vehicleInfo = command.Split("/").ToArray();
    string type = vehicleInfo[0];
    string brand = vehicleInfo[1];
    string model = vehicleInfo[2];
    if (type == "Car")
    {
        double horsePower = double.Parse(vehicleInfo[3]);
        Car currentCar = new Car(brand, model, horsePower);
        catalog.Cars.Add(currentCar);
    }
    else if (type == "Truck")
    {
        double weight = double.Parse(vehicleInfo[3]);
        Truck currentTruck = new Truck(brand, model, weight);
        catalog.Trucks.Add(currentTruck);
    }

 



        command = Console.ReadLine();
}
    if (catalog.Cars.Count > 0)
    {
        Console.WriteLine("Cars:");

    foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
    { 
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
    
    }

if (catalog.Trucks.Count > 0)
{
    Console.WriteLine("Trucks:");

    foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }

}