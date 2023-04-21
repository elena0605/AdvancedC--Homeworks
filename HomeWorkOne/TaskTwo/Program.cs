//Car Service
//Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck that inherit from Vehicle and override the method Drive.
//Create 3 interfaces:
//ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
//IGasPump that has method PumpGas that works for all vehicles
//IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
//Implement each interface in a different class: CarWash, GasPump and RepairService.
//Implement all interfaces in one class CarCenter.
//Methods can be implemented with Console.Writeline or changing and checking bools (ex. isClean, isGasFull, isBroken...)

using TaskTwo.Entities;

Car car = new Car(false,false,false,false);
Truck truck = new Truck(false, false, true, true);
Car car1 = new Car(true,false,true,true);
CarCentar carCentar = new CarCentar();
carCentar.Cars.Add(car);
carCentar.Trucks.Add(truck);
carCentar.Cars.Add(car1);


// before vehicle visits the car service centar
Console.WriteLine("------Before vehicle service------");
truck.CheckVehicle();
car.CheckVehicle();
truck.WashTrailers();
truck.FixVehicle();
car1.Drive();

// service reparations
carCentar.CheckVehicle();

Console.WriteLine();
Console.WriteLine("------After vehicle service------");

// after visit
truck.CheckVehicle();
car.CheckVehicle();
car1.Drive();

