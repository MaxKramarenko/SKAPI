using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class Pair
    {
        public Guid? ID { get; set; }

        public int Week { get; set; }
        public int Day { get; set; }

        public int Number { get; set;}

        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }

        public PairType Type { get; set; }

        public List<Notice> Notices { get; set; }
        public List<Notify> Notifies { get; set; }
        public Color Color { get; set; }

        public Pair()
        {
            Notices = new List<Notice>();
            Notifies = new List<Notify>();
            Type = new PairType();
            Color = new Color();
        }
    }
}
