using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class ListDays
    {
        [JsonProperty(PropertyName = "1")]
        public Day DayOne { get; set; }
        [JsonProperty(PropertyName = "2")]
        public Day DayTwo { get; set; }
        [JsonProperty(PropertyName = "3")]
        public Day DayThree { get; set; }
        [JsonProperty(PropertyName = "4")]
        public Day DayFour { get; set; }
        [JsonProperty(PropertyName = "5")]
        public Day DayFive { get; set; }
        [JsonProperty(PropertyName = "6")]
        public Day DaySix { get; set; }
    }
}
