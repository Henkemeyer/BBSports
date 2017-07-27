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
    public partial class Directory : Form
    {
        SportsForm padre = null;

        public Directory(SportsForm sf)
        {
            InitializeComponent();
            padre = sf;
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            padre.SearchId = 1;
            this.Close();
        }
    }
}
