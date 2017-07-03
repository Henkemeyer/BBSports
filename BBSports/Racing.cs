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
    public partial class Racing : Form
    {
        private string cs = "";
        private HomePage homebase = null;

        public Racing(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            StartUp();
        }

        // Startup does some additional initialization for the Form.
        // Gets the connection string, gets list of recent meets and relevent events, and athletes.
        private void StartUp()
        {
            int sportId = 0;
            sportId = homebase.GetSportId();
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            dateTPStart.Value = System.DateTime.Now.AddMonths(-4).Date;
            dateTPEnd.Value = System.DateTime.Now.AddDays(3).Date;

            GetMeets();
           // GetAthletes();

            if (sportId == 1)
            {
                rbShort.Text = "1000m";
                rbLong.Text = "1 Mile";
            }
            else if (sportId == 2)
            {
                rbShort.Text = "100m";
                rbLong.Text = "200m";
            }
            else if (sportId == 3)
            {
                rbShort.Text = "200m";
                rbLong.Text = "400m";
            }
        }

        private void GetMeets()
        {
            string getMeets = String.Format(@"select m.MeetId, m.MeetName from Meets m, MeetTeams mt where mt.TeamId = {0} " +
                                            "and mt.MeetId = m.MeetId and m.MeetDate >= '{1}' and m.MeetDate < '{2}' " +
                                            "order by m.MeetDate desc", homebase.GetTeamId(), dateTPStart.Value.Date,
                                            dateTPEnd.Value.Date);

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(getMeets, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            cbMeet.Items.Clear();
                            while (reader.Read())
                            {
                                cbMeet.Items.Add(new ComboBoxItem(reader.GetString(1), reader.GetInt32(0)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetMeets", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetAthletes()
        {
            string getAthletes = String.Format(@"select a.AthleteId, a.FullName from Athletes a, Roster r where r.TeamId = {0} " +
                                            "and r.Status = \'Active\' and r.Eligibility <> \'Alumni\' " +
                                            "and r.AthleteId = a.AthleteId", homebase.GetTeamId());

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(getAthletes, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbAthlete.Items.Add(new ComboBoxItem(reader.GetString(1), reader.GetInt32(0)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetAthletes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MeetSearch_ValueChanged(object sender, EventArgs e)
        {
            GetMeets();
        }
    }
}
