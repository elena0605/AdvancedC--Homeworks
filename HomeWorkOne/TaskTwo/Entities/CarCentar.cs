
using TaskTwo.Entities.Interfaces;

namespace TaskTwo.Entities
{
   public class CarCentar : ICarWash, IGasPump, IRepairService
    {
       public List<Car> Cars { get; set; } = new List<Car>();
       public List<Truck> Trucks { get; set; } = new List<Truck>();

      
        public   void CheckVehicle() 
        {
          foreach(var truck in Trucks)
            {
                if(truck.IsChecked == false) 
                {
                    truck.IsChecked = true;
                }
            }

          foreach(var car in Cars)
            {
                if(car.IsChecked == false) 
                { 
                    car.IsChecked = true;   
                }
            }
          
            
        }

        public void FixVehicle()
        {
            foreach (var truck in Trucks)
            {
                if (truck.IsFixed == false)
                {
                    truck.IsFixed = true;
                }
            }

            foreach (var car in Cars)
            {
                if (car.IsFixed == false)
                {
                    car.IsFixed = true;
                }
            }
        }

        public void PumpGas()
        {
            foreach (var truck in Trucks)
            {
                if (truck.HasGas == false)
                {
                    truck.HasGas = true;
                }
            }

            foreach (var car in Cars)
            {
                if (car.HasGas == false)
                {
                    car.HasGas = true;
                }
            }

        }

        public void WashCars()
        {
            foreach (var truck in Trucks)
            {
                if (truck.IsClean == false)
                {
                    truck.IsClean = true;
                }
            }

            foreach (var car in Cars)
            {
                if (car.IsClean == false)
                {
                    car.IsClean = true;
                }
            }

        }

        public void WashTrailers()
        {
            foreach (var truck in Trucks)
            {
                if (truck.IsClean == false)
                {
                    truck.IsClean = true;
                }
            }

            foreach (var car in Cars)
            {
                if (car.IsClean == false)
                {
                    car.IsClean = true;
                }
            }
        }
    }
}
