using System;
using System.Configuration;
using System.Windows.Forms;

namespace BBSports
{
    public partial class SportsForm : Form
    {
        public HomePage homebase = null;
        public int searchId = 0;

        public HomePage Homebase
        {
            get => homebase;
            set => homebase = value;
        }

        public int SearchId
        {
            get => searchId;
            set => searchId = value;
        }

        public SportsForm()
        {
            InitializeComponent();
        }
    }
}
