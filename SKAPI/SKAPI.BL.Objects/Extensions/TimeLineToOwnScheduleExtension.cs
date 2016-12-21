using SKAPI.BL.Objects.OwnSchedule;
using System.Collections.Generic;

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
                    switch (pair.Day)
                    {
                        case 1:
                            day.Name = "Понеділок";
                            break;

                        case 2:
                            day.Name = "Вівторок";
                            break;

                        case 3:
                            day.Name = "Середа";
                            break;

                        case 4:
                            day.Name = "Четвер";
                            break;

                        case 5:
                            day.Name = "П'ятниця";
                            break;

                        case 6:
                            day.Name = "Субота";
                            break;

                        case 7:
                            day.Name = "Неділя";
                            break;
                    }
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
