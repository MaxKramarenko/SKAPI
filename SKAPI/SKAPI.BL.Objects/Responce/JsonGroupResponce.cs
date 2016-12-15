using Newtonsoft.Json;
using SKAPI.BL.Objects.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Basic
{
    public class JsonGroupResponce
    {
        public string StatusCode { get; set; }
        public string TimeStamp { get; set; }
        public string Message { get; set; }
        public string DebugInfo { get; set; }
        public Meta Meta { get; set; }
        [JsonProperty("data")]
        public List<Schedule.Group> Groups { get; set; }
    }
}
