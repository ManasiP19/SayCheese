using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class ProgressForm : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int progValue; 
        public ProgressForm()
        {
            InitializeComponent();
            OrderReadyLabel.Visible = false;
            //progValue += value; 
            //label5.Text = "Customer " + customerID;
            //progressBar1.Value = progValue; 
           /* t.Interval = 3000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();*/
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int newProgValue = progValue + progressBar1.Value; 
            if(newProgValue >= 100)
            {
                //t.Stop();
                this.Close();
            }
            else
            {
                Debug.WriteLine("In ProgressForm: Updating progress bar value");
                progressBar1.Value += newProgValue;
            }
        }
    }
}
