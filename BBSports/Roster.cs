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
    public partial class Roster : Form
    {
        private string cs = "";
        private HomePage homebase = null;

        public Roster(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
        }

        private void Roster_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            GetRoster();
        }

        private void GetRoster()
        {
            DataTable dt = new DataTable();
            DataGridViewComboBoxColumn status = (DataGridViewComboBoxColumn)dgRoster.Columns["Status"];
            SqlDataAdapter adapter = new SqlDataAdapter();

            string getStatus = @"select Description from AthleteStatus";
            List<string> listStat = new List<string>();

            string alumni = "Alumni", cut = "Cut";

            if (alumniToolStripMenuItem.Checked)
                alumni = "";

            if (cutToolStripMenuItem.Checked)
                cut = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(getStatus, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listStat.Add(reader.GetString(0));
                            }
                        }
                    }
                    using (var cmd = new SqlCommand("GetRoster", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = homebase.TeamId;
                        cmd.Parameters.Add("@alumni", SqlDbType.VarChar).Value = alumni;
                        cmd.Parameters.Add("@cut", SqlDbType.VarChar).Value = cut;

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetRoster", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dgRoster.DataSource = dt;
            dgRoster.Columns.AddRange(status);
            status.DataSource = listStat;
        }

        private void AlumniToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            GetRoster();
        }

        private void CutToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            GetRoster();
        }
    }
}
