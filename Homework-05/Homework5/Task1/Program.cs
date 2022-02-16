using System;
using Task1.Services;
using Task1.Exceptions;

namespace Task1
{
    class Program
    {
        static LoggerService loggerService = new LoggerService();

        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    loggerService.Calculate();
                    loggerService.Log();
                }

                catch (InvalidInputException e)
                {
                    Console.WriteLine("There is a mistake");
                    // Console.WriteLine(e);
                }

            }
            Console.ReadLine();
        }
        }
    }

