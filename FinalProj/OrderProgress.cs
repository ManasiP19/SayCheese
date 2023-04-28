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
        private ProgressForm progressForm = new ProgressForm(); 
       
        int status = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        //Task.Run(() => run());
        //Thread thread; 
        public OrderProgress(AbsOrder order, string id) 
        {
            /**java code: 
        * Runnable r = new Runnable()
        * public void run(){
        *  order.setStatus();
        * }*/
            //create a runner thread to run in the bg before an OrderProgress object is instantiated
            //order is a common resource for OrderProgress obj and runner obj to compete with
            //orderprogress delegates to order to prep data i.e. setData() in bg
            this.order = order;
            //thread = new Thread(new ThreadStart(run));
            //thread.Start(); 
            //t.Tick += timer_Tick;
            Task.Run(() => run()); 
            t.Interval = 1000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
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
            Debug.WriteLine("In OrderProgress: Timer started\n");
            Task.Run(() => run());
            getStatus(); 
        }

        public void run( )
        {
            try
            {
                order.setStatus(10);
                Debug.WriteLine("In OrderProgress run(), status: "); 
            }
            catch(Exception ex)
            {
                //order.setException(ex);
                Debug.WriteLine(ex); 
            }
        }

        public int getStatus()
        {
            Debug.WriteLine("In OrderProgress: getStatus()"); 
            int status = order.getStatus();
            if(progressForm.progressBar1.Value >= 100 )
            {
                progressForm.OrderReadyLabel.Visible = true;
                progressForm.progressBar1.Visible = false;
                progressForm.label2.Visible = false;
                progressForm.label3.Visible = false;
                progressForm.label4.Visible = false;
                progressForm.OrderReadyLabel.Text = "Your Order is ready!";
                progressForm.progressBar1.Value = 100;
            }
            else
            {
                Debug.WriteLine("status = " + status);
                progressForm.progressBar1.Value += status;
            }
            
           
            progressForm.Show(); 
            return status; 
        }
    }
}
