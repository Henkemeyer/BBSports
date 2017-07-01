using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBSports
{
    public partial class HomePage : Form
    {
        private string cs = "";

        private void GetConString()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
        }

        public int adminId = 0;
        public int teamId = 0;
        public int sportId = 0;

        public int GetAdmin()
        {
            return adminId;
        }

        public void SetAdmin(int aId)
        {
            adminId = aId;
        }

        public int GetTeamId()
        {
            return teamId;
        }

        public void SetTeamId(int tId)
        {
            teamId = tId;
        }
        
        public int GetSportId()
        {
            return sportId;
        }

        public void SetSportId(int sport)
        {
            sportId = sport;
        }

        // Begin HomePage Logic
        //
        //
        public HomePage()
        {
            InitializeComponent();

            GetConString();
            ChangeUser();
        }

        private void ChangeUser()
        {
            Login login = new Login(this);
            login.ShowDialog();
            LoadFirstPage();
        }

        public void LoadFirstPage()
        {
            Racing startPage = new Racing(this);
            startPage.MdiParent = this;
            startPage.Show();
            startPage.WindowState = FormWindowState.Maximized;

            AddTeamOptions();
        }

        private void AddTeamOptions()
        {
            List<string> teams = new List<string>();

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = "+ adminId +
                         "and Active = 1";
            
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
            this.changeTeamTMI.DropDownItems.Clear();
            foreach ( string s in teams)
            {
                ToolStripMenuItem myMenuTeam = new ToolStripMenuItem();
                myMenuTeam.Name = s+"TMI";
                myMenuTeam.Text = s;
                myMenuTeam.Click += new EventHandler(MenuItemClickHandler);
                this.changeTeamTMI.DropDownItems.Add(myMenuTeam);
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string teamName = clickedItem.Text;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand("SwitchTeams", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@adminId", SqlDbType.Int).Value = GetAdmin();
                    command.Parameters.Add("@teamName", SqlDbType.VarChar).Value = teamName;

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SetSportId(reader.GetInt32(0));
                            SetTeamId(reader.GetInt32(1));
                        }
                    }
                }
            }
            this.changeTeamTMI.Checked = false;
            foreach(ToolStripMenuItem item in changeTeamTMI.DropDownItems)
            {
                item.Checked = false;
            }
            clickedItem.Checked = true;
        }

        private void ManageMeetsTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            MeetManager meetMan = new MeetManager(this);
            meetMan.MdiParent = this;
            meetMan.Show();
            meetMan.WindowState = FormWindowState.Maximized;
        }

        private void ManageTeamsTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            TeamManager teams = new TeamManager(this);
            teams.MdiParent = this;
            teams.Show();
            teams.WindowState = FormWindowState.Maximized;
        }

        private void ManageAthletesTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            AthleteManager athMan = new AthleteManager(this);
            athMan.MdiParent = this;
            athMan.Show();
            athMan.WindowState = FormWindowState.Maximized;
        }

        private void PerformancesTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            Racing raceForm = new Racing(this);
            raceForm.MdiParent = this;
            raceForm.Show();
            raceForm.WindowState = FormWindowState.Maximized;
        }

        private void SwitchUserTMI_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void ExitTMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
