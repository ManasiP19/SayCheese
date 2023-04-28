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
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int newProgValue = progValue + ProgressBar.Value; 
            if(newProgValue >= 100)
            {
                this.Close();
            }
            else
            {
                Debug.WriteLine("In ProgressForm: Updating progress bar value");
                ProgressBar.Value += newProgValue;
            }
        }
    }
}
