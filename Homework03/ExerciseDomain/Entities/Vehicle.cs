using System;

namespace ExerciseDomain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int YearOfProduction { get; set; }

        public int BatchNumber { get; set; }
       

        public Vehicle(int id,string type,int yearofproduction,int batchnumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearofproduction;
            BatchNumber = batchnumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, TYPE: {Type}, YEAR OF PRODUCTION: {YearOfProduction} ");
        }
    }
}
