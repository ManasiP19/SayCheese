using System.Diagnostics;
using System.Timers;


namespace FinalProj
{
    public class PromotionalOffer : ObservableIF
    {
        private List<ObserverIF> observerList = new List<ObserverIF>(); //list of customers who have registered
        public List<string> promos = new List<string>();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public PromotionalOffer()
        {
            promos.Add("30% off your next order! Use code: 3zeroOFF");
            promos.Add("Enjoy a free sandwich with the purchase of a sandwich. Use code: FREEYUM");
            promos.Add("10% off on Mother's Day! Use code: MomIsCool");
            t.Interval = 8000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            showPromo();
        }
    
        //if customer no longer wishes to receive promo offers, deregister and remove from the list 
        public void deregister(ObserverIF o)
        {
            observerList.Remove(o);
            Debug.WriteLine("Customer " + o.getID() + "deregistered\n ");
        }

        //if a customer checks the promotional offer box, register them and put them in a list 
        public void register(ObserverIF o)
        {
            observerList.Add(o);
            Debug.WriteLine("Customer " + o.getID() + "registered\n ");
        }

        //some function that will pop up promos after every x seconds
        //calls notify() for every customer who is in the list 
        public void showPromo()
        {
            foreach (ObserverIF o in observerList)
            {
                Debug.WriteLine("Notifying customer \n");
                o.notify(this);               
            }
        }

        //get a list of the available promo strings 
        public List<string> getList()
        {
            return promos; 
        }
    }
}
