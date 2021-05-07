using System;
using System.Collections.Generic;
using System.Text;
using AppDomain.Interfaces;

namespace AppDomain.Entities
{
    public class Cat : Animal, ICat
    {
        public bool IsTame { get; set; }

        public Cat(string name, string breed, int age, string color, bool istame) : base(name, breed, age, color)
        {
            IsTame = istame;
        }


        public void Eat(string food)
        {
            Console.WriteLine($"The cat {Name} is eating {food} mnjam!");
        }


        public override void PrintAnimal()
        {
            PrintBasicInfo();
            Console.WriteLine($"is tame: {IsTame}");
        }

    }
}

