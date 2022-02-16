using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("Some of your inputs is invalid") 
        {
            //
        }
    }
}
