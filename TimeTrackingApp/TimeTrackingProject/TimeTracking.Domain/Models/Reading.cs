using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class Reading : Activity
    {
        public int Pages;

        public ReadingType ReadingType;

        public Reading(int pages, ReadingType readingType) 
        {
            Pages = pages;
            ReadingType = readingType;
            Type = ActivityType.Reading;
        }
    }
}
