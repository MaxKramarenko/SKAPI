using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Data
    {
        public GroupInfo Group { get; set;}

        [JsonProperty(PropertyName = "weeks")]             
        public ListWeek ListWeeks { get; set; } 

    }
}
