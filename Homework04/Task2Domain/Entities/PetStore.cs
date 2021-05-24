using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2Domain.Entities
{
    public static class PetStore<T> where T : Pet
    {
        public static List<T> ListOfPets { get; set; }

        static PetStore()
        {
            ListOfPets = new List<T>();
        }

        public static void PrintThePet()
        {
            foreach (T item in ListOfPets)
            {
                item.PrintInfo();
            }
        }
        public static void BuyPet(string name)
        {
            T findThePet = ListOfPets.Find(x => x.Name.ToLower() == name.ToLower());

            if (findThePet != null)
            {
                ListOfPets.Remove(findThePet);
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine($"The pet with the name {findThePet.Name} was successfully removed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The name {name} doesn't exist!");
            }

            Console.ResetColor();
        }

    }
}
