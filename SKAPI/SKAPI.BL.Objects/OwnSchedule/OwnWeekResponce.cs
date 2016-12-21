using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class OwnWeekResponce
    {
        public OwnWeekResponce(int number, List<OwnDayResponce> days)
        {
            Number = number;
            Days = days;
        }

        public int Number { get; set; }
        public List<OwnDayResponce> Days { get; set; }
    }
}
