using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public class AbsSandwich : MenuItemIF
    {
        public List<AbsSandwichIngredients> ingredients = new List<AbsSandwichIngredients>();
        double price;

        public AbsSandwich()
        {

        }
        public virtual double getPrice()
        {
            return price; 
        }

        public void setPrice(double price)
        {
            this.price = price; 
        }

        //add an extra ingredient to it (like extra cheese)
        public void addIngredient(AbsSandwichIngredients sif)
        {
            ingredients.Add(sif);
        }

        public override string ToString()
        {
            return "Sandwich"; 
        }
    }
}
