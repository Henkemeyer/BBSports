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
                        cmd.Parameters.Add("@sportId", SqlDbType.Int).Value = homebase.GetSportId();
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.GetTeamId();
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
                cbGenders.Enabled = false;
                gbOtherScore.Enabled = false;

                meetId = Convert.ToInt32(dgMeetsList.SelectedRows[0].Cells[0].Value);
                string getMeet = @"Select MeetName, Location, MeetDate, Temperature, WeatherNotes, MeetNotes " +
                                 "from Meets where MeetId = " + meetId.ToString();

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
                            }
                        }
                    }
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (meetId > 0)
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
                    int gender = 0;

                    if (cbGenders.Checked)
                        gender = 1;

                    using (SqlConnection connection = new SqlConnection(cs))
                    {
                        using (var cmd = new SqlCommand("AddEditMeet", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@meetId", SqlDbType.Int).Value = meetId;
                            cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.GetTeamId();
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

                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    ClearInfo();
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
            cbGenders.Checked = false;
            richTBMeetNotes.Text = "";
            numericTemperature.Value = 0;
            richTBWeatherNotes.Text = "";
            meetId = 0;
            cbGenders.Enabled = true;
            gbOtherScore.Enabled = true;
        }

        private void Genders_CheckedChanged(object sender, EventArgs e)
        {
            this.gbOtherScore.Visible = this.cbGenders.Checked;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetMeets();
        }
    }
}
