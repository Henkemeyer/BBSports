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
    public partial class MeetManager : Form
    {
        private string cs = "";
        private int meetId = 0;
        private HomePage homebase = null;

        public MeetManager(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            StartUp();
        }

        // Startup does some additional initialization for the Form.
        // Gets the connection string, sets defualt meet date to today, and gets recent meets.
        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            dateTP.Value = System.DateTime.Now;
            dateTPBegin.Value = System.DateTime.Now.AddMonths(-6);
            dateTPEnd.Value = System.DateTime.Now.AddMonths(3);

            GetMeets();
            string grabGender = @"Select Gender from Teams where TeamId = " + homebase.TeamId;
            string gender = "";
            int two = 0;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var cmd = new SqlCommand(grabGender, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            gender = reader.GetString(0);
                    }
                }

                if (gender != "Co-ed")
                {
                    string convienent = @"select count(1) from Teams where AdministrationId = " + homebase.AdminId +
                                        " and SportId = " + homebase.SportId + " and Gender <> '" + gender + "'";

                    using (var cmd = new SqlCommand(convienent, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                two = reader.GetInt32(0);
                        }
                    }
                }
            }
            if (two == 1)
                cxbGenders.Visible = false;
                gbOtherScore.Visible = false;
        }

        private void GetMeets()
        {
            DataTable meets = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource recentMeets = new BindingSource();
            string include = "";

            if (rbMale.Checked)
                include = "Male";
            else if (rbFemale.Checked)
                include = "Female";
            else if (rbCurrent.Checked)
                include = "Current";
            else
                include = "All";

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("GetMeets", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@beginDate", SqlDbType.DateTime).Value = dateTPBegin.Value;
                        cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = dateTPEnd.Value;
                        cmd.Parameters.Add("@sportId", SqlDbType.Int).Value = homebase.SportId;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.TeamId;
                        cmd.Parameters.Add("@include", SqlDbType.VarChar).Value = include;

                        adapter.SelectCommand = cmd;
                        adapter.Fill(meets);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            recentMeets.DataSource = meets;
            dgMeetsList.DataSource = recentMeets;
        }

        private void MeetsList_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgMeetsList.SelectedRows.Count > 0)
            {
                cxbGenders.Enabled = false;
                gbOtherScore.Enabled = false;

                meetId = Convert.ToInt32(dgMeetsList.SelectedRows[0].Cells[0].Value);
                string getMeet = String.Format(@"Select m.MeetName, m.Location, m.MeetDate, m.Temperature, m.WeatherNotes, m.MeetNotes, " +
                                 "m.Alumni, mt.Score, mt.Place from Meets m and MeetTeams mt " +
                                 "where mt.MeetId = {0} and mt.TeamId = {1} and mt.MeetId = m.MeetId", meetId.ToString(), homebase.TeamId);

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var command = new SqlCommand(getMeet, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tbMeetName.Text = reader.GetString(0);
                                tbLocation.Text = reader.GetString(1);
                                dateTP.Value = reader.GetSqlDateTime(2).Value.Date;
                                numericTemperature.Value = Convert.ToDecimal(reader.GetSqlInt16(3).ToString());
                                richTBWeatherNotes.Text = reader.GetString(4);
                                richTBMeetNotes.Text = reader.GetString(5);
                                cxbAlumni.Checked = reader.GetBoolean(6);
                                numericScore.Value = Convert.ToDecimal(reader.GetSqlInt16(7).ToString());
                                numericPlace.Value = Convert.ToDecimal(reader.GetSqlInt16(8).ToString());
                            }
                        }
                    }
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String errMsg = "";

            if (tbMeetName.Text.Equals(""))
                errMsg = "Please enter in a meet name.\r\n";

            if (dateTP.Text.Equals(""))
                errMsg += "Please enter in a meet date.\r\n";

            if (!errMsg.Equals(""))
            {
                MessageBox.Show(errMsg, "Error");
                valid = false;
            }

            if (valid)
            {
                int gender = 0, alumni = 0;

                if (cxbGenders.Checked)
                    gender = 1;

                if (cxbAlumni.Checked)
                    alumni = 1;

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("AddEditMeet", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@meetId", SqlDbType.Int).Value = meetId;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.TeamId;
                        cmd.Parameters.Add("@meetName", SqlDbType.VarChar).Value = tbMeetName.Text;
                        cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = tbLocation.Text;
                        cmd.Parameters.Add("@meetDate", SqlDbType.DateTime).Value = dateTP.Value;
                        cmd.Parameters.Add("@temp", SqlDbType.Int).Value = Decimal.ToInt32(numericTemperature.Value);
                        cmd.Parameters.Add("@weatherNotes", SqlDbType.VarChar).Value = richTBWeatherNotes.Text;
                        cmd.Parameters.Add("@meetNotes", SqlDbType.VarChar).Value = richTBMeetNotes.Text;
                        cmd.Parameters.Add("@bothGenders", SqlDbType.Bit).Value = gender;
                        cmd.Parameters.Add("@score", SqlDbType.Int).Value = Decimal.ToInt32(numericScore.Value);
                        cmd.Parameters.Add("@place", SqlDbType.Int).Value = Decimal.ToInt32(numericPlace.Value);
                        if (gender.Equals(1))
                        {
                            cmd.Parameters.Add("@otherScore", SqlDbType.Int).Value = Decimal.ToInt32(numericOtherScore.Value);
                            cmd.Parameters.Add("@otherPlace", SqlDbType.Int).Value = Decimal.ToInt32(numericOtherPlace.Value);
                        }
                        else
                        {
                            cmd.Parameters.Add("@otherScore", SqlDbType.Int).Value = 0;
                            cmd.Parameters.Add("@otherPlace", SqlDbType.Int).Value = 0;
                        }
                        cmd.Parameters.Add("@alumni", SqlDbType.Bit).Value = alumni;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    ClearInfo();
                    bSearch.PerformClick();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void ClearInfo()
        {
            tbMeetName.Text = "";
            tbLocation.Text = "";
            dateTP.Value = System.DateTime.Now;
            cxbGenders.Checked = false;
            numericTemperature.Value = 0;
            numericPlace.Value = 1;
            numericScore.Value = 0;
            numericOtherPlace.Value = 1;
            numericOtherScore.Value = 0;
            richTBWeatherNotes.Text = "";
            richTBMeetNotes.Text = "";
            cxbAlumni.Checked = false;
            meetId = 0;
            cxbGenders.Enabled = true;
            gbOtherScore.Enabled = true;
        }

        private void Genders_CheckedChanged(object sender, EventArgs e)
        {
            this.gbOtherScore.Visible = this.cxbGenders.Checked;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetMeets();
        }
    }
}
