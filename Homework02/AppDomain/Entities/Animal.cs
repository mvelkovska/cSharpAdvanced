using AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDomain.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        

        

        public Animal(string name, string breed, int age,string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("You must enter a name!");
            }

            if (string.IsNullOrEmpty(breed))
            {
                throw new Exception("You must enter a breed");
            }

            if (string.IsNullOrEmpty(color))
            {
                throw new Exception("You must enter a color!");
            }

            if (Age < 0) {

                throw new Exception("The age must be a positive number!");
            }

            Name = name;
            Breed = breed;
            Age = age;
            Color = color;
        }
        public void PrintBasicInfo() { //ovoj metod go dodadov kako plus
            Console.WriteLine($"Name: {Name} , Breed: {Breed} , Color: {Color} , Age: {Age}");
        }
        public abstract void PrintAnimal();
       

    }
}
