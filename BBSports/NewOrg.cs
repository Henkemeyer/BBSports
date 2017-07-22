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
    public partial class NewOrg : Form
    {
        private HomePage homebase = null;
        private String cs = "";

        public NewOrg(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            cs = cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (var cmd = new SqlCommand("UpdateOrg", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@userId", SqlDbType.Int).Value = homebase.AthleteId;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = tbOrgName.Text;
                    cmd.Parameters.Add("@teams", SqlDbType.VarChar).Value = numericTeams.Value;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = tbOrgCity.Text;
                    cmd.Parameters.Add("@state", SqlDbType.Char).Value = tbOrgState.Text;
                    cmd.Parameters.Add("@classification", SqlDbType.VarChar).Value = cbClass.Text;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            homebase.AdminId = reader.GetInt32(0);
                    }
                }
            }
            TeamManager teams = new TeamManager(homebase);
            teams.MdiParent = homebase;
            teams.Show();
            teams.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
