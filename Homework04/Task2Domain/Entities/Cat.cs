using System;


namespace Task2Domain.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, string type, int age, bool isLazy, int livesLeft) : base(name, type, age)
        {
            if (string.IsNullOrEmpty(name) == false)
                Name = name;

            if (string.IsNullOrEmpty(type) == false)
                Type = type;

            if (isLazy == true || isLazy == false)
                IsLazy = isLazy;

            if (livesLeft > 0)
                LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            PrintBasics();
            Console.WriteLine($"Is lazy:{IsLazy}|Lives left: {LivesLeft}");
        }

    }
}
