using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class OtherHobbies : Activty
    {
        public string Name;

        public OtherHobbies(string name)
        {
            Name = name;
            Type = ActivityType.OtherHobbies;
        }
    }
}
