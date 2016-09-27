using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Room
    {
        [JsonProperty(PropertyName = "room_id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "room_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "room_latitude")]
        public double latitude { get; set; }
        [JsonProperty(PropertyName = "room_longitude")]
        public double longitute { get; set; }
    }
}
