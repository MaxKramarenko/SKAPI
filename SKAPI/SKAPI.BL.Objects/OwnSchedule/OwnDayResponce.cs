using Newtonsoft.Json;
using SKAPI.BL.Objects.Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class OwnDayResponce
    {
        [JsonProperty(PropertyName = "day_name")]
        public string Name { get
            {
                var e = typeof(DayNameEnum).GetMember(((DayNameEnum)Enum.ToObject(typeof(DayNameEnum), Number)).ToString()).FirstOrDefault();
                DayNamesAttribute attribute = (DayNamesAttribute)e.GetCustomAttributes(typeof(DayNamesAttribute), false).FirstOrDefault();
                return attribute.Name;
            }
        }

        [JsonProperty(PropertyName = "day_number")]
        public DayNameEnum Number { get; set; }

        public List<Pair> Pairs { get; set; }
    }
}