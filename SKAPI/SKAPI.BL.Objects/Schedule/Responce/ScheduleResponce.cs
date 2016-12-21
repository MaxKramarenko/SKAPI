using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Responce
{
    public class ScheduleResponce
    {
        public GroupResponce Group { get; set; }

        public List<WeekResponce> Weeks { get; set; }
    }
}
