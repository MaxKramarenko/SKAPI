using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKAPI.BL.Objects.Schedule.Responce;

namespace SKAPI.DAL.Repositories
{
    public class GroupRepository
    {
        public void GroupUpdate(object obj)
        {
            using (
               Repository.GetConnection()
                    .QueryMultiple("GroupInsert", obj, commandType: CommandType.StoredProcedure,
                        commandTimeout: int.MaxValue)) { }
        }

        public List<GroupResponce> Get(object obj)
        {
            using (var multi = Repository.GetConnection().QueryMultiple("dbo.GroupGet", obj, commandTimeout: int.MaxValue, commandType: CommandType.StoredProcedure))
            {
                var groups = multi.Read<GroupResponce>().ToDictionary(x => x.ID, x => x);

                return groups.Values.ToList();
            }
        }
    }
}
