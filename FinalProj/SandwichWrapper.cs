using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public  class SandwichWrapper: AbsSandwich
    {
        AbsSandwich sandwich;
        List<AddOn> addons = new List<AddOn>();

        public SandwichWrapper(AbsSandwich sandwich, List<AddOn> addon)
        {
            this.sandwich = sandwich;
            this.ingredients = sandwich.ingredients;
            foreach (AddOn add in addon)
            {
                addons.Add(add);
            }
        }

    }
}
