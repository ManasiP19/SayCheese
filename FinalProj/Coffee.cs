using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class Coffee: Drink 
    {
        public Coffee() { setPrice(4.00); }

        public override string ToString()
        {
            return "Coffee";
        }
    }
}
