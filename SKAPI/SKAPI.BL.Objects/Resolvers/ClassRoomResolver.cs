using AutoMapper;
using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Resolvers
{
    public class ClassRoomResolver : IValueResolver<Lesson, LessonResponce, ClassRoom>
    {
        public ClassRoom Resolve(Lesson source, LessonResponce destination, ClassRoom destMember, ResolutionContext context)
        {
            destination.ClassRoom.Room = source.Room.Split('-')[0] == null ? "" : source.Room.Split('-')[0];
            destination.ClassRoom.Building = source.Room.Split('-')[1] == null ? "" : source.Room.Split('-')[1];
            return destMember;
        }
    }
}