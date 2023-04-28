using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class HamNCheese: AbsSandwich
    {
        public HamNCheese()
        {
            setPrice(4.00);
            ingredients.Add(new Ham());
            ingredients.Add(new Cheese());
            ingredients.Add(new Bread());
        }

        public override string ToString()
        {
            return "HamNCheese"; 
        }


    }
}
