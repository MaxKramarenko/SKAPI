using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SKAPI.BL.Objects.Common;
using SKAPI.Sevices.Implementation;

namespace SKAPI.Controllers
{
    public class GroupController : ApiController
    {
        private readonly GroupService _groupService = new GroupService();

        [HttpGet]
        [Route("group")]
        public JsonRequestResult GetAllGroups()
        {

            return new JsonRequestResult(_groupService.GetAllGroups());
        }

        [HttpGet]
        [Route("group/{name}")]
        public JsonRequestResult GetGroupByName(string name)
        {
            return new JsonRequestResult(_groupService.GetGroupByName(name));
        }
    }
}
