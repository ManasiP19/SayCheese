namespace FinalProj
{
    public partial class OrderForm : Form
    {
        public Customer customer;
        PromotionalOffer promo;

        public OrderForm(Customer c)
        {
            InitializeComponent();

            Sauce.Visible = false;
            SauceList.Visible = false;
            AddItem.Visible = false;
            AddonList.Visible = false;

            customer = c;
            promo = new PromotionalOffer();

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
                MenuList.Items.Add(menuIn.ReadLine());
            }

            while (!drinkIn.EndOfStream)
            {
                DrinksList.Items.Add(drinkIn.ReadLine());
            }

            while (!sauceIn.EndOfStream)
            {
                SauceList.Items.Add(sauceIn.ReadLine());
            }

            while (!ingredientIn.EndOfStream)
            {
                AddonList.Items.Add(ingredientIn.ReadLine());
            }

            while (!sideIn.EndOfStream)
            {
                SidesList.Items.Add(sideIn.ReadLine());
            }

            menuIn.Close();
            drinkIn.Close();
            sauceIn.Close();
            ingredientIn.Close();
            sideIn.Close();
        }

        private void PromotionBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PromotionBox.Checked)
            {
                customer.promoChecked = true;
                promo.register(customer);
            }
            else
            {
                customer.promoChecked = false;
                promo.deregister(customer);
            }
        }

        //submit order button
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //factory will create the appropriate menu items only after user presses the submit button 
            //if user does not selecet any add-ons or sauces, just create the menu item using factory
            //if user selects add-ons or sauces, use wrapper to create them 
            //need to keep a list of whatever user has selected in the listboxes so that we can send that to the wrapper
            customer.createOrder();
            PriceLabel.Text = "Total Price: $" + customer.getOrder().getPrice().ToString();
            OrderList.Items.Clear();
        }

        //adds the selected menu item to the order box 
        private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Add(MenuList.SelectedItem.ToString());
            Sauce.Visible = true;
            SauceList.Visible = true;
            AddItem.Visible = true;
            AddonList.Visible = true;
        }

        //listbox2 = drinks
        private void DrinksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Add(DrinksList.SelectedItem.ToString());
        }

        //listbox3 = sauce
        private void SauceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Add(SauceList.SelectedItem.ToString());
        }

        //in order box, when customer clicks on an item, remove it from the box 
        private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Remove(OrderList.SelectedItem);
        }

        //when customer clicks on an ingredient, that is added to the order box
        private void AddonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Add(AddonList.SelectedItem.ToString());
        }

        //listbox6 = sides
        private void SidesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderList.Items.Add(SidesList.SelectedItem.ToString());
        }
    }
}