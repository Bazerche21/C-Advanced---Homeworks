using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class ActivityTracker : IActivityTracker
    {
        private Dictionary<ActivityType, int> activities = new Dictionary<ActivityType, int>();
        public void TrackActivity(ActivityType activity)
        {
            Console.WriteLine($"You have started tracking {activity}. Press Enter when you are done.");

            DateTime startTime = DateTime.Now;
            Console.ReadLine();

            DateTime endTime = DateTime.Now;
            int durationInMinutes = (int)(endTime - startTime).TotalMinutes;

            Console.WriteLine($"You spent {durationInMinutes} minutes {activity}.");

            if (activities.ContainsKey(activity))
            {
                activities[activity] += durationInMinutes;
            }
            else
            {
                activities.Add(activity, durationInMinutes);
            }

        }

        public void ViewActivityData()
        {
            Console.WriteLine("\nActivity Data:");

            foreach (var activity in activities)
            {
                Console.WriteLine($"{activity.Key}: {activity.Value} minutes");
            }
        }
    }
}
