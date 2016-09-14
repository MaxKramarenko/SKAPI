using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.OwnSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SKAPI.Controllers
{
    public class ManagedScheduleController : ApiController
    {
        [HttpGet]
        [Route("managedschedule/{id:guid}")]
        public JsonRequestResult GetScheduleByID([FromUri] Guid id)
        {
            return new JsonRequestResult("");
        }

        [HttpGet]
        [Route("managedschedule")]
        public JsonRequestResult GetAll()
        {
            return new JsonRequestResult("");
        }

        [HttpPut]
        [Route("managedschedule")]
        public JsonRequestResult Update([FromBody] Pair pair)
        {
            return new JsonRequestResult("");
        }

        [HttpDelete]
        [Route("managedschedule/{id:guid}")]
        public JsonRequestResult Delete([FromUri] Guid id)
        {
            return new JsonRequestResult("");
        }

    }
}
