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
    public partial class Racing : Form
    {
        private string cs = "";

        public Racing(HomePage HP)
        {
            InitializeComponent();
            StartUp();
        }

        // Startup does some additional initialization for the Form.
        // Gets the connection string, gets list of recent meets and relevent events, and athletes.
        private void StartUp()
        {
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;

            GetMeets();
        }

        private void GetMeets()
        {
            DataTable meets = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource recentMeets = new BindingSource();

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand("GetMeets", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@beginDate", SqlDbType.DateTime).Value = System.DateTime.Now.AddMonths(-4);
                        cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = System.DateTime.Now.AddDays(3);
                        cmd.Parameters.Add("@sportId", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@teamId", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@include", SqlDbType.VarChar).Value = "Current";

                        adapter.SelectCommand = cmd;
                        adapter.Fill(meets);
                    }
}
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            recentMeets.DataSource = meets;
            cbMeet.DataSource = recentMeets;
        }
    }
}
