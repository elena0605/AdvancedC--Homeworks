

namespace TaskOne.Entities
{
   static class Validator
    {
      public static void Validate(Vehicle vehicle)
        {
            try 
            {
                if (vehicle.Id == 0 && vehicle.Type == "" && vehicle.YearOfProduction == 0)
                {
                    throw new Exception("Please, instantiate an object with values different than zero or empty string!");

                }
                else
                {
                    Console.WriteLine("Correctly instantiated object");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
