using Dogs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Domain.Database
{
    public class DogDb : Db<Dog>
    {
        public DogDb() : base() { }

        public void PrintAllDogsFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Dog dog = Dog.FromString(line);
                        Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading dogs from file: {ex.Message}");
            }
        }
    }
}
