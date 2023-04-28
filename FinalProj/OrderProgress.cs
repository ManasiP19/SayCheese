using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProj
{
    //future 
    public class OrderProgress
    {
        private AbsOrder order;
       
        int status = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public OrderProgress(AbsOrder order, string id) {
            /**java code: 
        * Runnable r = new Runnable()
        * public void run(){
        *  order.setStatus();
        * }*/
            //create a runner thread to run in the bg before an OrderProgress object is instantiated
            //order is a common resource for OrderProgress obj and runner obj to compete with
            //orderprogress delegates to order to prep data i.e. setData() in bg

          
            this.order = order;
            /* ProgressForm progressForm = new ProgressForm(getStatus(), id);
             progressForm.Show();*/
            t.Interval = 3000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
            new Thread(new ThreadStart(run)).Start();
            

        }

        /**java code: 
         * Runnable r = new Runnable()
         * public void run(){
         *  order.setStatus();
         * }
         * public string getStatus(){
         *  order.getStatus();
         * }
         */

        private void timer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Timer started\n"); 
            status += 33; 
        }


        public void run()
        {
            try
            {
              
                order.setStatus(status);
                Debug.WriteLine("status " + status); 
            }
            catch(Exception ex)
            {
                //order.setException(ex);
                Debug.WriteLine(ex); 
            }
           
       }

        public int getStatus()
        {
           return order.getStatus(); 
        }
    }
}
