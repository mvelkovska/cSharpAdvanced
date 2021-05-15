using ExerciseDomain.Entities;
using System;

namespace ExerciseMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            foreach (Vehicle v in Database.Vehicles)
            {
                Console.WriteLine($"{counter} vehicle:");
                v.PrintVehicle();
                Console.WriteLine($"Is valid : {Validator.Validate(v)}");
                counter++;
                Console.WriteLine("====================");
            }

          


            Console.ReadLine();
            
        }
    }
}
