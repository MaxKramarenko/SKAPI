using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Basic
{
    public class JsonGroupResponce
    {
        public string statusCode { get; set; }
        public string timeStamp { get; set; }
        public string message { get; set; }
        public string debugInfo { get; set; }
        public object meta { get; set; }
        public object data { get; set; }
    }
}
