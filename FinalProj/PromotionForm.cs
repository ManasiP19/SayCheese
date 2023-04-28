using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class PromotionForm : Form
    {
        List<string> promoStrings = new List<string>();
        public PromotionForm(ObservableIF oif, string customerID)
        {
            InitializeComponent();
            promoStrings = oif.getList(); //get the list of promo strings from PromotionalOffer
            //pick a random string and display it in the box
            var rand = new Random();
            int idx = rand.Next(0, 3);
            richTextBox1.Text = promoStrings[idx];

            label2.Text = "Customer " + customerID; //label with the customer who registered
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
