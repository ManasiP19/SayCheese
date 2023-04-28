using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public class Factory
    {
        //some method to create menuItem classes based on strings 
        public List<object> createMenuItems(ListBox.ObjectCollection orderItemsList)
        {
            List<object> orderItems = new List<object>(); // list to store all items from the order placed by the customer

            string cname;
            // loop through the box with the list of order items, convert the names to their appropriate class objects and
            // store them in a list
            foreach (string item in orderItemsList)
            {
                cname = String.Concat(item.Where(c => !Char.IsWhiteSpace(c)));
                Type t = Type.GetType("FinalProj." + cname);
                ConstructorInfo c = t.GetConstructor(Type.EmptyTypes);
                object menuItem = c.Invoke(null);

                orderItems.Add(menuItem);
            }

            return orderItems;
        }
    }
}
