using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace SKAPI.BL.Objects.Common
{
    public class JsonRequestResultData
    {
        public JsonRequestResultData()
            : this(new object())
        {
        }

        public JsonRequestResultData(object data)
            : this(data, true, HttpStatusCode.OK)
        {
        }

        public JsonRequestResultData(object data, bool success, HttpStatusCode status)
            : this(data, success, status, null)
        {
        }

        public JsonRequestResultData(object data, bool success, HttpStatusCode status, IEnumerable<KeyValuePair<string, string[]>> errors)
        {
            Success = success;
            Status = (int)status;
            Data = data;
            Errors = errors;
        }
        public JsonRequestResultData(object data, bool success, HttpStatusCode status, object datax)
        {
            Success = success;
            Status = (int)status;
            Data = data;
        }

        public bool Success { get; set; }
        public int Status { get; set; }
        public object Data { get; set; }
        public IEnumerable<KeyValuePair<string, string[]>> Errors { get; set; }
    }

    public class JsonRequestResult : System.Web.Mvc.JsonResult
    {
        public JsonRequestResult(object data)
    : this(HttpStatusCode.OK, data, JsonRequestBehavior.AllowGet)
        {
        }
        /// <summary>
        /// Return successful result with Custom data and default HttpStatusCode 200
        /// </summary>
        /// <param name="data">Custom data</param>
        /// <param name="behavior"></param>
        public JsonRequestResult(object data, JsonRequestBehavior behavior)
            : this(HttpStatusCode.OK, data, behavior)
        {
        }

        /// <summary>
        /// Set return result based on the provided HttpStatusCode and return Custom data
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="data">Custom data></param>
        /// <param name="behavior"></param>
        public JsonRequestResult(HttpStatusCode statusCode, object data, JsonRequestBehavior behavior)
            : this(statusCode, data, null, behavior)
        {
        }

        /// <summary>
        /// Set return result based on the provided HttpStatusCode, return Custom data and Errors dictionary
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="data"></param>
        /// <param name="errors"></param>
        /// <param name="behavior"></param>
        public JsonRequestResult(HttpStatusCode statusCode, object data, IEnumerable<KeyValuePair<string, string[]>> errors, JsonRequestBehavior behavior)
            : base()
        {
            //base.Data = new { Success = statusCode == HttpStatusCode.OK, Status = (int)statusCode, Errors = errors, Data = data };

            base.Data = new JsonRequestResultData(data, statusCode == HttpStatusCode.OK, statusCode, errors);
            base.JsonRequestBehavior = behavior;

        }

        public JsonRequestResult(HttpStatusCode statusCode, object data) : base()
        {
            base.Data = new JsonRequestResultData(data, statusCode == HttpStatusCode.OK, statusCode);
            base.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        }
        /// <summary>
        /// Prepare Exception for Json response
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, string[]>> PrepareException(Exception e)
        {
            return new[] {
                new KeyValuePair<string, string[]>(null, new String[] { e.InnerException == null ? e.Message : e.InnerException.Message })
                };
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            HttpResponseBase response = context.HttpContext.Response;

            if (this.ContentEncoding != null)
                response.ContentEncoding = this.ContentEncoding;
            if (this.Data == null)
                return;

            response.ContentType = string.IsNullOrEmpty(this.ContentType) ? "application/json" : this.ContentType;

            var settings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            var scriptSerializer = JsonSerializer.Create(settings);
            // Serialize the data to the Output stream of the response
            scriptSerializer.Serialize(response.Output, this.Data);
        }
    }
}
