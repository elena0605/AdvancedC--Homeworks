using HomeWorkThree.AbstractClass;
using HomeWorkThree.Enums;

namespace HomeWorkThree.DerivedClasses
{
    public class FrenchCar : BaseEntity
    {

        public FrenchCar(int id, string brand, string model, int maxSpeed, int horsePower, FuelType fuelType) : base(id, brand, model, maxSpeed, horsePower, fuelType)
        {

        }
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"This French car will take you to {destinationName}");
        }
    }
}
