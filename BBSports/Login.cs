using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Replace with commented out code eventually
            this.Hide();
            var home = new HomePage();
            home.Closed += (s, args) => this.Close();
            home.Show();
            /* if (tbUsername.Text == "Henkemeyer" && tbPassword.Text == "a")
            {
                this.Hide();
                var home = new HomePage();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("Username and Password do not match.","Uh-Oh");
            }*/
        }
    }
}
