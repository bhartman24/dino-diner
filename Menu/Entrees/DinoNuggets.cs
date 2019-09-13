/* DinoNuggets.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private bool additionalNugget = false;
        private int nuggetCount = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                if (additionalNugget) {
                    for(int i = nuggetCount - 6; i >0; i--)
                    {
                        ingredients.Add("Chicken Nugget");
                    }
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint)(59*nuggetCount);
        }

        public void AddNugget()
        {
            this.additionalNugget = true;
            nuggetCount++;
            Price = 4.25 + ((nuggetCount - 6) * 0.25);
            Calories = (uint)(59 * nuggetCount);
        }
    }
}
