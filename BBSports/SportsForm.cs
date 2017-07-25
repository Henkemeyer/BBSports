using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class SportsForm : Form
    {
        public string cs = "";
        private HomePage homebase = null;
        private int searchId = 0;

        public HomePage Homebase
        {
            get { return homebase; }

            set { homebase = value; }
        }

        public int SearchId
        {
            get { return searchId; }

            set { searchId = value; }
        }

        public SportsForm()
        {
            InitializeComponent();
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
        }
    }
}
