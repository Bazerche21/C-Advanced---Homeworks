using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Domain.Entities
{
    public class Dog : BasicEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public override string getInfo()
        {
            return $"{Name} is {Age} years old and has {Color}!";
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Dog FromString(string json)
        {
            return JsonConvert.DeserializeObject<Dog>(json);
        }
        }
    }
