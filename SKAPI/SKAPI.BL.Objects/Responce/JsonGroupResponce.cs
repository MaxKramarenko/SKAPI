﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Basic
{
    public class JsonGroupResponce
    {
        public string StatusCode { get; set; }
        public string TimeStamp { get; set; }
        public string Message { get; set; }
        public string DebugInfo { get; set; }
        public object Meta { get; set; }
        public object Data { get; set; }
    }
}