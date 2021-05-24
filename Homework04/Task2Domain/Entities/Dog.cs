using System;


namespace Task2Domain.Entities
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public Dog(string name, string type, int age, string favouriteFood) : base(name, type, age)
        {
            if (string.IsNullOrEmpty(favouriteFood) == false)
                FavouriteFood = favouriteFood;
        }

        public override void PrintInfo()
        {
            PrintBasics();
            Console.WriteLine($"Favourite food: {FavouriteFood}");
        }

    }
}
