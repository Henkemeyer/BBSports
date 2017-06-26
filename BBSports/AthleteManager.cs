using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class AthleteManager : Form
    {
        private string cs = "";
        private int athleteId = 0;

        public AthleteManager()
        {
            InitializeComponent();
            StartUp();
        }

        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            
            dateTPBirthday.Value = System.DateTime.Now.AddYears(-15);

            GetAthletes();

            GetTeams();
        }

        private void GetAthletes()
        {

        }

        private void GetTeams()
        {
            List<string> teams = new List<string>();
            string gender = "";

            if (rbFemale.Checked)
                gender = "Female";
            else
                gender = "Male";

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = " + 1 +
                         "and Active = 1 " +
                         "and Gender = '" + gender + "'";

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

            foreach (string s in teams)
            {
                clbTeams.Items.Add(s);
            }
        }  
    }
}
