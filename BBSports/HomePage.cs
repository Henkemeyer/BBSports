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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void CreateMeetTMI_Click(object sender, EventArgs e)
        {
            var meetMan = new MeetManager();
            meetMan.Closed += (s, args) => this.Close();
            meetMan.Show();
        }

        private void ActivateNewSportTMI_Click(object sender, EventArgs e)
        {
            var activate = new ActivateSport();
            activate.Closed += (s, args) => this.Close();
            activate.Show();
        }
    }
}
