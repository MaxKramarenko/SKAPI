using SKAPI.BL.Objects.OwnSchedule;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SKAPI.BL.Objects.Extensions
{
    public static class TimeLineToOwnScheduleExtension
    {
        public static OwnScheduleResponce ToResponce(this List<Pair> pairs)
        {
            var result = new OwnScheduleResponce();

            result.Weeks = new List<OwnWeekResponce>();
            result.Weeks.Add(new OwnWeekResponce(1, new List<OwnDayResponce>()));
            result.Weeks.Add(new OwnWeekResponce(2, new List<OwnDayResponce>()));

            foreach (Pair pair in pairs)
            {
                bool found = false;
                foreach(OwnDayResponce day in result.Weeks[pair.Week - 1].Days)
                {
                    if(day.Number == pair.Day)
                    {
                        found = true;
                        day.Pairs.Add(pair);
                        break;
                    }
                }
                if (!found)
                {
                    OwnDayResponce day = new OwnDayResponce();
                    day.Number = pair.Day;

                    day.Pairs = new List<Pair>();
                    day.Pairs.Add(pair);
                    result.Weeks[pair.Week - 1].Days.Add(day);
                }
            }

            foreach(OwnWeekResponce week in result.Weeks)
            {
                week.Days.Sort(delegate (OwnDayResponce x, OwnDayResponce y)
                {
                    return x.Number.CompareTo(y.Number);
                });

                foreach(OwnDayResponce day in week.Days)
                {
                    day.Pairs.Sort(delegate (Pair x, Pair y)
                     {
                         return x.Number.CompareTo(y.Number);
                     });
                }
            }

            return result;
        }
    }
}
