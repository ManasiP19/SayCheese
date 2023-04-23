namespace FinalProj
{
    public partial class OrderForm : Form
    {
        public Customer customer;
        public OrderForm(Customer c)
        {
            InitializeComponent();
            customer = c;
            string menuPath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\Menu.txt";
            string addOnPath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\AddOn.txt";
            string saucePath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\Sauces.txt";
            string ingredientsPath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\Ingredients.txt";

            StreamReader menuIn = File.OpenText(menuPath);
            StreamReader addOnIn = File.OpenText(addOnPath);
            StreamReader sauceIn = File.OpenText(saucePath);
            StreamReader ingredientIn = File.OpenText(ingredientsPath);

            while (!menuIn.EndOfStream)
            {
                listBox1.Items.Add(menuIn.ReadLine());
            }

            while (!addOnIn.EndOfStream)
            {
                listBox2.Items.Add(addOnIn.ReadLine());
            }

            while (!sauceIn.EndOfStream)
            {
                listBox3.Items.Add(sauceIn.ReadLine());
            }

            while (!ingredientIn.EndOfStream)
            {
                listBox5.Items.Add(ingredientIn.ReadLine());
            }

            menuIn.Close();
            addOnIn.Close();
            sauceIn.Close();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


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
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
        }

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
               
    }
}