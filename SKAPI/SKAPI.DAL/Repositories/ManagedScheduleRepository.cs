using SKAPI.BL.Objects.OwnSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.DAL.Repositories
{
    public class ManagedScheduleRepository
    {
        public List<Pair> Get(Object obj)
        {
            return new List<Pair>();
        }

        public Boolean Update(Pair pair)
        {
            return true;
        }

        public Boolean Delete(Object obj)
        {
            return false;
        }

    }
}
