﻿using SKAPI.BL.Objects.Common;
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
        [Route("schedule/weeks")]
        public JsonRequestResult getCurrentWeek()
        {
            return new JsonRequestResult(_scheduleService.getCurrentWeek());
        }

        [HttpGet]
        [Route("schedule/search")]
        public JsonRequestResult Search([FromBody]ScheduleSearchRequest request)
        {
            return new JsonRequestResult(_scheduleService.Search(request));
        }

        [HttpGet]
        [Route("schedule/groups/search/{id}")]
        public JsonRequestResult GroupSearch([FromUri]String id)
        {
            return new JsonRequestResult(_scheduleService.GroupSearch(id));
        }

        [HttpGet]
        [Route("schedule/groups/{id}")]
        public JsonRequestResult getGroupByName([FromUri]String id)
        {
            return new JsonRequestResult(_scheduleService.getGroupByName(id));
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
            return new JsonRequestResult(_scheduleService.GetAllGroups());
        }

        [HttpGet]
        [Route("schedule/timetable/{id}")]
        public JsonRequestResult GetTimeTableByGroupName([FromUri]String id)
        {
            return new JsonRequestResult(_scheduleService.GetTimeTableByGroupName(id));
        }
    }
}