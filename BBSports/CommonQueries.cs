using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace BBSports
{
    class CommonQueries
    {
        private string cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

        public List<String> GetTeamList(int adminId)
        {
            List<string> teams = new List<string>();

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = " + adminId +
                         "and Active = 1";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            teams.Add(reader.GetString(0));
                    }
                }
            }
            teams.Sort();
            return teams;
        }
    }
}