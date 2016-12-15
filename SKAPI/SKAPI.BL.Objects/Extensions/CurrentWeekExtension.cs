using SKAPI.BL.Objects.Schedule.Request;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Extensions
{
    public static class CurrentWeekExtension
    {
        public static CurrentWeekResponce ToCurrentWeek(this CurrentWeek currentweek)
        {
            var result = new CurrentWeekResponce();

            result.CurrentWeek = currentweek.currentweek;

            return result;
        }
    }
}