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
        private HomePage homebase = null;

        public AthleteManager(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            StartUp();
        }

        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            
            cbGrade.SelectedIndex = 0;

            GetGrades();
            GetSTeams();
            GetAthletes();
            GetTeams();
        }

        private void GetGrades()
        {
            List<string> grades = new List<string>();

            string getGrades = @"select c.Grades from Classifications c, Administration a
                          where a.AdministrationId = " + homebase.AdminId +
                         "and a.Classification = c.Classification " +
                         "order by c.ClassId asc";

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
            clbSGrades.Items.Clear();
            cbGrade.DataSource = grades;
            cbGrade.SelectedIndex = 0;

            int num = 0;
            foreach (string s in grades)
            {
                clbSGrades.Items.Add(s);
                if (!s.Equals("Alumni"))
                    clbSGrades.SetItemChecked(num, true);
                num++;
            }
        }

        private void GetAthletes()
        {
            DataTable athletes = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource orgAthletes = new BindingSource();
            string gender = "Female";
            string grades = "";
            string teams = "";

            if (rbSMale.Checked)
                gender = "Male";
            else if (rbSAll.Checked)
                gender = "All";

            foreach(var g in clbSGrades.CheckedItems)
            {
                grades += "'" + g.ToString() + "'";
                if (clbSGrades.CheckedItems.IndexOf(g) != clbSGrades.CheckedItems.Count - 1)
                    grades += ", ";
            }

            foreach (var t in clbSTeams.CheckedItems)
            {
                teams += "'" + t.ToString() + "'";
                if (clbSTeams.CheckedItems.IndexOf(t) != clbSTeams.CheckedItems.Count - 1)
                    teams += ", ";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("GetAthletes", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = homebase.AdminId;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.AdminId;
                        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@grades", SqlDbType.VarChar).Value = grades;
                        cmd.Parameters.Add("@teams", SqlDbType.VarChar).Value = teams;

                        adapter.SelectCommand = cmd;
                        adapter.Fill(athletes);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            orgAthletes.DataSource = athletes;
            dgAthletes.DataSource = orgAthletes;
        }

        //Clears the screan.
        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            this.Refresh();
           /* lHeader.Text = "New Athlete";
            clbSTeams.Enabled = true;
            athleteId = 0;
            tbFirst.Text = "";
            tbMiddle.Text = "";
            tbLast.Text = "";
            tbNickname.Text = "";
            dateTPBirthday.Value = System.DateTime.Now.AddYears(-15);
            richTBNotes.Text = "";
            cbGrade.SelectedIndex = 0;
            GetAthletes();*/
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
            string gender = "";

            if (rbFemale.Checked)
                gender = "Male";
            else
                gender = "Female";

            string sql = String.Format(@"select TeamName from dbo.Teams where AdministrationId = {0} " +
                         "and Active = 1 and Gender <> '{1}'", homebase.AdminId, gender);

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

        private void SGender_CheckedChanged(object sender, EventArgs e)
        {
            GetSTeams();
        }

        private void GetSTeams()
        {
            List<string> sTeams = new List<string>();
            string gender = "Female";

            if (rbSMale.Checked)
                gender = "Male";
            else if (rbSAll.Checked)
                gender = "Gender";

            string getSTeams = String.Format(@"select TeamName from dbo.Teams where AdministrationId = {0} " +
                                " and Gender = '{1}' and Active = 1", homebase.AdminId, gender);

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(getSTeams, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            sTeams.Add(reader.GetString(0));
                    }
                }
            }
            sTeams.Sort();
            clbSTeams.Items.Clear();

            int num = 0;
            foreach (string s in sTeams)
            {
                clbSTeams.Items.Add(s);
                clbSTeams.SetItemChecked(num, true);
                num++;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetAthletes();
        }

        // When athlete is double clicked it loads their info to be edited.
        private void Athletes_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgAthletes.SelectedRows.Count < 1)
            {
                return;
            }

            athleteId = Convert.ToInt32(dgAthletes.SelectedRows[0].Cells[0].Value);

            string getAth = @"select FirstName, MiddleName, LastName, Nickname, Gender, Birthday, " +
                            "Notes, Grade, City, State from Users where UserId = " + athleteId;

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
                            richTBNotes.Text = reader.GetString(6);
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
                    "where r.AthleteId = " + athleteId + " and r.TeamId = t.TeamId " +
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
            clbSTeams.Enabled = false;
            lHeader.Text = "Edit Athlete";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            string gender = "Female";
            int zip;

            if (tbFirst.Text.Equals("") || tbLast.Text.Equals(""))
                errMsg += "Athlete must have a first and last name.";

            if (clbTeams.CheckedItems.Count < 1)
                errMsg += "Athlete must belong to a sport";

            if (errMsg.Equals(""))
            {
                if (rbMale.Checked)
                    gender = "Male";

                try
                {
                    using (SqlConnection connection = new SqlConnection(cs))
                    {
                        using (var cmd = new SqlCommand("AddEditAthlete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@athleteId", SqlDbType.Int).Value = athleteId;
                            cmd.Parameters.Add("@first", SqlDbType.VarChar).Value = tbFirst.Text;
                            cmd.Parameters.Add("@middle", SqlDbType.VarChar).Value = tbMiddle.Text;
                            cmd.Parameters.Add("@last", SqlDbType.VarChar).Value = tbLast.Text;
                            cmd.Parameters.Add("@nick", SqlDbType.VarChar).Value = tbNickname.Text;
                            cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = mtbBirthday.Text;
                            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = richTBNotes.Text;
                            cmd.Parameters.Add("@strength", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = cbGrade.Text;
                            connection.Open();

                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    athleteId = reader.GetInt32(0);
                            }
                            if (athleteId > 0)
                                AddToRosters();
                        }
                    }
                    Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(errMsg, "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddToRosters()
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
                                    rosterIn.Add(@"insert into Roster values(" + reader.GetInt32(1) + ", " + athleteId +
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
    }
}
