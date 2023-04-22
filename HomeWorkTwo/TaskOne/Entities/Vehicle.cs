

namespace TaskOne.Entities
{
  public class Vehicle
    {
        public int Id { get; set; } 
        public string Type { get; set; } = String.Empty;
        public int YearOfProduction { get; set; }   
        public int BatchNumber { get; set; }    
        public Vehicle(int id, string type, int yearOfProduction, int batchNumber) { 
            Id = id;    
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }  
        public Vehicle() 
        { 
        }
        public virtual void PrintVehicle()
        {
            Console.WriteLine($"The vehicle id is: {Id}, its type: {Type} and is produced in {YearOfProduction}.");
        }
    }
}
