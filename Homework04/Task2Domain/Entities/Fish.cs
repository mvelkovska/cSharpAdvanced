using System;
using Task2Domain.Enums;

namespace Task2Domain.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public Size Size { get; set; }

        public Fish(string name, string type, int age, string color, Size size) : base(name, type, age)
        {
            if (string.IsNullOrEmpty(color) == false)
            {
                Color = color;
            }
            Size = size;
        }

        public override void PrintInfo()
        {
            PrintBasics();
            Console.WriteLine($"Color:{Color}|Size:{Size}");
        }

    }
}
