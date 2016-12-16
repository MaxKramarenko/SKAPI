using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.OwnSchedule;
using SKAPI.Sevices.Implementation;
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
        private readonly ManagedScheduleServices _managedService = new ManagedScheduleServices();

        [HttpGet]
        [Route("managedschedule/{id:guid}")]
        public JsonRequestResult GetScheduleByID([FromUri] Guid id)
        {
            return new JsonRequestResult(_managedService.GetScheduleByID(id));
        }

        [HttpGet]
        [Route("managedschedule")]
        public JsonRequestResult GetAll()
        {
            return new JsonRequestResult(_managedService.GetAll());
        }

        [HttpGet]
        [Route("managedschedule/{name}")]
        public JsonRequestResult GetAll(string name)
        {
            return new JsonRequestResult(_managedService.GetByName(name));
        }

        [HttpPut]
        [Route("managedschedule")]
        public JsonRequestResult Update([FromBody] Pair pair)
        {
            return new JsonRequestResult(_managedService.Update(pair));
        }

        [HttpDelete]
        [Route("managedschedule/{id:guid}")]
        public JsonRequestResult Delete([FromUri] Guid id)
        {
            _managedService.Delete(id);
            return new JsonRequestResult(true);
        }

    }
}
