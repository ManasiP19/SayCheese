using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public  class AbsOrder
    {
        public List<MenuItemIF> mif = new List<MenuItemIF>(); 

        public AbsOrder()
        {
            
        }

        public void addItem(MenuItemIF item) 
        {
            mif.Add(item);
            Debug.WriteLine("Items in the order: " + mif);
        }

        public double getPrice()
        {
            return 0.0; 
        }
    }
}
