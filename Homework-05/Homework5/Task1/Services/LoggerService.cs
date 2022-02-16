using System;
using System.Collections.Generic;
using System.Text;
using Task1.Exceptions;
using System.IO;

namespace Task1.Services
{
    public class LoggerService
    {
        private string _folderPath;
        private string _filePath;
        private string theResult;
        public LoggerService()
        {
            _folderPath = @"..\..\..\Exercise";
            _filePath = _folderPath + @"\calculations.txt";
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public string Calculate()

        {
            Console.WriteLine("Enter the first number :");

            string number1 = Console.ReadLine();

            bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);


            Console.WriteLine("Enter the second number :");

            string number2 = Console.ReadLine();

            bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            if (checkNumber1 == true && checkNumber2 == true)
            {
                double sum = parsedNumber1 + parsedNumber1;
                theResult = $"{parsedNumber1} + {parsedNumber1} = {sum}";
                Console.WriteLine(theResult);
                return theResult;
            }

            else
            {
                Console.WriteLine("Some of your inputs are wrong!");
                throw new InvalidInputException();
            }

        }

        public void Log()
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true)) { 

                sw.WriteLine($"Time: {DateTime.Now}");
               sw.WriteLine($"The result: {theResult}");
                sw.WriteLine("======================");
            }
        }



    }
}
