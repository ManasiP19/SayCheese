using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class AbsOrder
    {
        //order has a list of menu items 
        public List<MenuItemIF> mif = new List<MenuItemIF>();
        private int status; //for future 
        private bool statusAvailable;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        //add a menu item to the list 
        public void addItem(MenuItemIF item) 
        {
            mif.Add(item);
            Debug.WriteLine("Items in the order: " + mif);
        }

        //get the total price of the order 
        public double getPrice()
        {
            double totalPrice = 0; 
            foreach (MenuItemIF item in mif)
            {
                totalPrice += item.getPrice();
            }
            return totalPrice; 
        }
        
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    Debug.WriteLine("Deferring to thread");
            
        //    //statusAvailable = true;
        //}

        //synchronized
        [MethodImpl(MethodImplOptions.Synchronized)]
        public int getStatus()
        {
            while (!statusAvailable)
            {
                Debug.WriteLine("In AbsOrder: getStatus(), Wait");
                Monitor.Wait(this); //blocks the current thread until it reacquires the lock 
            }
            return status; 
        }

        //synchronized 
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void setStatus(int status)
        {
            this.status = status;
            Debug.WriteLine("In AbsOrder: setStatus()");
            statusAvailable = true;
            Monitor.Pulse(this); //notify a thread in a waiting queue of a change in the order's status 
        }
    }
}
