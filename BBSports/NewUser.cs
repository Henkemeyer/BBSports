using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BBSports
{
    public partial class NewUser : SportsForm
    {
        private System.Windows.Forms.ErrorProvider emailErrorProvider;

        public NewUser(HomePage hp)
        {
            InitializeComponent();
            Homebase = hp;

            emailErrorProvider = new System.Windows.Forms.ErrorProvider();
            emailErrorProvider.SetIconAlignment(this.tbEmail, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(this.tbEmail, 2);
            emailErrorProvider.BlinkRate = 1000;
            emailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (bSubmit.Text == "Reset")
            {
                Homebase.NewUser();
                this.Close();
                return;
            }

            if (tbEmail.TextLength < 6 || !tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
            {
                MessageBox.Show("Entered E-Mail is not valid", "Error");
                return;
            }

            int userId = Decimal.ToInt32(numericAthleteId.Value);

            string gender = "Female";            

            if (rbMale.Checked)
                gender = "Male";

            try
            {
                using (SqlConnection connection = new SqlConnection(Homebase.CS))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand("UpdateUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@first", SqlDbType.VarChar).Value = tbFirst.Text;
                        cmd.Parameters.Add("@middle", SqlDbType.VarChar).Value = tbMiddle.Text;
                        cmd.Parameters.Add("@last", SqlDbType.VarChar).Value = tbLast.Text;
                        cmd.Parameters.Add("@nick", SqlDbType.VarChar).Value = "";
                        cmd.Parameters.Add("@gender", SqlDbType.Char).Value = gender;
                        cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = DateTime.Parse(mtbBirthday.Text);
                        cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = "";
                        cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = cbGrade.Text;
                        cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = tbCity.Text;
                        cmd.Parameters.Add("@state", SqlDbType.Char).Value = tbState.Text.ToUpper();
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = SaltNPepper.CreateHash(tbPassword.Text);
                        cmd.Parameters.Add("@claimed", SqlDbType.Int).Value = 1;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                Homebase.AthleteId = reader.GetInt32(0);
                        }
                    }
                    if (cxbNewOrg.Checked)
                    {
                        NewOrg norg = new NewOrg(Homebase);
                        norg.MdiParent = Homebase;
                        norg.Show();
                        norg.WindowState = FormWindowState.Maximized;
                        this.Close();
                        return;
                    }
                    Homebase.LoadFirstPage();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Homebase.ChangeUser();
        }

        private void ExitTMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelTMI_Click(object sender, EventArgs e)
        {
            Homebase.ChangeUser();
        }

        private void NumericAthleteId_Leave(object sender, EventArgs e)
        {
            string check = String.Format(@"select FirstName, MiddleName, LastName, Gender, Grade, City, State, " +
                                        "format(Birthday, 'MM/dd/yyyy'), Claimed from Users where UserId = {0}",
                                        Decimal.ToInt32(numericAthleteId.Value));
            string gender = "";
            Boolean claimed = false;

            using (SqlConnection connection = new SqlConnection(Homebase.CS))
            {
                using (var cmd = new SqlCommand(check, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tbFirst.Text = reader.GetString(0);
                                tbMiddle.Text = reader.GetString(1);
                                tbLast.Text = reader.GetString(2);
                                gender = reader.GetString(3).TrimEnd(' ');
                                cbGrade.SelectedIndex = cbGrade.FindString(reader.GetString(4));
                                tbCity.Text = reader.GetString(5);
                                tbState.Text = reader.GetString(6);

                                mtbBirthday.Text = reader.GetString(7);
                                claimed = reader.GetBoolean(reader.GetOrdinal("Claimed"));
                            }

                            if (gender == "Female")
                                rbFemale.Checked = true;
                            else
                                rbMale.Checked = true;

                            lTempPW.Visible = true;
                            tbTempPW.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("We found no user with an ID of " + numericAthleteId.Value.ToString(), "Error");
                            numericAthleteId.Value = 0;
                        }
                    }
                }
            }

            if (claimed)
            {
                lIntro.Text = "This account has already been claimed. 'Switch User' to login, or if you believe this to be a mistake contact Tyler.";
                bSubmit.Text = "Reset";
                tbPassword.Enabled = false;
                tbPWCheck.Enabled = false;
                tbEmail.Enabled = false;
                tbTempPW.Enabled = false;
            }
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbEmail.TextLength > 0)
            {
                if (tbEmail.TextLength < 6 || !tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
                {
                    e.Cancel = true;  
                    this.emailErrorProvider.SetError(tbEmail, "This E-mail is not valid");
                }

                string check = @"select 'x' from Users where Email = '" + tbEmail.Text + "'";

                using (SqlConnection connection = new SqlConnection(Homebase.CS))
                {
                    using (var cmd = new SqlCommand(check, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                e.Cancel = true;
                                tbEmail.Select(0, tbEmail.Text.Length);
                                this.emailErrorProvider.SetError(tbEmail, "This E-mail has already been used for another account.");
                            }
                        }
                    }
                }
            }
        }
    }
}
