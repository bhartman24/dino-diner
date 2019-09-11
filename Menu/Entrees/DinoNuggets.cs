using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int nuggetCount = 6;
        //private bool additionalNugget = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" , "Chicken Nugget", "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            nuggetCount++;
            Ingredients.Add("Chicken Nugget");
            Price += (0.25* nuggetCount);
            Calories += (uint)(59 * nuggetCount);
        }
    }
}
