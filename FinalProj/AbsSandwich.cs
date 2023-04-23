using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class AbsSandwich : MenuItemIF
    {
        public List<SandwichCompIF> ingredients = new List<SandwichCompIF>();
        double price; 
        public AbsSandwich()
        {

        }
        public double getPrice()
        {
            return price; 
        }

        public void setPrice(double price)
        {
            this.price = price; 
        }

        //add an extra ingredient to it (like extra cheese)
        public void addIngredient(SandwichCompIF sif)
        {
            ingredients.Add(sif);
        }

       /* public void addIngredient(AddOn ao)
        {
            SandwichWrapper wrapper = new SandwichWrapper(this, ao);
        }*/
    }
}
