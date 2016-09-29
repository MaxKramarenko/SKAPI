using SKAPI.BL.Objects.Basic;
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
        public static GroupResponce ToGroup(this Group group)
        {
            return new GroupResponce()
            {
                FullName = group.FullName,
                ID = group.ID,
                Prefix = group.Prefix,
                Type = group.Type
            };
        }
    }
}
