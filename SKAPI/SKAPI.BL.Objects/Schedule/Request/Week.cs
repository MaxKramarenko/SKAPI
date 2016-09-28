using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SKAPI.BL.Objects.Schedule
{
    
    public class Week
    {
        [JsonProperty(PropertyName = "week_number")]
        public int Number { get; set; }
        //public List<Day> Days { get; set; } = new List<Day>();
        [JsonProperty(PropertyName = "days")]
        public ListDays Days { get; set; }
    }
}
