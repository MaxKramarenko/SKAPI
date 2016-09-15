using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.Request;
using SKAPI.Sevices.Implementation;
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
        private readonly ScheduleService _scheduleService = new ScheduleService();

        [HttpGet]
        [Route("schedule/search")]
        public JsonRequestResult Search([FromBody]SheduleSearchRequest request)
        {
            return new JsonRequestResult(_scheduleService.Search(request));
        }

        [HttpGet]
        [Route("schedule/properties")]
        public JsonRequestResult GetProperties()
        {
            return new JsonRequestResult(_scheduleService.GetProperties());
        }
    }
}
