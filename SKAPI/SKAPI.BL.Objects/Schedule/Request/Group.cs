using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Group
    {
        [JsonProperty(PropertyName = "group_id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "group_full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "group_prefix")]
        public string Prefix { get; set; }
<<<<<<< HEAD:SKAPI/SKAPI.BL.Objects/Schedule/Request/GroupInfo.cs
        [JsonProperty(PropertyName = "group_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "group_url")]
        public string Url { get; set; }
=======

        [JsonProperty(PropertyName = "group_type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "group_url")]
        public string Url { get; set; }

>>>>>>> v2:SKAPI/SKAPI.BL.Objects/Schedule/Request/Group.cs
        [JsonProperty(PropertyName = "group_okr")]
        public string Okr { get; set; }
    }
}