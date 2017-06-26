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
    public partial class TeamManager : Form
    {
        private string cs = "";
        private int teamId = 0;

        public TeamManager()
        {
            InitializeComponent();

            StartUp();
        }

        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            cbSSeason.SelectedIndex = cbSSeason.FindString("All");

            SetAvailableSports();
            GetTeams();
        }

        private void SetAvailableSports()
        {
            List<string> sports = new List<string>();
            string sql = @"select SportName from SupportedSports";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            sports.Add(reader.GetString(0));
                    }
                }
            }
            sports.Sort();
            this.cbSports.Items.AddRange(sports.ToArray());
            this.cbSports.AutoCompleteCustomSource.AddRange(sports.ToArray());

            cbSSports.Items.AddRange(sports.ToArray());
            cbSSports.AutoCompleteCustomSource.AddRange(sports.ToArray());
            cbSSports.Items.Add("All");
            cbSSports.AutoCompleteCustomSource.Add("All");
            cbSSports.SelectedIndex = cbSSports.FindString("All");
        }

        private void GetTeams()
        {
            DataTable teams = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource requestedTeams = new BindingSource();
            string gender = "";
            int active = 0;

            if (rbSMale.Checked)
                gender = "Male";
            else if (rbSFemale.Checked)
                gender = "Female";
            else if (rbSCoed.Checked)
                gender = "Current";
            else
                gender = "All";

            if (cbSActivated.Checked)
                active = 1;

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("GetTeams", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@administrationId", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@sportName", SqlDbType.VarChar).Value = cbSSports.Text;
                        cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = "All";
                        cmd.Parameters.Add("@season", SqlDbType.VarChar).Value = cbSSeason.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@active", SqlDbType.Bit).Value = active;

                        adapter.SelectCommand = cmd;
                        adapter.Fill(teams);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            requestedTeams.DataSource = teams;
            dgTeams.DataSource = requestedTeams;
        }

        private void Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLevel.Text.Equals("(Other)"))
            {
                this.lOther.Visible = true;
                this.tbOther.Visible = true;
            }
            else
            {
                this.lOther.Visible = false;
                this.tbOther.Visible = false;
            }
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String errMsg = "";

            if (cbSports.Text.Equals(""))
                errMsg = "You must select a Sport for your new Team.\r\n";

            if (tbTeamName.Text.Equals(""))
                errMsg += "You must enter a Team Name.\r\n";

            if (cbSeason.Text.Equals(""))
                errMsg += "You must select a Season for your Sport.\r\n";

            if (cbLevel.Text.Equals(""))
                errMsg += "Please enter your level of competition.";

            if (!errMsg.Equals(""))
            {
                MessageBox.Show(errMsg, "Error");
                valid = false;
            }

            if (valid)
            {
                String gender;
                if (rbFemale.Checked)
                    gender = "Female";
                else
                    gender = "Male";

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("ActivateNewSport", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@administration", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@sportName", SqlDbType.VarChar).Value = cbSports.Text;
                        cmd.Parameters.Add("@teamName", SqlDbType.VarChar).Value = tbTeamName.Text;
                        cmd.Parameters.Add("@season", SqlDbType.VarChar).Value = cbSeason.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = cbLevel.Text;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
        }

        private void TeamName_TextChanged(object sender, EventArgs e)
        {
            string check = "";
            string unique = @"Select 'duplicate' from Teams where AdministrationId = " + 1 +
                            " and TeamName = '" + tbTeamName.Text + "'";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(unique, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            check = reader.GetString(0);
                        }
                    }
                }
            }

            if (check.Equals("duplicate"))
            {
                MessageBox.Show("Please enter a unique team name for your organization.", "Duplicate");
                tbTeamName.SelectAll();
            }
        }

        private void Teams_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgTeams.SelectedRows.Count > 0)
            {
                var teamId = Convert.ToInt32(dgTeams.SelectedRows[0].Cells[0].Value);
                string getTeam = @"Select ss.SportName, t.TeamName, t.Season, t.Gender, t.Level " +
                                 "from Teams t, SupportedSports ss where TeamId = " + teamId.ToString() +
                                 " and t.SportId = ss.SportId";
                string gender = "";
                
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var command = new SqlCommand(getTeam, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbSports.SelectedIndex = cbSports.FindString(reader.GetString(0));
                                tbTeamName.Text = reader.GetString(1);
                                cbSeason.SelectedIndex = cbSeason.FindString(reader.GetString(2));
                                gender = reader.GetString(3);
                                cbLevel.SelectedIndex = cbLevel.FindString(reader.GetString(4));
                            }
                        }
                    }
                }
                if (gender.Equals("Female"))
                    rbFemale.Checked = true;
                else if (gender.Equals("Male"))
                    rbMale.Checked = true;
                else
                    rbCoed.Checked = true;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetTeams();
        }
    }
}
