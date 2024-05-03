using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public abstract class Activity : BaseEntity
    {
        public ActivityType Type;
        public override string getInfo()
        {
            throw new NotImplementedException();
        }
    }
}
