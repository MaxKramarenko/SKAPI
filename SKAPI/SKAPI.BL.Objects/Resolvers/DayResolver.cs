using AutoMapper;
using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Resolvers
{
    public class DayResolver : IValueResolver<Week, WeekResponce, List<DaysResponce>>
    {
        public List<DaysResponce> Resolve(Week source, WeekResponce destination, List<DaysResponce> destMember, ResolutionContext context)
        {
            AutoMapperConfig.RegisterMaps();

            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DayOne));
            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DayTwo));
            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DayThree));
            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DayFour));
            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DayFive));
            destMember.Add(Mapper.Map<Day, DaysResponce>(source.Days.DaySix));

            return destMember;
        }
    }
}
