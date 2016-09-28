using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SKAPI.BL.Objects.Common
{
    public class WeekResolver : IValueResolver<TimeLine, ScheduleResponce, List<WeekResponce>>
    {
        public List<WeekResponce> Resolve(TimeLine source, ScheduleResponce destination, List<WeekResponce> destMember, ResolutionContext context)
        {
            destMember.Add(Mapper.Map<Week, WeekResponce>(source.Data.ListWeeks.FirtsWeek));
            destMember.Add(Mapper.Map<Week, WeekResponce>(source.Data.ListWeeks.SecondWeek));

            return destMember;
        }
    }
}
