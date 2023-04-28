using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public  class EggNCheese : Sandwich
    {
        public EggNCheese()
        {
            setPrice(3.00);
            ingredients.Add(new Bread());
            ingredients.Add(new Egg());
            ingredients.Add(new Cheese());
        }

        public override string ToString()
        {
            return "EggNCheese"; 
        }
    }
}
