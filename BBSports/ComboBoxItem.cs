using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSports
{
    class ComboBoxItem
    {
        string onDisplay;
        int itemId;

        //Constructor
        public ComboBoxItem(string d, int id)
        {
            onDisplay = d;
            itemId = id;
        }

        //Accessor
        public int GetId
        {
            get
            {
                return itemId;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return onDisplay;
        }

    }
}
