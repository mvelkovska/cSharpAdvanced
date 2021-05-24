
namespace Task1Domain.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public const double Pi = 3.14159;

        public Circle(int id,double radius) : base(id)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
        }
        public override double GetArea() {

            return Pi * Radius * Radius;
        }

        public override double GetPerimeter()
        {

            return 2 * Pi * Radius;
        }

    }
}
