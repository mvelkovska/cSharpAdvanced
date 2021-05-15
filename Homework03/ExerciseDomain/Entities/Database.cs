using System.Collections.Generic;


namespace ExerciseDomain.Entities
{
    public static class Database
    {
        public static List<Vehicle> Vehicles { get; set; }

        static Database()
        {
            Vehicle firstVehicle = new Vehicle(1, "bike", 1999, 500);
            Vehicle secondVehicle = new Vehicle(2, "car", 2008, 600);
             Car car = new Car(3, "CAR", 2021, 700, new List<string>() { "Macedonia", "Moldova", "Germany" },400);
             Bike bike = new Bike(4, "BIKE", 2021, 800,"green");

            Vehicles = new List<Vehicle>() {firstVehicle,secondVehicle,car,bike };
        }
    }
}
