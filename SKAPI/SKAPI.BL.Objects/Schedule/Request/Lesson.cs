using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule
{
    public class Lesson
    {
        [JsonProperty(PropertyName = "lesson_id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "group_id")]
        public int GroupID { get; set; }
        [JsonProperty(PropertyName = "day_number")]
        public int DayNumber { get; set; }
        [JsonProperty(PropertyName = "day_name")]
        public string DayName { get; set; }
        [JsonProperty(PropertyName = "lesson_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "lesson_full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "lesson_number")]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "lesson_room")]
        public string Room { get; set; }
        [JsonProperty(PropertyName = "lesson_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "teacher_name")]
        public string TeacherName { get; set; }
        [JsonProperty(PropertyName = "lesson_week")]
        public int WeekNumber { get; set; }

        [JsonProperty(PropertyName = "time_start")]
        public string Start { get; set; }
        [JsonProperty(PropertyName = "time_end")]
        public string End { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public double Rate { get; set; }

        [JsonProperty(PropertyName = "teachers")]
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        [JsonProperty(PropertyName = "rooms")]
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}