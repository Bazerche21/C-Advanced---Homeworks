using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Interfaces
{
    public interface IActivityService<T> where T : Activity
    {
        void StartActivity(Activity activity);
        void StopActivity(Activity activity);
        List<Activity> getUserActivites(string username);
    }
}
