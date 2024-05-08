using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.Database
{
    public class AcitivityRepository : IActivity
    {
        private List<Activity> activities;

        public AcitivityRepository()
        {
            activities = new List<Activity>();
        }
        public void AddActivity(Activity activity)
        {
           activities.Add(activity);
        }

        public void DeleteActivityByName(string name)
        {
            activities.RemoveAll(a => a.Name == name);
        }

        public void DeleteActivityByType(ActivityType type)
        {
            activities.RemoveAll(a => a.Type == type);
        }

        public List<Activity> GetActivitiesByName(string name)
        {
            return activities.FindAll(a => a.Name == name);
        }

        public List<Activity> GetActivitiesByType(ActivityType type)
        {
            return activities.FindAll(a => a.Type == type);
        }
    }
}
