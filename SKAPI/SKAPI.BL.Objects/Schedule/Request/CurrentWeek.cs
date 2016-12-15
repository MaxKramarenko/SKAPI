using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Request
{
    public class CurrentWeek
    {
        [JsonProperty("data")]
        public int currentweek { get; set; }
    }
}