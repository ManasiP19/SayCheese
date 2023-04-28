using Accessibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProj
{
    //should inherit from ObserverIF
    public class Customer: ObserverIF
    {
        public OrderForm orderform;
        public PromotionForm promoform;
        public bool promoChecked;
        public string id;
        private AbsOrder order = new AbsOrder();
        public OrderProgress orderProgress;  //future 
        
        public Customer(string id)
        {
            orderform = new OrderForm(this);
            this.id = id; 
            orderform.CustomerName.Text = "Customer " + id; 
            orderform.Show();
        }

        public AbsOrder getOrder() { return order; }

        public string getID() { return id; }

        //add items to their order before it's been created 
        //should show up in the order box 
        public void addItem() { }

        //remove items from their order before it's been created
        //should be deleted from the order box display 
        public void removeItem() { }

        //parse the order box items 
        //create each object from the order box
        //add each object to an array 
        //parse through the array 
        //when we encounter a sandwich object - setSandwich and enter while loop
        //while setSandwich = currentSandwich, 
        //---if the item is an Add-on, then add it to an array called Add-ons
        //---else just add to sandwich ingredients by calling addIngredients()
        //once you encounter a NEW sandwich item or the end of the list, add the currentSandwich to menuItems[] list in order
        public int createOrder()
        {
            // new order object
            Debug.WriteLine("Order is created YAY");

            List<object> orderItems = new List<object>(); // list to store all items from the order placed by the customer
            Factory factory = new Factory();
            orderItems = factory.createMenuItems(orderform.OrderList.Items);
           
            //string cname;
            //// loop through the box with the list of order items, convert the names to their appropriate class objects and
            //// store them in a list

            int idx = 0;
            AbsSandwich currentSandwich = new AbsSandwich();
            List<Drink> drinks = new List<Drink>();
            List<Side> sides = new List<Side>();

            // loop through the list of order items and create the appropriate sandwiches
            foreach (Object item in orderItems)
            {
                // if the order item is a Sandwich object then set the current sandwich = item
                // also add the completed current sandwich from the previous iteration to the order
                if (item is FinalProj.AbsSandwich)
                {
                    // if this is not the first iteration
                    if (idx == 1)
                    {
                        // if there are meal components in the list, add a Meal object
                        if (drinks.Count != 0 || sides.Count != 0)
                        {
                            order.addItem(new Meal(currentSandwich, drinks, sides));
                            // clear the meal component lists
                            drinks.Clear();
                            sides.Clear();
                        }
                        // else add a Sandwich object
                        else
                        {
                            order.addItem(currentSandwich);
                        }
                    }
                    idx = 1; // set flag to 1 to indicate that the first iteration has ended
                    currentSandwich = (AbsSandwich)item; // set the current sandwich to the new sandwich
                }
                // else if the current item is not a sandwich then it is either an add-on ingredient or meal component and
                // add it to its list
                else
                {
                    if (item is Drink)
                    {
                        drinks.Add((Drink)item); // add drinks to the drinks list 
                    }
                    else if (item is Side)
                    {
                        sides.Add((Side)item); //add sides to the sides list 
                    }
                    else
                    {
                        currentSandwich.addIngredient((AbsSandwichIngredients)item); // add to ingredients list with extra ingredient
                    }
                }
            }

            // once loop exited, add the final sandwich to the order list since a sandwich is always added during the next
            // iteration as it needs to know if there are any more add-ons ingredients or meal components
            // if there are meal components in the list, add a Meal object
            if (drinks.Count != 0 || sides.Count != 0)
            {
                order.addItem(new Meal(currentSandwich, drinks, sides));
                // clear the meal components list to start a new sandwich
                drinks.Clear();
                sides.Clear();
            }
            // else add a Sandwich object
            else
            {
                order.addItem(currentSandwich);
            }

            // if the last item is a sandwich, add it to the order
            if (orderItems.Count != 0 && orderItems[orderItems.Count-1] is AbsSandwich)
            {
                order.addItem((AbsSandwich)orderItems[orderItems.Count-1]);
            }
           
            foreach(var m in order.mif)
            {
                Debug.WriteLine("Type of item " + m.GetType());
            }
            Debug.WriteLine("Total price: " + order.getPrice());
            orderProgress = new OrderProgress(order, id);

            return orderProgress.getStatus();
        }

        public async void notify(ObservableIF oif )
        {
            //if customer has registered, then pull up the promo form and have it display every x seconds 
            PromotionForm promoform = new PromotionForm(oif, id);
            promoform.Show(); //display the promo form
            await Task.Delay(3000); //leave the promoform on screen for 3 secs (pop up for 3s)
            promoform.Close(); //close the promoform pop up after 3 s 
        }
    }
}
