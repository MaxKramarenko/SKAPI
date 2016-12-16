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

        public List<Pair> GetByName(string name)
        {
            return _repository.Get(new {Name = name });
        }

        public List<Pair> GetAll()
        {
            return _repository.Get(new { });
        }

        public Guid Update(Pair pair)
        {
            return _repository.Modify(pair);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(new { ID = id });
        }
    }
}
