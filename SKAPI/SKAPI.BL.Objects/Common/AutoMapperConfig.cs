using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SKAPI.BL.Objects.Schedule.Responce;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Resolvers;

namespace SKAPI.BL.Objects.Common
{
    public static class AutoMapperConfig    
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<TimeLine, ScheduleResponce>()
                .ForMember(dest => dest.Group,
                 opt => opt.MapFrom(src => src.Data.Group))
                 .ForMember(dest=> dest.Weeks,
                 opt => opt.ResolveUsing<WeekResolver>());

                config.CreateMap<Week, WeekResponce>()
                .ForMember(dest => dest.Number,
                opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.Days,
                opt=> opt.ResolveUsing<DayResolver>());

                config.CreateMap<Day, DaysResponce>()
                .ForMember(dest => dest.Lessons,
                opt => opt.MapFrom(dest => dest.Lessons));

                config.CreateMap<Lesson, LessonResponce>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name));
                
            });
        }
    }
}
