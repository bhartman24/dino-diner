using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return AvailableMenuItems;
            }
        }



        public override string ToString()
        {
            return base.ToString();
        }

    }
}
