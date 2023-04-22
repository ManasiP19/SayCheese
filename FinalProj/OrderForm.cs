namespace FinalProj
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            String menuPath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\Menu.txt";
            String addOnPath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\AddOn.txt";
            String saucePath = "C:\\Users\\NEHA\\PENN STATE\\spring2023\\sweng421 - software architecture\\final proj\\FinalProj\\Sauces.txt";

            StreamReader menuIn = File.OpenText(menuPath);
            StreamReader addOnIn = File.OpenText(addOnPath);
            StreamReader sauceIn = File.OpenText(saucePath);

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
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}