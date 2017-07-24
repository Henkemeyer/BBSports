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
        public int searchId = 0;

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

        public int SearchId
        {
            get { return searchId; }

            set { searchId = value; }
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (AdminId == 0)
                this.Close();
        }

        public void LoadFirstPage()
        {
            if (MdiChildren.Length > 0)
                ActiveMdiChild.Close();

            menuHome.Visible = true;

            string isDirector = String.Format(@"select AdministrationId from Director where UserId = {0}", AthleteId);

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(isDirector, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //this.teamManagerTMI.Visible = false;
                            while (reader.Read())
                                AdminId = reader.GetInt32(0);
                        }
                    }
                }
            }

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
            List<ComboBoxItem> teams = new List<ComboBoxItem>();

            string sql = String.Format(@"select t.TeamId, t.TeamName from Teams t, Coaches c " +
                                    "where c.CoachId = {0} and t.Active = 1 and  (t.TeamId = c.TeamId " +
                                    "or t.TeamId in (select r.TeamId from Roster r " +
				                    "where r.AthleteId = {0} and r.Status not in ('Cut', 'Alumni')))", AthleteId);

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            teams.Add(new ComboBoxItem(reader.GetString(1), reader.GetInt32(0)));
                    }
                }
            }

            if (teams.Count > 0)
            {
                this.changeTeamTMI.DropDownItems.Clear();
                Boolean select = true;
                foreach (var s in teams)
                {
                    ToolStripMenuItem myMenuTeam = new ToolStripMenuItem();
                    myMenuTeam.Name = s.ToString() + "TMI";
                    myMenuTeam.Text = s.ToString();
                    myMenuTeam.Tag = s.GetId;
                    myMenuTeam.Click += new EventHandler(MenuItemClickHandler);
                    this.changeTeamTMI.DropDownItems.Add(myMenuTeam);
                    if (select)
                    {
                        myMenuTeam.PerformClick();
                        select = false;
                    }
                }
            }
        }

        public void OpenDirectory()
        {
            Directory dir = new Directory(this);
            dir.ShowDialog();
        }

        #region Menu Item On-Click Listeners
        #region File Menu
        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            if (clickedItem.Checked == false)
            {
                int teamId = Convert.ToInt32(clickedItem.Tag);
                string swap = @"select AdministrationId, SportId from Teams where TeamId = " + teamId.ToString();

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var command = new SqlCommand(swap, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.AdminId = reader.GetInt32(0);
                                this.SportId = reader.GetInt32(1);
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

        private void SwitchUserTMI_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void NewOrgTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            NewOrg norg = new NewOrg(this);
            norg.MdiParent = this;
            norg.Show();
            norg.WindowState = FormWindowState.Maximized;
        }

        private void ExitTMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

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
        #endregion

    }
}
