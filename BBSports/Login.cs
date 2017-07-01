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
        HomePage homebase = null;
        public Login(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            homebase.SetAdmin(1);
            this.Close();
        }
    }
}
