using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    //Meal Wrapper
    //Customer can order a sandwich along with drink(s) and side(s)
    public  class Meal: Sandwich
    {
        Sandwich sandwich;
        List<Drink> drinks = new List<Drink>();
        List<Side> sides = new List<Side>();

        public Meal(Sandwich sandwich, List<Drink> drinks, List<Side> sides)
        {
            this.sandwich = sandwich;

            if (drinks.Count != 0)
            {
                foreach (Drink drink in drinks)
                {
                    this.drinks.Add(drink);
                }
            }

            if (sides.Count != 0)
            {
                foreach (Side side in sides)
                {
                    this.sides.Add(side);
                }
            }
        }

        //override getPrice() of superclass to provide additional functionality -- calculate price of a meal 
        public override double getPrice()
        {
            double price = sandwich.getPrice();
            foreach(Drink drink in drinks)
            {
                price += drink.getPrice();
            }
            foreach(Side side in sides)
            {
                price += side.getPrice(); 
            }
            return price; 
        }

        public override string ToString()
        {
            return "Meal (Wrapper)"; 
        }
    }
}
