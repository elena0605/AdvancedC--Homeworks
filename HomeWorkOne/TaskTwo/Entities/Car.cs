
using TaskTwo.Entities.Interfaces;

namespace TaskTwo.Entities
{
    public class Car : Vehicle, IGasPump, IRepairService

    {

        public Car (bool Isfixed, bool Ischecked, bool Hasgas, bool Isclean) : base( Isfixed,  Ischecked, Hasgas,  Isclean)
        {

        }

        public void CheckVehicle()
        {
            if(IsChecked)
            {
                Console.WriteLine("Your car has passed the service checks");
            }
            else
            {
                Console.WriteLine("Your car has not passed the service checks");
            }
           
        }

        public override void Drive()
        {
            if(IsFixed && IsChecked && HasGas)
            {
                Console.WriteLine("You are allowed to drive your car");
            }
            else
            {
                Console.WriteLine("You should take your car to a service before considering to drive!");
            }

        }

        public void FixVehicle()
        {
            if(IsFixed) 
            {
                Console.WriteLine("Your car has been repaired");
            
            }
            else 
            {
                Console.WriteLine("Your car has not been repaired");
            }
            
        }

        public void PumpGas()
        {
            if(HasGas) 
            {
                Console.WriteLine("Your car has full gas tank");
            }
            else
            {
                Console.WriteLine("Your car has not enough gas to drive");
            }
            
        }
    }

}
