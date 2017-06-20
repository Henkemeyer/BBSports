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

        private void SetAvailableSports()
        {
            var con = ConfigurationManager.ConnectionStrings["BBSports.Temp"].ConnectionString;

            List<string> sports = new List<string>();
            string sql = @"select SportName from SupportedSports";
            using (SqlConnection connection = new SqlConnection(con))
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
            {   this.lOther.Visible = true;
                this.tbOther.Visible = true; }
            else
            {   this.lOther.Visible = false;
                this.tbOther.Visible = false; }
        }
    }

    public class SupportedSports
    {
        public string SportName { get; set; }
    }
}
