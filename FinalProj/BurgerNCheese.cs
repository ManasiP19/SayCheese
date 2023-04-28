using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class BurgerNCheese : AbsSandwich
    { 
        public BurgerNCheese()
        {
            setPrice(5.00);
            ingredients.Add(new Beef());
            ingredients.Add(new Cheese());
            ingredients.Add(new Bread()); 
        }

        public override string ToString()
        {
            return "BurgerNCheese";
        }
    }
}
