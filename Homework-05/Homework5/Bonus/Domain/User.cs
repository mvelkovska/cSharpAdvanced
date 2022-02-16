using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus.Domain
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string PrintDetails()
        {
            return $"{FirstName} {LastName} {Age}";
        }

    }
}
