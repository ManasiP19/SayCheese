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

            List<object> orderItems = new List<object>();



            foreach (string item in orderform.listBox4.Items)
            {
                // Debug.WriteLine(name);
                //Debug.WriteLine(Type.GetType(name));
                Type t = Type.GetType("FinalProj." + item);


                ConstructorInfo c = t.GetConstructor(Type.EmptyTypes);
                object menuItem = c.Invoke(null);


                //Debug.WriteLine(Type.GetType(menuItem.ToString()));

                //if you have an add-on, get the sandwich and then pass that sandwich along with the add-on to a wrapper
                orderItems.Add(menuItem);

                //order.addItem((MenuItemIF)menuItem);
            }

            int idx = 0;
            AbsSandwich currentSandwich = new AbsSandwich();
            List<AddOn> addon = new List<AddOn>();
            foreach (Object item in orderItems)
            {
                if (item is FinalProj.AbsSandwich)
                {
                    if (idx == 1)
                    {
                        if (addon is not null)
                        {
                            order.addItem(new SandwichWrapper(currentSandwich, addon));
                        }
                        else
                        {
                            order.addItem(currentSandwich);
                        }
                    }
                    idx = 1;
                    currentSandwich = (AbsSandwich)item;
                }
                while (!(item is AbsSandwich))
                {
                    if (item is AddOn)
                    {
                        addon.Add((AddOn)item);
                        //Debug.WriteLine("Item " + item);
                    }
                    else
                    {
                        currentSandwich.addIngredient((SandwichCompIF)item);
                    }
                    break;
                }
                //Debug.WriteLine("Order list has " + order);

              

            }
           
            if (orderItems[orderItems.Count-1] is AbsSandwich)
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
