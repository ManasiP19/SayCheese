namespace FinalProj
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            String menuPath = "C:\\Users\\Laura\\Documents\\SWENG 421\\FinalProj\\FinalProj\\Menu.txt";
            String addOnPath = "C:\\Users\\Laura\\Documents\\SWENG 421\\FinalProj\\FinalProj\\AddOn.txt";
            String saucePath = "C:\\Users\\Laura\\Documents\\SWENG 421\\FinalProj\\FinalProj\\Sauces.txt";

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}