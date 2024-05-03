using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class Exercising : Activity
    {
        public ExercisingType ExercisingType;

        public Exercising(ExercisingType exercisingType)
        {
            exercisingType = ExercisingType;
            Type = ActivityType.Exercising;
        }
    }
}
