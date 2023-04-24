using HomeWorkThree.Enums;

namespace HomeWorkThree.AbstractClass
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }

        public BaseEntity(int id, string brand, string model, int maxSpeed, int horsePower, FuelType fuelType) 
        {
            Id = id;    
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            FuelType = fuelType;

        } 
        public abstract void Drive(string destinationName);
    }
}
