using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBSports
{
    public partial class AthleteManager : SportsForm
    {
        private int athleteId = 0;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private Boolean isCoach = false;

        public AthleteManager(HomePage hp)
        {
            InitializeComponent();
            Homebase = hp;
            GetGrades();

            emailErrorProvider = new System.Windows.Forms.ErrorProvider();
            emailErrorProvider.SetIconAlignment(this.tbEmail, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(this.tbEmail, 2);
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        public void StartUpAthlete()
        {
            this.Text = "New Athlete";
            lEmail.Text = "Athlete E-Mail";
            GetTeams();
        }

        public void StartUpCoach()
        {
            this.Text = "New Coach";
            lEmail.Text = "Coach's E-Mail";
            cxbDirector.Visible = true;
            isCoach = true;
            cbGrade.Visible = false;
            lTitle.Visible = true;
            tbTitle.Visible = true;
            GetTeams();
        }

        private void GetGrades()
        {
            List<string> grades = new List<string>();

            string getGrades = @"select c.Grade from Classifications c, Administration a " +
                         "where a.AdministrationId = " + Homebase.AdminId +
                         " and a.Classification = c.Level " +
                         "order by c.ClassificationId asc";

            using (SqlConnection connection = new SqlConnection(Homebase.CS))
            {
                using (var command = new SqlCommand(getGrades, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            grades.Add(reader.GetString(0));
                    }
                }
            }
            cbGrade.DataSource = grades;
            cbGrade.SelectedIndex = 0;
        }

        //Clears the screan.
        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            if (isCoach)
                lHeader.Text = "New Coach";
            else
                lHeader.Text = "New Athlete";

            athleteId = 0;
            SearchId = 0;
            tbFirst.Text = "";
            tbMiddle.Text = "";
            tbLast.Text = "";
            tbNickname.Text = "";
            mtbBirthday.Text = "";
            tbCity.Text = "";
            tbState.Text = "";
            tbEmail.Text = "";
            mtbPhone.Text = "";
            cbGrade.SelectedIndex = 0;
            tbTitle.Text = "";
        }

        //Gets new team list to assign athlete to based on gender of athlete.
        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCoach)
                GetTeams();
        }

        // Gets teams athlete may be assigned to.
        private void GetTeams()
        {
            List<string> teams = new List<string>();
            string gender = "Female";

            if (rbMale.Checked)
                gender = "Male";

            string sql = "";

            if (isCoach)
                sql = String.Format(@"select TeamName from Teams where AdministrationId = {0} and Active = 1", Homebase.AdminId);
            else
                sql = String.Format(@"select t.TeamName from Teams t, Coaches c where t.AdministrationId = {0} " +
                         "and t.Active = 1 and Gender = '{1}' and c.CoachId = {2} and c.TeamId = t.TeamId", 
                         Homebase.AdminId, gender, Homebase.AthleteId);

            using (SqlConnection connection = new SqlConnection(Homebase.CS))
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
            if (teams.Count > 2)
                teams.Sort();

            clbTeams.Items.Clear();

            foreach (string s in teams)
            {
                clbTeams.Items.Add(s);
            }
        }

        private void GetUserData(int aId)
        {
            string getUser = @"select FirstName, MiddleName, LastName, Nickname, Gender, Birthday, " +
                                "Grade, City, State, Claimed from Users where UserId = " + aId;

            string gender = "";
            Boolean claimed = true;

            using (SqlConnection connection = new SqlConnection(Homebase.CS))
            {
                using (var command = new SqlCommand(getUser, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbFirst.Text = reader.GetString(0);
                            tbMiddle.Text = reader.GetString(1);
                            tbLast.Text = reader.GetString(2);
                            tbNickname.Text = reader.GetString(3);
                            gender = reader.GetString(4);
                            mtbBirthday.Text = reader.GetDateTime(5).ToShortDateString();
                            cbGrade.SelectedIndex = cbGrade.FindString(reader.GetString(6));
                            tbCity.Text = reader.GetString(7);
                            tbState.Text = reader.GetString(8);
                            claimed = reader.GetBoolean(reader.GetOrdinal("Claimed"));
                        }
                    }
                }
            }
            if (gender.Equals("Female"))
                rbFemale.Checked = true;
            else
                rbMale.Checked = true;

            gbGender.Enabled = false;
            athleteId = aId;

            if (isCoach)
                GetJobs(aId);
            else
                GetRosters(aId);
        }

        private void GetRosters(int aId)
        {
            string getTeams = @"select t.TeamName from Teams t, Roster r " +
                    "where r.AthleteId = " + aId + " and r.TeamId = t.TeamId " +
                    "and t.AdministrationId = " + Homebase.AdminId;

            using (SqlConnection conn = new SqlConnection(Homebase.CS))
            {
                using (var command = new SqlCommand(getTeams, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbTeams.SetItemChecked(clbTeams.Items.IndexOf(reader.GetString(0)), true);
                        }
                    }
                }
            }
            
            lHeader.Text = "Edit Athlete";
        }

        private void GetJobs(int cId)
        {
            string getTeams = @"select t.TeamName from Teams t, Coaches c where c.coachId = " + cId + 
                " and c.TeamId = t.TeamId and t.AdministrationId = " + Homebase.AdminId;

            using (SqlConnection conn = new SqlConnection(Homebase.CS))
            {
                using (var command = new SqlCommand(getTeams, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbTeams.SetItemChecked(clbTeams.Items.IndexOf(reader.GetString(0)), true);
                        }
                    }
                }
            }
            
            lHeader.Text = "Edit Coach";
        }

        private void Recruit_Click(object sender, EventArgs e)
        {
            if (athleteId > 0)
            {
                AddToRosters(athleteId);
            }
            else
            {
                string gender = "Female";
                if (rbMale.Checked)
                    gender = "Male";

                string password = "Exempt";
                int len = tbLast.Text.Length;
                if (len > 3)
                    len = 4;

                password = SaltNPepper.CreateHash(tbLast.Text.Substring(0,len) + 
                    mtbBirthday.Text.Substring(0,2) + mtbBirthday.Text.Substring(3, 2));

                string phone = "";
                if (mtbPhone.Text.Length < 13)
                    phone = mtbPhone.Text;

                if (!DateTime.TryParse(mtbBirthday.Text, out var birthday))
                    birthday = DateTime.Parse("1/1/1899");

                try
                {
                    using (SqlConnection connection = new SqlConnection(Homebase.CS))
                    {
                        connection.Open();
                        using (var cmd = new SqlCommand("UpdateUser", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = athleteId;
                            cmd.Parameters.Add("@first", SqlDbType.VarChar).Value = tbFirst.Text;
                            cmd.Parameters.Add("@middle", SqlDbType.VarChar).Value = tbMiddle.Text;
                            cmd.Parameters.Add("@last", SqlDbType.VarChar).Value = tbLast.Text;
                            cmd.Parameters.Add("@nick", SqlDbType.VarChar).Value = tbNickname.Text;
                            cmd.Parameters.Add("@gender", SqlDbType.Char).Value = gender;
                            cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = birthday;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = cbGrade.Text;
                            cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = tbCity.Text;
                            cmd.Parameters.Add("@state", SqlDbType.Char).Value = tbState.Text.ToUpper();
                            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
                            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                            cmd.Parameters.Add("@claimed", SqlDbType.Int).Value = 0;
                            cmd.Parameters.Add("@phone", SqlDbType.Char).Value = phone;

                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    AddToRosters(reader.GetInt32(0));
                                }
                            }
                        }
                    }
                    Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Depending if the selected user is a coach or athlete this method will insert a record for each team as either a coach or roster record.
        private void AddToRosters(int aId)
        {
            List<String> rosterIn = new List<String>();
            string director = @"insert into Director values (" + Homebase.AdminId + ", " + aId + ")";
            try
            {
                using (SqlConnection connection = new SqlConnection(Homebase.CS))
                {
                    connection.Open();
                    foreach (var team in clbTeams.CheckedItems)
                    {
                        using (var command = new SqlCommand("GetTeamInfo", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@adminId", SqlDbType.Int).Value = Homebase.AdminId;
                            command.Parameters.Add("@teamName", SqlDbType.VarChar).Value = team.ToString();

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (isCoach)
                                    {
                                        rosterIn.Add(@"insert into Coaches values(" + aId  + ", " + reader.GetInt32(1) + ", '" + tbTitle.Text + "')");
                                    }
                                    else
                                        rosterIn.Add(@"insert into Roster values(" + reader.GetInt32(1) + ", " + aId +
                                        ", '" + cbGrade.Text + "', 'Active', 0, 'N/A')");
                                }
                            }
                        }
                    }

                    // Add a record into Coaches or Roster for each team selected for the user.
                    foreach (string s in rosterIn)
                    {
                        using (var cmd = new SqlCommand(s, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // If director is selected inserts a record giving full permission to the administration.
                    if (isCoach && cxbDirector.Checked)
                    {
                        using (var cmd = new SqlCommand(director, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Directory_Click(object sender, EventArgs e)
        {
            Directory dir = new Directory(this);
            dir.ShowDialog();

            if (SearchId > 0)
                GetUserData(SearchId);
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.TextLength > 0)
            {
                if (tbEmail.TextLength < 6 || !tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
                {
                    e.Cancel = true;
                    this.emailErrorProvider.SetError(tbEmail, "This E-mail is not valid");
                }
                else
                    this.emailErrorProvider.SetError(tbEmail, "");

                string check = @"select 'x' from Users where Email = '" + tbEmail.Text + "'";

                using (SqlConnection connection = new SqlConnection(Homebase.CS))
                {
                    using (var cmd = new SqlCommand(check, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                e.Cancel = true;
                                tbEmail.Select(0, tbEmail.Text.Length);
                                this.emailErrorProvider.SetError(tbEmail, "This E-mail has already been used for another account.");
                            }
                            else
                                this.emailErrorProvider.SetError(tbEmail, "");
                        }
                    }
                }
            }
            else
                this.emailErrorProvider.SetError(tbEmail, "");
        }

        private void Director_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbDirector.Checked)
            {
                DialogResult result = MessageBox.Show("Making Director will give user full permissions to all teams in the Administration. Continue?",
                                                            "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    for(int i = 0;i < clbTeams.Items.Count; i++)
                    {
                        clbTeams.SetItemChecked(clbTeams.Items.IndexOf(i), true);
                    }
                    clbTeams.Enabled = false;
                }
                else
                {
                    cxbDirector.Checked = false;
                }

            }
            else
            {
                clbTeams.Enabled = true;
            }
        }
    }
}
