namespace FinalProj
{
    public partial class OrderForm : Form
    {
        public Customer customer;

        public OrderForm(Customer c)
        {
            InitializeComponent();
            //label2.Visible = false;
            //listBox2.Visible = false;
            //label3.Visible = false;
            //listBox3.Visible = false;
            //label5.Visible = false;
            //listBox5.Visible = false;

            customer = c;

            string menuPath = "..\\..\\..\\Menu.txt";
            string sidesPath = "..\\..\\..\\Sides.txt";
            string saucePath = "..\\..\\..\\Sauces.txt";
            string ingredientsPath = "..\\..\\..\\Ingredients.txt";
            string drinksPath = "..\\..\\..\\Drinks.txt";

            StreamReader menuIn = File.OpenText(menuPath);
            StreamReader drinkIn = File.OpenText(drinksPath);
            StreamReader sauceIn = File.OpenText(saucePath);
            StreamReader ingredientIn = File.OpenText(ingredientsPath);
            StreamReader sideIn = File.OpenText(sidesPath);

            while (!menuIn.EndOfStream)
            {
                listBox1.Items.Add(menuIn.ReadLine());
            }

            while (!drinkIn.EndOfStream)
            {
                listBox2.Items.Add(drinkIn.ReadLine());
            }

            while (!sauceIn.EndOfStream)
            {
                listBox3.Items.Add(sauceIn.ReadLine());
            }

            while (!ingredientIn.EndOfStream)
            {
                listBox5.Items.Add(ingredientIn.ReadLine());
            }

            while (!sideIn.EndOfStream)
            {
                listBox6.Items.Add(sideIn.ReadLine());
            }

            menuIn.Close();
            drinkIn.Close();
            sauceIn.Close();
            ingredientIn.Close();
            sideIn.Close(); 
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                customer.promoChecked = true;
                PromotionalOffer promo = new PromotionalOffer();
                promo.register(customer);

            }
            else
            {
                customer.promoChecked = false;
            }
        }

        //submit order button
        private void button1_Click(object sender, EventArgs e)
        {
            //factory will create the appropriate menu items only after user presses the submit button 
            //if user does not selecet any add-ons or sauces, just create the menu item using factory
            //if user selects add-ons or sauces, use wrapper to create them 
            //need to keep a list of whatever user has selected in the listboxes so that we can send that to the wrapper
            customer.createOrder();
        }

        //adds the selected menu item to the order box 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox1.SelectedItem.ToString());
            //label2.Visible = true;
            //listBox2.Visible = true;
            //label5.Visible = true;
            //listBox5.Visible = true;
        }

        //listbox2 = drinks
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
        }

        //listbox3 = sauce
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox3.SelectedItem.ToString());
        }


        //in order box, when customer clicks on an item, remove it from the box 
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        //when customer clicks on an ingredient, that is added to the order box
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox5.SelectedItem.ToString());
        }

        //listbox6 = sides
        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox6.SelectedItem.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}