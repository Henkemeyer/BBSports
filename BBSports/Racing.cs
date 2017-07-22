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
        private int sportId = 0;

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
            sportId = homebase.SportId;
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            dateTPStart.Value = System.DateTime.Now.AddMonths(-4).Date;
            dateTPEnd.Value = System.DateTime.Now.AddDays(3).Date;

            GetMeets();
            GetEvents();
            GetAthletes();

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
                                            "order by m.MeetDate desc", homebase.TeamId, dateTPStart.Value.Date,
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

        private void GetEvents()
        {
            string getEvents = String.Format(@"select r.RacingEventId, r.EventName from RacingEvents r, Teams t " +
                                             "where t.TeamId = {0} and t.Gender = r.Gender and r.SportId = t.SportId " +
                                             "order by r.distance desc", homebase.TeamId);

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(getEvents, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbEvent.Items.Add(new ComboBoxItem(reader.GetString(1), reader.GetInt32(0)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetEvents", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetAthletes()
        {
            string getAthletes = String.Format(@"select u.UserId, u.FullName from Users u, Roster r where r.TeamId = {0} " +
                                            "and r.Status = \'Active\' and r.Eligibility <> \'Alumni\' " +
                                            "and r.AthleteId = u.UserId", homebase.TeamId);

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

        private void Update_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (cbMeet.Text == "")
                errMsg += "You must select a meet for the performance.\r\n";

            if (cbEvent.SelectedIndex < 0)
                errMsg += "You must select an event for the performer.\r\n";

            if (cbAthlete.SelectedIndex < 0)
                errMsg += "You must select a performer to enter info for.";

            if (errMsg != "")
                MessageBox.Show(errMsg, "Info Needed", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            else
            {
                ClearSplits();
                int distance = 0, total = 0, splitDis = 100, numCol = 1, numRow = 1;
                string type = "";
                ComboBoxItem selEvent = (ComboBoxItem)cbEvent.SelectedItem;
                string getInfo = String.Format(@"select Distance, EventType from RacingEvents where RacingEventId = {0}",
                                    selEvent.GetId);

                try
                {
                    using (SqlConnection connection = new SqlConnection(cs))
                    {
                        using (var cmd = new SqlCommand(getInfo, connection))
                        {
                            connection.Open();
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    distance = reader.GetInt32(0);
                                    type = reader.GetString(1);
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Get Event Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (type == "Race")
                {
                    lName.Text = cbAthlete.Text;
                    if (rbShort.Checked)
                    {
                        if (sportId == 1)
                            splitDis = 1000;
                        else if (sportId == 2)
                            splitDis = 100;
                        else if (sportId == 3)
                            splitDis = 200;
                    }
                    else
                    {
                        if (sportId == 1)
                            splitDis = 1609;
                        else if (sportId == 2)
                            splitDis = 200;
                        else if (sportId == 3)
                            splitDis = 400;
                    }

                    total = distance / splitDis;
                    if (distance % splitDis != 0)
                        total += 1;

                    if (total > 4)
                    {
                        numCol = 4;
                        numRow = (total + 3) / 4;
                    }
                    else
                    {
                        numCol = total;
                        numRow = 1;
                    }

                    tlpSplits.SuspendLayout();
                    tlpSplits.RowCount = numRow;
                    tlpSplits.ColumnCount = numCol;
                    for (int y=0; y<numRow; y++)
                    {
                        for (int x=0; x<numCol; x++)
                        {
                            Panel hold = new Panel();
                            hold.Height = 100;
                            hold.Width = scRacing.Panel2.Width / numCol - 6;

                            NumericUpDown sName = new NumericUpDown();
                            sName.Name = total.ToString();
                            sName.Minimum = 1;
                            sName.Maximum = 45000;
                            if ((splitDis * (y * 4 + x + 1)) < distance)
                                sName.Value = (splitDis * (y * 4 + x + 1));
                            else
                                sName.Value = distance;
                            sName.Dock = DockStyle.Top;
                            sName.TabStop = false;
                            hold.Controls.Add(sName);

                            MaskedTextBox sTime = new MaskedTextBox();
                            sTime.Name = "Split " + (y * 4 + x + 1).ToString();
                            sTime.Mask = "00:00.000";
                            sTime.Dock = DockStyle.Top;
                            hold.Controls.Add(sTime);

                            tlpSplits.Controls.Add(hold, x, y);
                            

                            if ((y * 4 + x + 1) == total)
                            {
                                x = 99;
                                y = 99;
                            }
                        }
                    }
                    tlpSplits.ResumeLayout();
                }
                else if (type == "Relay")
                {

                }
                else if (type == "Height")
                {

                }
                else if (type == "Distance")
                {

                }
            }
        }
        private void ClearSplits()
        {
            lAthlete.Text = "                                               ";
            tlpSplits.Controls.Clear();
            numericPlace.Value = 0;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearSplits();
        }
    }
}
