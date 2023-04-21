

using TaskTwo.Entities.Interfaces;

namespace TaskTwo.Entities
{
    public class Truck : Vehicle, IGasPump, IRepairService
    {

        public Truck (bool Isfixed, bool Ischecked, bool Hasgas, bool Isclean) : base(Isfixed, Ischecked, Hasgas, Isclean)
        {

        }
        public void CheckVehicle()
        {
            if (IsChecked)
            {
                Console.WriteLine("Your truck has passed the service checks");
            }
            else
            {
                Console.WriteLine("Your truck has not passed the service checks");
            }
        }

        public override void Drive()
        {
            if (IsFixed && IsChecked && HasGas)
            {
                Console.WriteLine("You are allowed to drive your truck");
            }
            else
            {
                Console.WriteLine("You should take your truck to a service before considering to drive!");
            }
        }

        public void FixVehicle()
        {
            if (IsFixed)
            {
                Console.WriteLine("Your truck has been repaired");

            }
            else
            {
                Console.WriteLine("Your truck has not been repaired");
            }
        }

        public void PumpGas()
        {
            if (HasGas)
            {
                Console.WriteLine("Your truck has full gas tank");
            }
            else
            {
                Console.WriteLine("Your truck has not enough gas to drive");
            }
        }
    }
}
