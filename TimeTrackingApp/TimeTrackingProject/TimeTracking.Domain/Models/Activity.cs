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
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndAcitvity { get; set; }

        public override string getInfo()
        {
            throw new NotImplementedException();
        }
    }
}
