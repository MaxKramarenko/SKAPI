using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Request
{
    public class SheduleSearchRequest
    {
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public string ClassName { get; set; }

        public Object ToDBRequest()
        {
            return new {
                GroupName = GroupName,
                TeacherName = TeacherName,
                ClassName = ClassName
            };
        }
    }
}
