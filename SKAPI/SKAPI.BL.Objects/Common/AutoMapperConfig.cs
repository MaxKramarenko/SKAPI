using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SKAPI.BL.Objects.Schedule.Responce;
using SKAPI.BL.Objects.Schedule;

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
                opt => opt.MapFrom(src => src.Number));
            });
        }
    }
}
