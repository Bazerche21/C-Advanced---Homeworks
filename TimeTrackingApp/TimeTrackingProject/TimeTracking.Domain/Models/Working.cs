using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class Working : Activity
    {
        public WorkingType WorkingType;

        public Working(WorkingType workingType)
        {
            WorkingType = workingType;
            Type = ActivityType.Working;
        }
    }
}
