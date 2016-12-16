using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Dapper;
using Newtonsoft.Json;
using SKAPI.BL.Objects.Extensions;
using SKAPI.BL.Objects.Request;
using SKAPI.BL.Objects.Schedule.Responce;
using SKAPI.DAL.Repositories;

namespace SKAPI.Sevices.Implementation
{
    public class GroupService
    {
        private readonly GroupRepository _groupRepository = new GroupRepository();

        public List<GroupResponce> GetAllGroups()
        {
            var resultList = new List<GroupResponce>();

            for (int i = 0; i < 1800; i += 100)
            {
                var responce = SendRequest("http://api.rozklad.org.ua/v2/groups?filter=" + Json.Encode(new
                {
                    limit = 100,
                    offset = i
                }));
                // var test = (JsonConvert.DeserializeObject<GroupsRequest>(responce));
                //resultList.Add(JsonConvert.DeserializeObject<GroupsRequest>(responce).ToGroup());
                var grops = JsonConvert.DeserializeObject<GroupsRequest>(responce);
                resultList.AddRange(grops.groups.ToListGroup());
                UpdateAll(grops.groups.ToListGroup());
            }

            return resultList;
        }

        public List<GroupResponce> GetGroupByName(string name)
        {
            //TODO create vocabluary
            return _groupRepository.Get(new {FullName = name});
        }

        public bool UpdateAll(List<GroupResponce> groups)
        {
            _groupRepository.GroupUpdate(new
            {
                Groups = groups.ToTVP().AsTableValuedParameter("dbo.GroupTVP")
            });
            return true;
        }

        #region sendRequest
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
        #endregion sendRequest
    }
}
