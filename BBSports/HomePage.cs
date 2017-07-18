using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public int athleteId = 0;
        public int teamId = 0;
        public int sportId = 0;

        public int AdminId
        {
            get { return adminId; }
            
            set { adminId = value; }
        }

        public int AthleteId
        {
            get { return athleteId; }

            set { athleteId = value; }
        }

        public int TeamId
        {
            get { return teamId; }

            set { teamId = value; }
        }
        
        public int SportId
        {
            get { return sportId; }

            set { sportId = value; }
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

        public void ChangeUser()
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        public void LoadFirstPage()
        {
            if (MdiChildren.Length > 0)
                ActiveMdiChild.Close();

            menuHome.Visible = true;
            AddTeamOptions();

            Racing startPage = new Racing(this);
            startPage.MdiParent = this;
            startPage.Show();
            startPage.WindowState = FormWindowState.Maximized;
        }

        public void NewUser()
        {
            menuHome.Visible = false;
            NewUser nu = new NewUser(this);
            nu.MdiParent = this;
            nu.Show();
            nu.WindowState = FormWindowState.Maximized;
        }

        private void AddTeamOptions()
        {
            List<string> teams = new List<string>();

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = " + adminId +
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
            Boolean select = true;
            foreach ( string s in teams)
            {
                ToolStripMenuItem myMenuTeam = new ToolStripMenuItem();
                myMenuTeam.Name = s+"TMI";
                myMenuTeam.Text = s;
                myMenuTeam.Click += new EventHandler(MenuItemClickHandler);
                this.changeTeamTMI.DropDownItems.Add(myMenuTeam);
                if (select)
                {
                    myMenuTeam.PerformClick();
                    select = false;
                }
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            if (clickedItem.Checked == false)
            {
                string teamName = clickedItem.Text;

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var command = new SqlCommand("SwitchTeams", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@adminId", SqlDbType.Int).Value = this.AdminId;
                        command.Parameters.Add("@teamName", SqlDbType.VarChar).Value = teamName;

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.SportId = reader.GetInt32(0);
                                this.TeamId = reader.GetInt32(1);
                            }
                        }
                    }
                }
                foreach (ToolStripMenuItem item in changeTeamTMI.DropDownItems)
                {
                    item.Checked = false;
                }
                clickedItem.Checked = true;
                if(ActiveMdiChild != null)
                    ActiveMdiChild.Refresh();                
            }
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
            if (this.SportId == 1 || this.SportId == 2 || this.SportId == 3)
            {
                ActiveMdiChild.Close();
                Racing raceForm = new Racing(this);
                raceForm.MdiParent = this;
                raceForm.Show();
                raceForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void SwitchUserTMI_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void RosterTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            Roster roster = new Roster(this);
            roster.MdiParent = this;
            roster.Show();
            roster.WindowState = FormWindowState.Maximized;
        }

        private void LiftingTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            Lifting lift = new Lifting(this);
            lift.MdiParent = this;
            lift.Show();
            lift.WindowState = FormWindowState.Maximized;
        }

        private void ExitTMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
