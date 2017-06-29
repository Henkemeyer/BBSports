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

        private void TeamUpdate(int activated)
        {
            Boolean valid = true;
            String errMsg = "";
            String gender = "";

            if (cbSports.Text.Equals(""))
                errMsg = "You must select a Sport for your new Team.\r\n";

            if (cbSports.Text.Equals(""))
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
                if (rbFemale.Checked)
                    gender = "Female";
                else
                    gender = "Male";

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("ManageTeam", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@sportName", SqlDbType.VarChar).Value = cbSports.Text;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = teamId;
                        cmd.Parameters.Add("@teamName", SqlDbType.VarChar).Value = tbTeamName.Text;
                        cmd.Parameters.Add("@season", SqlDbType.VarChar).Value = cbSeason.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = cbLevel.Text;
                        cmd.Parameters.Add("@active", SqlDbType.Int).Value = activated;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                Clear();
                GetTeams();
            }
        }

        private void Clear()
        {
            teamId = 0;
            lHeader.Text = "New Team";
            tbTeamName.Text = "";
            tbOther.Text = "";
            bActivate.Text = "Activate";
            bActivate.FlatAppearance.BorderColor = Color.LightGreen;
            bActivate.Enabled = true;
            bDeactivate.Visible = false;
            lWarning.Visible = false;
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            int active = 1;
            
            if (teamId > 0)
                active = 0;

            TeamUpdate(active);
        }

        private void Deactivate_Click(object sender, EventArgs e)
        {
            int active = -1;

            TeamUpdate(active);
        }

        private void Teams_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgTeams.SelectedRows.Count > 0)
            {
                Clear();
                teamId = Convert.ToInt32(dgTeams.SelectedRows[0].Cells[0].Value);
                string getTeam = @"Select ss.SportName, t.TeamName, t.Season, rtrim(t.Gender), t.Level, " +
                                 "t.Active, isnull(t.DeactiveDate, 0) " +
                                 "from Teams t, SupportedSports ss where TeamId = " + teamId.ToString() +
                                 " and t.SportId = ss.SportId";
                string gender = "";
                Boolean active = true;
                DateTime deactiveDate = new DateTime(2000, 1, 1, 1, 1, 0);

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
                                active = reader.GetBoolean(reader.GetOrdinal("Active"));
                                deactiveDate = reader.GetDateTime(6);
                            }
                        }
                    }
                }
                lHeader.Text = "Edit Team";

                if (gender.Equals("Female"))
                    rbFemale.Checked = true;
                else if (gender.Equals("Male"))
                    rbMale.Checked = true;
                else
                    rbCoed.Checked = true;

                if ((!active) && (System.DateTime.Now - deactiveDate).Days < 2)
                {
                    bActivate.Enabled = false;
                    lWarning.Visible = true;
                    bActivate.FlatAppearance.BorderColor = Color.Red;
                }
                else if (!active)
                {
                    bActivate.Text = "Activate";
                }
                else
                {
                    bActivate.Text = "Edit Team";
                    bDeactivate.Visible = true;
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetTeams();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
