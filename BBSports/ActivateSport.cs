using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class ActivateSport : Form
    {
        public ActivateSport()
        {
            InitializeComponent();

            SetAvailableSports();
        }

        private String ConString()
        {
            String cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            return cs;
        }

        private void SetAvailableSports()
        {
            String cs = ConString();
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
        }

        private void Sports_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbTeamName.Text = this.cbSports.Text;
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
                String cs = ConString();
                String gender;
                if (rbFemale.Checked)
                    gender = "Female";
                else
                    gender = "Male";

                using (SqlConnection connection = new SqlConnection(cs)) {
                    using (var cmd = new SqlCommand("ActivateNewSport", connection)) {
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
                this.Hide();
            }
        }
    }
}
