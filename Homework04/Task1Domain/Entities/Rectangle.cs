
namespace Task1Domain.Entities
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle(int id, double length,double width) : base(id)
        {
            if (length > 0)
                Length = length;


            if (width > 0)
                Width = width;



        }
        public override double GetArea()
        {

            return Length * Width;
        }

        public override double GetPerimeter()
        {
            double result = ((2 * Length) + (2 * Width));
            return result;
        }

    }
}
