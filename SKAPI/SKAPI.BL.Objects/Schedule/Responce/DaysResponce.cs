using SKAPI.BL.Objects.Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Responce
{
    public class DaysResponce : DayBase
    {        
        public List<LessonResponce> Lessons { get; set; }
    }
}
