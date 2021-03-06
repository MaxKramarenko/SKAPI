﻿using System;
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
        public DayNameEnum Day { get; set; }

        public int Number { get; set;}

        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }

        public PairType Type { get; set; }

        public string StartTime { get; set; }
        public string EndTime { get; set; }

        //public List<Notice> Notices { get; set; }
        //public List<Notify> Notifies { get; set; }
        //public Color Color { get; set; }
    }
}
