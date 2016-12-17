using SKAPI.BL.Objects.OwnSchedule;
using SKAPI.BL.Objects.Request;
using SKAPI.BL.Objects.Schedule;
using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using SKAPI.BL.Objects.Extensions;
using Newtonsoft.Json;
using SKAPI.BL.Objects.Schedule.Request;
using System.Web.Helpers;

namespace SKAPI.Sevices.Implementation
{
    public class ScheduleService
    {
        public List<Pair> Search(ScheduleSearchRequest scheduleRequest)
        {
            return new List<Pair>();
        }

        public CurrentWeekResponce getCurrentWeek()
        {
            var result = new CurrentWeekResponce();
            var response = SendRequest("http://api.rozklad.org.ua/v2/weeks");
            var currentweek = JsonConvert.DeserializeObject<CurrentWeek>(response);
            return currentweek.ToCurrentWeek();
        }

        public List<GroupResponce> GroupSearch(String id)
        {
            var resultList = new List<GroupResponce>();
            var response = SendRequest("http://api.rozklad.org.ua/v2/groups/?search=" + Json.Encode(new
            {
                query = id
            }));
            var grops = JsonConvert.DeserializeObject<GroupsRequest>(response);
            resultList.AddRange(grops.groups.ToListGroup());
            return resultList;
        }

        public GroupResponce getGroupByName(String id)
        {
            var response = SendRequest("http://api.rozklad.org.ua/v2/groups/" + id);
            var group = JsonConvert.DeserializeObject<GroupRequest>(response);
            return group.group.ToGroup();
        }

        public List<Pair> GetProperties()
        {
            return new List<Pair>();
        }

        public ScheduleResponce GetTimeTableByGroupID(int id)
        {
<<<<<<< HEAD
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", id));

            var timeLine =  JsonConvert.DeserializeObject<TimeLine>(responce);

            return timeLine.ToResponce();
        }

        public ScheduleResponce GetTimeTableByGroupName(string name)
        {
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", name));
=======
            var resultList = new List<GroupResponce>();

            for (int i = 0; i < 1800; i += 100)
            {
                var responce = SendRequest("http://api.rozklad.org.ua/v2/groups?filter=" + Json.Encode(new
                {
                    limit = 100,
                    offset = i
                }));
                var grops = JsonConvert.DeserializeObject<GroupsRequest>(responce);
                resultList.AddRange(grops.groups.ToListGroup());
            }

            return resultList;
        }

        public ScheduleResponce GetTimeTableByGroupName(String groupName)
        {
            var responce = SendRequest(String.Format("http://api.rozklad.org.ua/v2/groups/{0}/timetable", groupName));
>>>>>>> v2

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