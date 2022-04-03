using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Task1.Domain;
using System.IO;

namespace Task1.Database
{
    public class DatabaseLogic
    {
        private string _FilePath;
        private string _FolderPath;

        public DatabaseLogic()
        {
            _FolderPath = @"..\..\..\Dogs";

            _FilePath = _FolderPath + $"\\dogs.json";

            //pravime lista vo konstruktorot i go povikuvame metodot kadeshto ja chitame listata

            if (!Directory.Exists(_FolderPath))
            {
                Directory.CreateDirectory(_FolderPath);
            }
            if (!File.Exists(_FilePath))
            {
                File.Create(_FilePath).Close();
            }

            Dog[] dogs = Read();

            if (dogs == null) //listata e prazna prvichno
            {

                Dog[] dogss = new Dog[0] { };
                Write(dogss);

            }

        }
            private void Write(Dog[] dogs) //tuka serijalizirame i zapisuvame
            {
                using (StreamWriter streamWriter = new StreamWriter(_FilePath))
                {
                    string jsonString = JsonConvert.SerializeObject(dogs);
                    streamWriter.Write(jsonString);
                }
            }

            private Dog[] Read()
            {
                using (StreamReader streamReader = new StreamReader(_FilePath))
                {
                    string content = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Dog[]>(content); //objectot
                }
            }



            public void Insert(Dog dog)
            {
                Dog[] dogs = Read();
                Array.Resize(ref dogs, dogs.Length + 1);
                dogs[dogs.Length - 1] = dog;
                Write(dogs);
            }

            
            public Dog[] GetAll()
        {
            return Read();
        }

        }
    }
