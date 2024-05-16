using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.DomainInterfaces
{
    public interface IActivity
    {
        void Update(Activity activity);
        List<Activity> GetActivitiesByName(string name);
        List<Activity> GetActivitiesByType(ActivityType type);
        void DeleteActivityByName(string name);
        void DeleteActivityByType(ActivityType type);
    }
}
