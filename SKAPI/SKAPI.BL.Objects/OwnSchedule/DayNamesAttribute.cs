using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.OwnSchedule
{
    public class DayNamesAttribute : Attribute
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DayNamesAttribute(string name)
        {
            this._name = name;
        }
    }
}
