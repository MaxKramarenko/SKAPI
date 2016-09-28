using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Responce
{
    public class WeekResponce
    {
        public int Number { get; set; }
        public List<DaysResponce> Days { get; set; }
    }
}
