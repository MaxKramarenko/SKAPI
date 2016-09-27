﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SKAPI.BL.Objects.Basic;
using SKAPI.BL.Objects.OwnSchedule;
using SKAPI.BL.Objects.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

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

        public List<JsonGroupResponce> GetAllGroups()
        {
            var resultList = new List<JsonGroupResponce>();

            for (int i = 0; i < 1800; i += 100)
            {
               var responce= SendRequest("http://api.rozklad.org.ua/v2/groups?filter=" + Json.Encode(new
                {
                    limit = 100,
                    offset = i
                }));

                resultList.Add(JsonConvert.DeserializeObject<JsonGroupResponce>(responce));
            }

            return resultList;
        }

        public JsonGroupResponce GetTimeTableByGroupName(string groupName)
        {
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", groupName));

            return JsonConvert.DeserializeObject<JsonGroupResponce>(responce);
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
