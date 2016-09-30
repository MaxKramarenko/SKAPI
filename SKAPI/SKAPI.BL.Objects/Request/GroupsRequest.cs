using Newtonsoft.Json;
using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Request
{
    public class GroupsRequest
    {
        [JsonProperty("data")]
        public List<GroupInfo> groups { get; set; } = new List<GroupInfo>();
    }
}
