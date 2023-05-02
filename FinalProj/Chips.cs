using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class Chips: Side
    {
        public Chips() { setPrice( 4.50); }

        public override string ToString()
        {
            return "Chips";
        }
    }
}
