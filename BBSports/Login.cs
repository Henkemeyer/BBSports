using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBSports
{
    public partial class Login : Form
    {
        private string cs = "";
        HomePage homebase = null;

        public Login(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (tbEmail.TextLength < 6 || !tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
                MessageBox.Show("Entered E-Mail is not valid", "Error");
            else if (tbPassword.TextLength < 1)
                MessageBox.Show("Please enter your password.", "Error");
            else
            {
                string user = String.Format(@"select UserId, Password from Users where Email = '{0}'", tbEmail.Text);
                string password = "";
                int userId = 0;
                Boolean valid = false;

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(user, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    userId = reader.GetInt32(0);
                                    password = reader.GetString(1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No account found with that E-Mail", "Error");
                                return;
                            }
                        }
                    }
                }
                valid = SaltNPepper.VerifyPassword(tbPassword.Text, password);

                if (valid)
                {
                    homebase.AthleteId = userId;
                    homebase.LoadFirstPage();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid username and password combination", "Error");
            }
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            homebase.NewUser();
            this.Close();
        }
    }
}
