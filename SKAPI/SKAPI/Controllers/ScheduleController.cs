using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SKAPI.Controllers
{
    public class ScheduleController : ApiController
    {
        [HttpGet]
        [Route("schedule/search")]
        public JsonRequestResult Search([FromBody]SheduleSearchRequest request)
        {
            return new JsonRequestResult("");
        }

        /*public Json GetGroups()
        {
            return new NotImplementedException();
        }*/
        [HttpGet]
        [Route("schedule/properties")]
        public JsonRequestResult GetProperties()
        {
            return new JsonRequestResult("");
        }
    }
}
