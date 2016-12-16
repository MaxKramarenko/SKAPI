using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.Request;
using SKAPI.Sevices.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SKAPI.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ScheduleController : ApiController
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();

        [HttpGet]
        [Route("schedule/search")]
        public JsonRequestResult Search([FromBody]ScheduleSearchRequest request)
        {
            return new JsonRequestResult(_scheduleService.Search(request));
        }

        [HttpGet]
        [Route("schedule/properties")]
        public JsonRequestResult GetProperties()
        {
            return new JsonRequestResult(_scheduleService.GetProperties());
        }

        [HttpGet]
        [Route("schedule/groups")]
        public JsonRequestResult GetAllGroups()
        {
            
            return new JsonRequestResult( _scheduleService.GetAllGroups());
        }

        [HttpGet]
        [Route("schedule/groups/{name:string}")]
        public JsonRequestResult GetGroupByName()
        {
          return new JsonRequestResult(_scheduleService.GetGroupByName());
        }

        [HttpGet]
        [Route("schedule/timetable/{id:int}")]
        public JsonRequestResult GetTimeTableByGroupID([FromUri]int id)
        {
            return new JsonRequestResult(_scheduleService.GetTimeTableByGroupID(id));
        }

        [HttpGet]
        [Route("schedule/timetable/{name:string}")]
        public JsonRequestResult GetTimeTableByGroupName([FromUri]string name)
        {
            return new JsonRequestResult(_scheduleService.GetTimeTableByGroupName(name));
        }

    }
}
