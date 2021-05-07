using System;
using System.Collections.Generic;
using System.Text;
using AppDomain.Interfaces;

namespace AppDomain.Entities
{
    public class Dog : Animal,IDog
    {
        public bool KidFriendly { get; set; }

        public Dog(string name, string breed, int age, string color, bool kidfriendly) : base(name, breed, age, color)
        {
            KidFriendly = kidfriendly;
        }

        
        public void Bark()
        {
            Console.WriteLine($"The dog {Name} is barking!");
        }


        public override void PrintAnimal()
        {
            PrintBasicInfo();
            Console.WriteLine($"Kid friendly: {KidFriendly}");
        }

    }
}

