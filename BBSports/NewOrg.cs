using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBSports
{
    public partial class NewOrg : SportsForm
    {
        public NewOrg(HomePage hp)
        {
            InitializeComponent();
            Homebase = hp;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Homebase.CS))
            {
                connection.Open();
                using (var cmd = new SqlCommand("UpdateOrg", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@userId", SqlDbType.Int).Value = Homebase.AthleteId;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = tbOrgName.Text;
                    cmd.Parameters.Add("@teams", SqlDbType.VarChar).Value = numericTeams.Value;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = tbOrgCity.Text;
                    cmd.Parameters.Add("@state", SqlDbType.Char).Value = tbOrgState.Text;
                    cmd.Parameters.Add("@classification", SqlDbType.VarChar).Value = cbClass.Text;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Homebase.AdminId = reader.GetInt32(0);
                    }
                }
            }
            TeamManager teams = new TeamManager(Homebase);
            teams.MdiParent = Homebase;
            teams.Show();
            teams.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
