using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Teacher
    {
        [JsonProperty(PropertyName = "teacher_id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "teacher_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "teacher_full_name")]
        public string FullName { get; set; }
        [JsonProperty(PropertyName = "teacher_short_name")]
        public string ShortName { get; set; }
        [JsonProperty(PropertyName = "teacher_url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "teacher_rating")]
        public double Rate { get; set; }
    }
}
