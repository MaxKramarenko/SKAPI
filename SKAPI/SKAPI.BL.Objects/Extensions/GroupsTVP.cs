using SKAPI.BL.Objects.Schedule.Responce;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAPI.BL.Objects.Extensions
{
    public static class GroupsTVP
    {
        public static DataTable ToTVP(this List<GroupResponce> groups)
        {
            var table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("FullName");
            table.Columns.Add("Prefix");
            table.Columns.Add("Okr");
            table.Columns.Add("Type");
            table.Columns.Add("Url");
           


            foreach (var g in groups)
            {
                var row = table.NewRow();

                row["ID"] = g.ID;
                row["FullName"] = g.FullName;
                row["Prefix"] = g.Prefix;
                row["Okr"] = g.Okr;
                row["Type"] = g.Type;
                row["Url"] = "";
               

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
