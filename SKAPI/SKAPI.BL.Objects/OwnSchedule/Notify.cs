using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class Notify
    {
        public Guid ID{get;set;}
        public Guid PairID { get; set; }
        public DateTime ReminderDate { get; set;}
    }
}
