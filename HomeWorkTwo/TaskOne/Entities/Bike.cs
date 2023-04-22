
namespace TaskOne.Entities
{
  public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;

        public Bike () 
        {
        }  
        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color):base(id,type,yearOfProduction,batchNumber) 
        {
            Color = color; 
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($"The bike has {Color} color and is from {YearOfProduction}");
        }
    }
}
