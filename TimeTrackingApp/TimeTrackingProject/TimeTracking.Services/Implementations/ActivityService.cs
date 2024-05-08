using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Database;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class ActivityService<T> : IActivityService<T> where T : Activity
    {
        public IActivity<T> database;

        public List<Activity> getUserActivites(string username)
        {
            database.GetActivitiesByName(username);
        }

        public void StartActivity(Activity activity)
        {
            activity.StartTime = DateTime.Now;

            database.Update(activity);
            Console.WriteLine("Acitivity started");
        }

        public void StopActivity(Activity activity)
        {
            activity.EndAcitvity = DateTime.Now;

            database.Update(activity);
            Console.WriteLine("Acitivity stopped");
        }
    }
}
