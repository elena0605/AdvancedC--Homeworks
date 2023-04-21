

using TaskTwo.Entities.Interfaces;

namespace TaskTwo.Entities
{
    public abstract class Vehicle: ICarWash 
    {
        public bool IsFixed { get; set; }   
        public bool IsChecked { get; set; } 
        public bool HasGas { get; set; }    

        public bool IsClean { get; set; }

        public Vehicle (bool Isfixed, bool Ischecked, bool Hasgas, bool Isclean)
        {
            IsFixed = Isfixed;
            IsChecked = Ischecked;
            HasGas = Hasgas;
            IsClean = Isclean;
        }
        public abstract void Drive();

        public void WashCars()
        {
            if (IsClean)
            {
                Console.WriteLine( "Your car does not need cleaning");
            }
            else 
            { 
                
                Console.WriteLine("You have to wash your car!");        
                    
              }
        }

        public void WashTrailers()
        {
            if (IsClean)
            {
                Console.WriteLine("Your trailer does not need cleaning");
            }
            else
            {

                Console.WriteLine("You have to wash your trailer!");

            }

        }
    }
}
