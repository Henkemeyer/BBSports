using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBSports
{
    public partial class AthleteManager : Form
    {
        private string cs = "";
        private HomePage homebase = null;
        private int athleteId = 0;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;

        public AthleteManager(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            StartUp();

            emailErrorProvider = new System.Windows.Forms.ErrorProvider();
            emailErrorProvider.SetIconAlignment(this.tbEmail, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(this.tbEmail, 2);
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            GetGrades();
            GetTeams();
        }

        private void GetGrades()
        {
            List<string> grades = new List<string>();

            string getGrades = @"select c.Grade from Classifications c, Administration a " +
                         "where a.AdministrationId = " + homebase.AdminId +
                         " and a.Classification = c.Level " +
                         "order by c.ClassificationId asc";

            using (SqlConnection connection = new SqlConnection(cs))
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
            this.Refresh();
            lHeader.Text = "New Athlete";
            athleteId = 0;
            tbFirst.Text = "";
            tbMiddle.Text = "";
            tbLast.Text = "";
            tbNickname.Text = "";
            mtbBirthday.Text = "";
            tbCity.Text = "";
            tbState.Text = "";
            tbEmail.Text = "";
            cbGrade.SelectedIndex = 0;
        }

        //Gets new team list to assign athlete to based on gender of athlete.
        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            GetTeams();
        }

        // Gets teams athlete may be assigned to.
        private void GetTeams()
        {
            List<string> teams = new List<string>();
            string gender = "Female";

            if (rbMale.Checked)
                gender = "Male";

            string sql = String.Format(@"select t.TeamName from Teams t, Coaches c where t.AdministrationId = {0} " +
                         "and t.Active = 1 and Gender = '{1}' and c.CoachId = {2} and c.TeamId = t.TeamId", 
                         homebase.AdminId, gender, homebase.AthleteId);

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
            clbTeams.Items.Clear();

            foreach (string s in teams)
            {
                clbTeams.Items.Add(s);
            }
        }

        private void FoundAthlete(int aId)
        {
            string getAth = @"select FirstName, MiddleName, LastName, Nickname, Gender, Birthday, " +
                            "Grade, City, State from Users where UserId = " + aId;

            string gender = "";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(getAth, connection))
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
                            cbGrade.SelectedIndex = cbGrade.FindString(reader.GetString(7));
                            tbCity.Text = reader.GetString(8);
                            tbState.Text = reader.GetString(9);
                        }
                    }
                }
            }
            if (gender.Equals("Female"))
                rbFemale.Checked = true;
            else
                rbMale.Checked = true;

            string getTeams = @"select t.TeamName from Teams t, Roster r " +
                    "where r.AthleteId = " + aId + " and r.TeamId = t.TeamId " +
                    "and t.AdministrationId = " + homebase.AdminId;

            using (SqlConnection conn = new SqlConnection(cs))
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

            gbGender.Enabled = false;
            lHeader.Text = "Edit Athlete";
            athleteId = aId;
        }

        private void Recruit_Click(object sender, EventArgs e)
        {
            int claimed = 0;
            if (athleteId > 0)
                claimed = 1;

            string gender = "Female";
            if (rbMale.Checked)
                gender = "Male";

            string password = "Exempt";
            if (claimed == 0)
            {
                int len = tbLast.Text.Length;
                if (len > 3)
                    len = 4;

                password = SaltNPepper.CreateHash(tbLast.Text.Substring(0,len) + 
                    mtbBirthday.Text.Substring(0,2) + mtbBirthday.Text.Substring(3, 2));
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
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
                        cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = DateTime.Parse(mtbBirthday.Text);
                        cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = "";
                        cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = cbGrade.Text;
                        cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = tbCity.Text;
                        cmd.Parameters.Add("@state", SqlDbType.Char).Value = tbState.Text.ToUpper();
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@claimed", SqlDbType.Int).Value = claimed;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AddToRosters(reader.GetInt32(0));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddToRosters(int aId)
        {
            List<String> rosterIn = new List<String>();
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    foreach (var team in clbTeams.CheckedItems)
                    {
                        using (var command = new SqlCommand("SwitchTeams", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@adminId", SqlDbType.Int).Value = homebase.AdminId;
                            command.Parameters.Add("@teamName", SqlDbType.VarChar).Value = team.ToString();

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    rosterIn.Add(@"insert into Roster values(" + reader.GetInt32(1) + ", " + aId +
                                        ", '" + cbGrade.Text + "', 'Active', 0, 'N/A')");
                                }
                            }
                        }
                    }

                    foreach (string s in rosterIn)
                    {
                        using (var cmd = new SqlCommand(s, connection))
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
            homebase.OpenDirectory();
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

                using (SqlConnection connection = new SqlConnection(cs))
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
    }
}
