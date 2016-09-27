using Newtonsoft.Json;
using SKAPI.BL.Objects.Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Day : DayBase
    {
       public List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
