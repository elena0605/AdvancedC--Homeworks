

namespace TaskOne.Entities
{
   static class VehicleListDB
    {
        public static List<Vehicle> Vehicles;

        static VehicleListDB()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(1,"BMW",2023, 84683650,50,new List<string>{"Germany", "Austria","Japan"}),
                new Car(2,"Ford", 1999, 6365826,70,new List<string>{"USA", "Canada"}),
                new Car(3,"Mazda",2000,627365,40,new List<string>{"Italy", "France"}),
                new Bike(1,"BMX",2002,635736,"black"),
                new Bike(2,"Road",2022, 386834,"gray"),
                new Bike(2,"Mountain", 1999, 3536,"blue"),
            
            };

            
        }     

    }
}
