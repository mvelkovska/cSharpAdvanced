using System;
using System.Collections.Generic;

namespace ExerciseDomain.Entities
{
    public class Car : Vehicle
    {
        public List<string> Countries{ get; set; }

        int FuelTank { get; set; }

        public Car(int id, string type, int yearofproduction, int batchnumber,List<string>countries,int fueltank) : base(id, type, yearofproduction, batchnumber)
        {
            //List<string> Countries = new List<string>();
            Countries = countries;
            FuelTank = fueltank;
        }

         public override void PrintVehicle()
        {
            Console.WriteLine($"TYPE OF THE CAR: {Type} ");
            Console.WriteLine("COUNTRIES IN WHICH THE CAR IS PRODUCED:");
            if(Countries.Count == 0)
            {
                Console.WriteLine("No countries,sorry!");
            }

            else
                foreach(string c in Countries)
                {
                    Console.WriteLine(c);
                }
        }
    }
}
