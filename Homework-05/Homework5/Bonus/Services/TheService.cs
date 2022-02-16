using System;
using System.Collections.Generic;
using System.Text;
using Bonus.Domain;
using System.IO;


namespace Bonus.Services
{
    public class TheService
    {
        private string _folderPath;
        private string _filePath;
        public TheService()
        {
            _folderPath = @"..\..\..\Exercise";
            _filePath = _folderPath + @"\people.txt";
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public void Log(User user)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string getInfo = user.PrintDetails();
                sw.WriteLine(getInfo);
                sw.WriteLine("======================");
            }
        }

    }
}
