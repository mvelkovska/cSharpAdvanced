using System;
using Task1.Domain;
using Task1.Database;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;


namespace Task1
{
    
   
    class Program
    {
        public static DatabaseLogic dogsDatabase = new DatabaseLogic();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter name of the dog: ");
                string dogName = Console.ReadLine();

                Console.WriteLine("Enter color of the dog: ");
                string dogColor = Console.ReadLine();


                Console.WriteLine("Enter age of the dog: ");
                string dogAge = Console.ReadLine();

                int parsedInput = int.Parse(dogAge);

                Dog dog = new Dog() { };

                dog.Name = dogName;
                dog.Color = dogColor;
                dog.Age = parsedInput;

                dogsDatabase.Insert(dog);



                Console.WriteLine("Do you want to enter new dog: y or n");

                string userAnswer = Console.ReadLine();

                if(userAnswer.ToLower() == "y")
                {
                    continue;
                }

                else
                {
                    break;
                }

            }

            Dog[] dogg=dogsDatabase.GetAll();
            foreach(Dog dog in dogg)
            {
                Console.WriteLine($"The dog has name {dog.Name}, color {dog.Color} and age {dog.Age} :)");
            }


            Console.WriteLine("Goodbye, have a nice day!");
            Console.ReadLine();
        }
    }
}
