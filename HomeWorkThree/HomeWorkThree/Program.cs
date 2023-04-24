//Crate a car dealership app. Make a BaseEntity abstract class with properties Id, Brand, Model, MaxSpeed, HorsePower, FuelType and a abstract method Drive(string destinationName).
//Create other classes for JapaneseCar, GermanCar, FrenchCar, ItalianCar, AmericanCar that will inherit from the BaseEntity.
//Make a generic database named GenericDb that will only take in classes that INHERIT FROM THE BaseEntity.
//In the generic database create methods for Inserting a car, Get a car by id, Print all cars.
//Create an extension method that will change the color of a text, just like we learned in class.

using HomeWorkThree.DerivedClasses;
using HomeWorkThree.Enums;
using HomeWorkThree.GenericClass;


JapaneseCar japaneseCar = new JapaneseCar(1,"Toyota", "Toyota Avalon",200,60,FuelType.Diesel);
JapaneseCar japaneseCar1 = new JapaneseCar(2, "Nissan", "Nissan Armada", 150, 70, FuelType.Diesel);
GermanCar germanCar = new GermanCar(1, "BMW", "BMW X1", 180, 40, FuelType.Gasoline);
FrenchCar frenchCar = new FrenchCar(1, "Renault", "Renault Clio", 100, 60, FuelType.BioDiesel);
ItalianCar italianCar = new ItalianCar(1, "Alfa Romeo", "Giulia Sprint", 150, 70, FuelType.Gasoline);
AmericanCar americanCar = new AmericanCar(1,"Ford","Ford Mustang", 200,67, FuelType.Diesel);



GenericDb<JapaneseCar>.Insert(japaneseCar);
GenericDb<JapaneseCar>.Insert(japaneseCar1);
GenericDb<GermanCar>.Insert(germanCar);
GenericDb<FrenchCar>.Insert(frenchCar);
GenericDb<ItalianCar>.Insert(italianCar);
GenericDb<AmericanCar>.Insert(americanCar);


GenericDb<JapaneseCar>.PrintAll();


japaneseCar.Drive("Tokyo");