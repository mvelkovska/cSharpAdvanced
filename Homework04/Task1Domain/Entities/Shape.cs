
namespace Task1Domain.Entities
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public Shape(int id)
        {
            if (id > 0)
            {
                Id = id;
            }
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();


    }
}
