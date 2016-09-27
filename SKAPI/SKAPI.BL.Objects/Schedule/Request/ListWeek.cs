using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class ListWeek
    {
        [JsonProperty(PropertyName = "1")]
        public Week FirtsWeek { get; set; }
        [JsonProperty(PropertyName = "2")]
        public Week SecondWeek { get; set; }
    }
}
