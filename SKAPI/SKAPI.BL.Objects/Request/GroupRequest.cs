using Newtonsoft.Json;
using SKAPI.BL.Objects.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Request
{
    public class GroupRequest
    {
        [JsonProperty("data")]
        public Group group { get; set; } = new Group();
    }
}