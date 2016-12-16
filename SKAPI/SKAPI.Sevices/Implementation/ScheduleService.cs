using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.OwnSchedule;
using SKAPI.BL.Objects.Request;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using AutoMapper;
using SKAPI.BL.Objects.Common;
using SKAPI.BL.Objects.Extensions;

namespace SKAPI.Sevices.Implementation
{
    public class ScheduleService
    {
        public List<Pair> Search(ScheduleSearchRequest scheduleRequest)
        {
            return new List<Pair>();
        }

        public List<Pair> GetProperties()
        {
            return new List<Pair>();
        }

        public ScheduleResponce GetTimeTableByGroupID(int id)
        {
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", id));

            var timeLine =  JsonConvert.DeserializeObject<TimeLine>(responce);

            return timeLine.ToResponce();
        }

        public ScheduleResponce GetTimeTableByGroupName(string name)
        {
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", name));

            var timeLine = JsonConvert.DeserializeObject<TimeLine>(responce);

            return timeLine.ToResponce();
        }

        private string SendRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
