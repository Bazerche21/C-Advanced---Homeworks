using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.DomainInterfaces
{
    public interface IActivityTracker
    {
        void TrackActivity(ActivityType activity);
        void ViewActivityData();
    }
}
