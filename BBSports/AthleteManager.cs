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
                          where a.AdministrationId = " + 1 +
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
            int team = 0;
            string grades = "";
            string teams = "";

            if (rbSMale.Checked)
                gender = "Male";
            else if (rbSAll.Checked)
                gender = "All";

            foreach(var g in clbSGrades.CheckedItems)
            {
                grades += g.ToString();
                if (clbSGrades.CheckedItems.IndexOf(g) != clbSGrades.CheckedItems.Count - 1)
                    grades += ", ";
            }

            foreach (var t in clbSTeams.CheckedItems)
            {
                teams += t.ToString();
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

                        cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = team;
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
            lHeader.Text = "New Athlete";
            athleteId = 0;
            tbFirst.Text = "";
            tbMiddle.Text = "";
            tbLast.Text = "";
            tbNickname.Text = "";
            dateTPBirthday.Value = System.DateTime.Now.AddYears(-15);
            richTBNotes.Text = "";
            cbGrade.SelectedIndex = 0;
            GetAthletes();
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

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = " + 1 +
                         "and Active = 1 " +
                         "and Gender <> '" + gender + "'";

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
            string gender = "'Female'";

            if (rbSMale.Checked)
                gender = "'Male'";
            else if (rbSAll.Checked)
                gender = "Gender";

            string getSTeams = @"select TeamName from dbo.Teams
                                where AdministrationId = " + 1 +
                                " and Gender = " + gender +
                                " and Active = 1";

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

            string sql = @"select FirstName, MiddleName, LastName, Nickname, " +
                    "Birthday, Gender, Notes, Grade from Athletes where AthleteId = " + athleteId;

            string gender = "";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(sql, connection))
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
                            dateTPBirthday.Value = reader.GetSqlDateTime(4).Value.Date;
                            gender = reader.GetString(5);
                            richTBNotes.Text = reader.GetString(6);
                        }
                    }
                }
            }
            if (gender.Equals("Female"))
                rbFemale.Checked = true;
            else
                rbMale.Checked = true;

            gbGender.Enabled = false;
            lHeader.Text = "Edit Athlete";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            string gender = "Female";

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
                            cmd.Parameters.Add("@nick", SqlDbType.VarChar).Value = tbLast.Text;
                            cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = dateTPBirthday.Value;
                            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = richTBNotes.Text;
                            cmd.Parameters.Add("@strength", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = cbGrade.Text;

                            connection.Open();
                            cmd.ExecuteNonQuery();

                            athleteId = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                            AddToTeams();
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

        private void AddToTeams()
        {
            string sql = @"";
            string teamNames = "";
            List<String> rosterIn = new List<String>();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                foreach (var team in clbTeams.CheckedItems)
                {
                    teamNames += team.ToString();
                }
                sql = @"select TeamId from Teams where AdministrationId = " + 1 +
                    " and TeamName in (" + teamNames + ")";

                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rosterIn.Add(@"insert into Roster values(" + reader.GetInt32(0) + ", " + athleteId +
                                ", " + cbGrade.Text + ", 'Active', 0, 'N/A')");
                        }
                    }
                }
                foreach (string s in rosterIn)
                {
                    using (var cmd = new SqlCommand(s, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
