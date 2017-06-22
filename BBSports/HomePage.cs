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
        public HomePage()
        {
            InitializeComponent();

            AddTeamOptions();

            Racing raceForm = new Racing();
            raceForm.MdiParent = this;
            raceForm.Show();
            raceForm.WindowState = FormWindowState.Maximized;
        }

        private String ConString()
        {
            String cs = "";
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            return cs;
        }

        private void AddTeamOptions()
        {
            String cs = ConString();
            List<string> teams = new List<string>();

            string sql = @"select TeamName from dbo.Teams
                          where AdministrationId = "+ 1 +
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
            MessageBox.Show("We did it!");
        }

        private void ManageMeetsTMI_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            MeetManager meetMan = new MeetManager();
            meetMan.MdiParent = this;
            meetMan.Show();
            meetMan.WindowState = FormWindowState.Maximized;
        }

        private void ActivateNewSportTMI_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var activate = new ActivateSport();
            activate.Closed += (s, args) => this.Enabled = true;
            activate.Show();
        }
    }
}
