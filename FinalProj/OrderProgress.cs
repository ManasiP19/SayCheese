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
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
 
        public OrderProgress(AbsOrder order, string id) 
        {
            //create a runner thread to run in the bg before an OrderProgress object is instantiated
            //order is a common resource for OrderProgress obj and runner obj to compete with
            //orderprogress delegates to order to prep data i.e. setData() in bg
            this.order = order;
            Task.Run(() => run()); 
            t.Interval = 1000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

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
