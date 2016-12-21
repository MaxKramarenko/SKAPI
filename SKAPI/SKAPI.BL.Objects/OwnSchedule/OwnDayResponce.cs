using SKAPI.BL.Objects.Schedule.Interfaces;
using System.Collections.Generic;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class OwnDayResponce : DayBase
    {
        public List<Pair> Pairs { get; set; }
    }
}