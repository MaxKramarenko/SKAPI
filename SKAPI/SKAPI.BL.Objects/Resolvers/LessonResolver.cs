using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using SKAPI.BL.Objects.Common;

namespace SKAPI.BL.Objects.Resolvers
{
    public class LessonResolver : IValueResolver<Day,DaysResponce, List<LessonResponce>>
    {
        public List<LessonResponce> Resolve(Day source, DaysResponce destination, List<LessonResponce> destMember, ResolutionContext context)
        {
            AutoMapperConfig.RegisterMaps();

            foreach(var lesson in source.Lessons)
            {
                destMember.Add(Mapper.Map<Lesson, LessonResponce>(lesson));
            }

            return destMember;
        }
    }
}
