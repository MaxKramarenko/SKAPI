using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class Notice
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Note { get; set; }
    }
}
