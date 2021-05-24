using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Domain.Entities
{
    public abstract class Pet
    {

        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }

        public Pet(string name,string type,int age)
        {
            if (string.IsNullOrEmpty(name) == false)
            {
                Name = name;
            }

            if (string.IsNullOrEmpty(type) == false)
            {
                Type = type;
            }

            if (age > 0)
            {
                Age = age;
            }
        }

       public abstract void PrintInfo();

        public void PrintBasics()
        {
            Console.Write($"Name:{Name}|Type:{Type}|Age: {Age}|");
        }

    }
}
