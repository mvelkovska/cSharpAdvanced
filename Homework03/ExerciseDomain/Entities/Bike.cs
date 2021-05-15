using System;

namespace ExerciseDomain.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(int id, string type, int yearofproduction, int batchnumber,string color) : base(id, type, yearofproduction, batchnumber)
        {

            Color = color;
        }

         public override void PrintVehicle()
        {
            Console.WriteLine($"COLOR OF THE BIKE: {Color} YEAR OF PRODUCTION OF THE BIKE: {YearOfProduction} ");
        }
    }
}
