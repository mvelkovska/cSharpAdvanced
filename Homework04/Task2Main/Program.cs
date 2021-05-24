using System;
using Task2Domain.Entities;
using Task2Domain.Enums;


namespace Task2Main
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Cat>.ListOfPets.Add(new Cat("Crnco", "domestic", 1, false, 8));
            PetStore<Pet>.ListOfPets.Add(new Cat("Sivco", "domestic", 2, false, 7));

            PetStore<Cat>.PrintThePet();
            Console.WriteLine("===========");
            PetStore<Dog>.ListOfPets.Add(new Dog("Rex","golden retriever",2,"dog food"));
            PetStore<Dog>.ListOfPets.Add(new Dog("Roxy", "Labrador", 3, "meat"));

            PetStore<Dog>.PrintThePet();
            Console.WriteLine("===========");
            PetStore<Fish>.ListOfPets.Add(new Fish("Nemo", "type1", 1, "orange",Size.Small));
            PetStore<Fish>.ListOfPets.Add(new Fish("Dory", "type2", 1, "blue", Size.Small));

            PetStore<Fish>.PrintThePet();
            Console.WriteLine("===========");
            PetStore<Fish>.BuyPet("nemo");
            Console.WriteLine("===========");
            PetStore<Dog>.BuyPet("Sparky");
            Console.WriteLine("===========");

            Console.ReadLine();
        }
    }
}
