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
    public class Customer
    {
        private OrderForm orderform;
        private ProgressForm progform;
        private PromotionForm promoform;

        private AbsOrder order = new AbsOrder();

        public Customer()
        {
            orderform = new OrderForm(this);
            orderform.Show();
        }

        //notify if they register for pomotions 
        public void notify()
        {

        }

        //add items to their order before it's been created 
        //should show up in the order box 
        public void addItem()
        {

        }

        //remove items from their order before it's been created
        //should be deleted from the order box display 
        public void removeItem()
        {

        }

        //parse the order box items 
        //create each object from the order box
        //add each object to an array 
        //parse through the array 
        //when we encounter a sandwich object - setSandwich and enter while loop
        //while setSandwich = currentSandwich, 
        //---if the item is an Add-on, then add it to an array called Add-ons
        //---else just add to sandwich ingredients by calling addIngredients()
        //once you encounter a NEW sandwich item or the end of the list, add the currentSandwich to menuItems[] list in order
        public void createOrder()
        {
            // new order object
            Debug.WriteLine("Order is created YAY");

            List<object> orderItems = new List<object>(); // list to store all items from the order placed by the customer

            string cname;
            // loop through the box with the list of order items, convert the names to their appropriate class objects and
            // store them in a list
            foreach (string item in orderform.listBox4.Items)
            {
                cname = String.Concat(item.Where(c => !Char.IsWhiteSpace(c)));
                Type t = Type.GetType("FinalProj." + cname);
                ConstructorInfo c = t.GetConstructor(Type.EmptyTypes);
                object menuItem = c.Invoke(null);

                orderItems.Add(menuItem);
            }

            int idx = 0;
            AbsSandwich currentSandwich = new AbsSandwich();
            List<AddOn> addon = new List<AddOn>();

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
                        // if there are add-ons in the list, add a SandwichWrapper object
                        if (addon.Count != 0)
                        {
                            order.addItem(new SandwichWrapper(currentSandwich, addon));
                            addon.Clear(); // clear the add-ons list to start a new sandwich
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
                // else if the current item is not a sandwich then it is either an add-on or ingredient and add it to its list
                else //(!(item is AbsSandwich))
                {
                    if (item is AddOn)
                    {
                        addon.Add((AddOn)item); // add add-on to the add-ons list
                    }
                    else
                    {
                        currentSandwich.addIngredient((SandwichCompIF)item); // add sandwich's ingredients list with extraingredient
                    }
                }
            }

            // once loop exited, add the final sandwich to the order list since a sandwich is always added during the next
            // iteration as it needs to know if there are any more add-ons or ingredients
            if (addon.Count != 0)
            {
                order.addItem(new SandwichWrapper(currentSandwich, addon));
                addon.Clear();
            }
            else
            {
                order.addItem(currentSandwich);
            }

            // if the last item is a sandwich, add it to the order
            if (orderItems.Count != 0 && orderItems[orderItems.Count-1] is AbsSandwich)
            {
                order.addItem((AbsSandwich)orderItems[orderItems.Count-1]);
            }

            foreach(MenuItemIF m in order.mif)
            {
                Debug.WriteLine("Item in order " + m);
            }
        }
    }
}
