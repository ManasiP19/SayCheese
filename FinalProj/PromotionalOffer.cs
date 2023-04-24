using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace FinalProj
{
    public class PromotionalOffer : ObservableIF
    {
        private List<ObserverIF> observerList = new List<ObserverIF>(); //list of customers who have registered 
       
        public List<string> promos = new List<string>();
        private static System.Timers.Timer aTimer = new System.Timers.Timer(2000);
        
        public PromotionalOffer()
        {
            promos.Add("30% off your next order! Use code: 3zeroOFF");
            promos.Add("Enjoy a free sandwich with the purchase of a sandwich. Use code: FREEYUM");
            promos.Add("10% off on Mother's Day! Use code: MomIsCool");
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }
        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Debug.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            showPromo();
            
        }

        //if customer no longer wishes to receive promo offers, deregister and remove from the list 
        public void deregister(ObserverIF o)
        {
            observerList.Remove(o);
            Debug.WriteLine("Customer " + o + "deregistered\n ");
            showPromo();
        }

        //if a customer checks the promotional offer box, register them and put them in a list 
        public void register(ObserverIF o)
        {
           
            observerList.Add(o);
            Debug.WriteLine("Customer " + o + "registered\n ");

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
            aTimer.Dispose();

        }
    }
}
