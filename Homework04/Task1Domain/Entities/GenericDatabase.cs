using System;
using System.Collections.Generic;


namespace Task1Domain.Entities
{
    public static class GenericDatabase<T> where T : Shape
    {
        public static List<T> Shapes { get; set; }

        static GenericDatabase()
        {
            Shapes = new List<T>();
        }

       

       /* public static void PrintTypesOfAllElements()
        {
            foreach (T item in Shapes)
            {
                Console.WriteLine(item.GetType());
            }
        }*/

        public static void PrintArea()
        {
            foreach (T item in Shapes)
            {
                Console.WriteLine($" The area is: {item.GetArea()}");
            }
        }

        public static void PrintPerimeter()
        {
            foreach (T item in Shapes)
            {
                Console.WriteLine($" The perimeter is: {item.GetPerimeter()}");
            }
        }



    }
}
