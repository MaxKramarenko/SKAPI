using SKAPI.BL.Objects.OwnSchedule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SKAPI.DAL.Repositories
{
    public class ManagedScheduleRepository
    {
        public List<Pair> Get(object obj)
        {
            using (var multi = Repository.GetConnection().QueryMultiple("dbo.TimeTableGet", obj, commandType: CommandType.StoredProcedure, commandTimeout: int.MaxValue))
            {
                var leases = multi.Read<Pair>().ToDictionary(x => x.ID, x => x);

                return leases.Values.ToList();
            }
        }

        public Guid Modify(Pair pair)
        {
            return Repository.GetConnection().Query<Guid>("dbo.TimeTableInsert", new
            {
                ID = pair.ID,
                Name = pair.Name,
                Room = pair.Room,
                pair.Type,
                pair.Teacher,
                Number = pair.Number,
                Day = pair.Day,
                pair.Week,
                pair.StartTime,
                pair.EndTime
            }, commandType: CommandType.StoredProcedure, commandTimeout: int.MaxValue).First();
        }

        public void Delete(object obj)
        {
            Repository.GetConnection()
                .Execute("dbo.TimeTableDelete", obj, commandType: CommandType.StoredProcedure, commandTimeout: int.MaxValue);
        }

    }
}
