using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Extensions
{
    public static class TimeLineToScheduleExtenssion
    {
        public static ScheduleResponce ToResponce(this TimeLine timeLine)
        {
            var result = new ScheduleResponce();

            result.Group = new GroupInfo()
            {
                FullName = timeLine.Data.Group.FullName,
                ID = timeLine.Data.Group.ID,
                Okr = timeLine.Data.Group.Okr,
                Prefix = timeLine.Data.Group.Prefix,
                Type = timeLine.Data.Group.Type,
                Url = timeLine.Data.Group.Url                
            };

            result.Weeks = new List<WeekResponce>();
            result.Weeks.Add(new WeekResponce() {
                Number = timeLine.Data.ListWeeks.FirtsWeek.Number,
                Days = new List<DaysResponce>()
                {
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DayOne.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DayOne.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DayOne.Lessons.ToLesson()                        
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DayTwo.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DayTwo.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DayTwo.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DayThree.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DayThree.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DayThree.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFour.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFour.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFour.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFive.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFive.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DayFive.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.FirtsWeek.Days.DaySix.Name,
                        Number = timeLine.Data.ListWeeks.FirtsWeek.Days.DaySix.Number,
                        Lessons = timeLine.Data.ListWeeks.FirtsWeek.Days.DaySix.Lessons.ToLesson()
                    },
                }
            });

            result.Weeks.Add(new WeekResponce()
            {
                Number = timeLine.Data.ListWeeks.FirtsWeek.Number,
                Days = new List<DaysResponce>()
                {
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DayOne.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DayOne.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DayOne.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DayTwo.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DayTwo.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DayTwo.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DayThree.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DayThree.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DayThree.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DayFour.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DayFour.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DayFour.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DayFive.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DayFive.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DayFive.Lessons.ToLesson()
                    },
                    new DaysResponce()
                    {
                        Name = timeLine.Data.ListWeeks.SecondWeek.Days.DaySix.Name,
                        Number = timeLine.Data.ListWeeks.SecondWeek.Days.DaySix.Number,
                        Lessons = timeLine.Data.ListWeeks.SecondWeek.Days.DaySix.Lessons.ToLesson()
                    },
                }
            });

            return result;
        }

        static List<LessonResponce> ToLesson(this List<Lesson> lessons)
        {
            var result = new List<LessonResponce>();

            foreach(var lesson in lessons)
            {
                result.Add(new LessonResponce()
                {
                    Name = lesson.Name,
                    Teacher = lesson.TeacherName,
                    Type = lesson.Type,
                    ClassRoom = lesson.ToClassRoom()
                });
            }

            return result;
        }

        static ClassRoom ToClassRoom(this Lesson lesson)
        {
            var result = new ClassRoom();

            result.Room = lesson.Room.Split('-')[0] == null ? "" : lesson.Room.Split('-')[0];
            result.Building = lesson.Room.Split('-')[1] == null ? "" : lesson.Room.Split('-')[1];

            return result;
        }
    }
}
