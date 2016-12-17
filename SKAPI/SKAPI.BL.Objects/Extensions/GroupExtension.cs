using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Extensions
{
    public static class GroupExtension
    {
        public static GroupResponce ToGroup(this Schedule.Group group)
        {
            return new GroupResponce()
            {
                ID = group.ID,
<<<<<<< HEAD
                Prefix = group.Prefix,
                Okr = group.Okr,
                Url = group.Url,
                Type = group.Type
=======
                FullName = group.FullName,
                Prefix = group.Prefix,
                Type = group.Type,
                Url = group.Url,
                Okr = group.Okr
>>>>>>> v2
            };
        }

        public static List<GroupResponce> ToListGroup(this List<Schedule.Group> groups)
        {
            var result = new List<GroupResponce>();

            foreach (var group in groups)
            {
                result.Add(group.ToGroup());
            }

            return result;
        }
    }
}