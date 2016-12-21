using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public enum DayNameEnum
    {
        [DayNamesAttribute("Понеділок")]
        Monday = 1,

        [DayNamesAttribute("Вівторок")]
        Tuesday = 2,

        [DayNamesAttribute("Середа")]
        Wensday = 3,

        [DayNamesAttribute("Четвер")]
        Thursday = 4,

        [DayNamesAttribute("П'ятниця")]
        Friday = 5,

        [DayNamesAttribute("Субота")]
        Saturday = 6,

        [DayNamesAttribute("Неділя")]
        Sunday = 7
    }
}
