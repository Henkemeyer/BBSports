using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class Directory : UserControl
    {
        public Directory()
        {
            InitializeComponent();
        }

        public class SelectedItemEventArgs : EventArgs
        {
            public int SelectedChoice { get; set; }
        }

        public event EventHandler<SelectedItemEventArgs> ItemHasBeenSelected;

        private void Select_Click(object sender, EventArgs e)
        {
            var handler = ItemHasBeenSelected;
            if (handler != null)
            {
                handler(this, new SelectedItemEventArgs
                { SelectedChoice = 1 });
            }
            Parent.Controls.Remove(this);
        }

    }
}
