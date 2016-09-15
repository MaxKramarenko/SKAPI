using SKAPI.BL.Objects.OwnSchedule;
using SKAPI.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.Sevices.Implementation
{
    public class ManagedScheduleServices
    {
        private readonly ManagedScheduleRepository _repository = new ManagedScheduleRepository();

        public Pair GetScheduleByID(Guid id)
        {
            return _repository.Get(new {ID = id }).FirstOrDefault();
        }

        public List<Pair> GetAll()
        {
            return _repository.Get(new { });
        }

        public Boolean Update(Pair pair)
        {
            return _repository.Update(pair);
        }

        public Boolean Delete(Guid id)
        {
            return _repository.Delete(new { ID = id });
        }
    }
}
