using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Interfaces
{
    public abstract class DayBase
    {
        [JsonProperty(PropertyName = "day_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "day_number")]
        public int Number { get; set; }
    }
}
