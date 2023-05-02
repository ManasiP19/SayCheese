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

        public ProgressForm()
        {
            InitializeComponent();
            OrderReadyLabel.Visible = false;
            OrderLabel.Visible = false;
        }
    }
}
