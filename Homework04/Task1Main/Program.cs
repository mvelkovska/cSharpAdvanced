using System;
using Task1Domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Task1Main
{
    class Program
    {

        static void Main(string[] args)
        {

            GenericDatabase<Circle>.Shapes.Add(new Circle(1, 15.2));
            GenericDatabase<Circle>.Shapes.Add(new Circle(2, 30.5));
            GenericDatabase<Rectangle>.Shapes.Add(new Rectangle(3, 20, 21));
            GenericDatabase<Rectangle>.Shapes.Add(new Rectangle(4, 22.2, 33.3));

            /*for (int i = 0; i < GenericDatabase<Circle>.Shapes.Count; i++)
            {
                Console.WriteLine(GenericDatabase<Circle>.Shapes[i].GetPerimeter());
                Console.WriteLine(GenericDatabase<Circle>.Shapes[i].GetArea());
                GenericDatabase<Circle>.Shapes[i].PrintInfoCircle();
            }*/

            foreach (Circle circle in GenericDatabase<Circle>.Shapes)
            {
                circle.PrintInfoCircle();
            }

            foreach (Rectangle rec in GenericDatabase<Rectangle>.Shapes)
            {
                rec.PrintInfoRectangle();
            }

            Console.ReadLine();
        }
    }
}
