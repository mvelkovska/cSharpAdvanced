using System;
using System.Collections.Generic;
using System.Text;

namespace Task1Domain.Entities
{
    public static class ExtensionMethod
    {
        //Add extension methods for Circle and Rectangle, that print info for these types.

        public static void PrintInfoCircle(this Circle circle)
        {
            Console.WriteLine($"Info about circle-> ID: {circle.Id}, RADIUS {circle.Radius}, PERIMETER: {circle.GetPerimeter()}, AREA: {circle.GetArea()}");
        }

        public static void PrintInfoRectangle(this Rectangle rec)
        {
            Console.WriteLine($"Info about rectangle-> ID: {rec.Id}, WIDTH {rec.Width}, LENGTH: {rec.Length},PERIMETER: {rec.GetPerimeter()}, AREA: {rec.GetArea()}");
        }

    }
}
