using SKAPI.BL.Objects.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Schedule.Responce
{
    public class LessonResponce
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string Teacher { get; set; }
    }
}
