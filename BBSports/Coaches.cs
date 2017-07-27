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
    public partial class Coaches : SportsForm
    {
        public Coaches(HomePage hp)
        {
            InitializeComponent();
            Homebase = hp;
            FillTable();
        }

        private void FillTable()
        {
            DataTable coaches = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource selectedCoaches = new BindingSource();

            try
            {
                using (SqlConnection connection = new SqlConnection(Homebase.CS))
                {
                    using (var cmd = new SqlCommand("GetCoaches", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = homebase.AdminId;

                        adapter.SelectCommand = cmd;
                        adapter.Fill(coaches);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            selectedCoaches.DataSource = coaches;
            dgvCoaches.DataSource = selectedCoaches;
        }

        private void Directory_Click(object sender, EventArgs e)
        {
            Directory dir = new Directory(this);
            dir.ShowDialog();
        }

        private void NewCoach_Click(object sender, EventArgs e)
        {
            Homebase.AddToTeam("Coach");
        }
    }
}
