using AppDomain.Entities;
using AppDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cat Mimi = new Cat("Mimi", "persian cat", 3, "black", true);
                Cat Kiki = new Cat("Kiki", "bengal cat", 2, "brown", false);
                Cat Viki = new Cat("Viki", "savannah cat", 6, "brown", true);
                Cat Siki = new Cat("Siki", "somali cat", 7, "grey", false);


                List<Cat> cats = new List<Cat>()
            {
                Mimi,Kiki,Viki,Siki
            };

                List<Dog> dogs = new List<Dog>()
            {
                new Dog("Bak","golden retiever",3,"orange",true),
                new Dog("Dzeki","german shepherd",2,"brown",true),
                new Dog("Koki","rottweiler",6,"brown",true),
                new Dog("Baky","poodle",7,"black",false)



            };
                Console.WriteLine("CAT KIKI:");
                Kiki.Eat("Fish");
                Kiki.PrintAnimal();

                Console.WriteLine("=====");

                Console.WriteLine("CAT VIKI:");
                Viki.Eat("Cat food");
                Viki.PrintAnimal();

                Console.WriteLine("=====");

                Dog TheDogBak = dogs.FirstOrDefault(x => x.Name == "Bak");
                Console.WriteLine("DOG BAK:");
                TheDogBak.PrintAnimal();
                TheDogBak.Bark();

                Console.WriteLine("=====");
            
                Dog TheDogDzeki = dogs.FirstOrDefault(x => x.Name == "Dzeki");
                Console.WriteLine("DOG DZEKI:");
                TheDogDzeki.PrintAnimal();
                TheDogDzeki.Bark();

                Cat Mima = new Cat("Mima", "persian cat", 3, "black", true);
                Dog Dzoni = new Dog("Dzoni", "labrador", 2, "brown", true);



                Console.WriteLine("BONUS:");
                List<Animal> animals = new List<Animal>()
                {
                     Mima,Dzoni

                };

                foreach (Animal animal in animals)
                {
                   // Console.WriteLine(animal.GetType());

                    if (animal.GetType() == Mima.GetType()) {

                        ((Cat)animal).Eat("something");
                    }

                    else if (animal.GetType() == Dzoni.GetType())
                    {
                        ((Dog)animal).Bark();
                    }

                    else
                    {
                        Console.WriteLine("No dog/cat. Sorry");
                    }
                }

            }


            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Input could not be parsed!");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Index was invalid!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Object was null!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You broke the memory!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The most general exception!");
            }

            Console.ReadLine();
        }
    }
}
