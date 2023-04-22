



using System.Threading.Channels;

namespace TaskOne.Entities
{
   public class Car :Vehicle    
    {
        public int FuelTank { get; set; }   
       public List<string> Countries { get; set; } = new List<string>();

        public Car()
        {

        }
        public Car (int id, string type, int yearOfProduction, int batchNumber,int fuelTank,List<string> countries ) :base(id,type,yearOfProduction,batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }

       

        public override void PrintVehicle()
        {
            Console.WriteLine($"The car's model is {Type} and it is produced in {string.Join(", ", Countries.Select(country => country.ToString()))}");
        }




    }
}
