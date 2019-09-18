/* DinoNuggets.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool additionalNugget = false;
        private int nuggetCount = 6;

        /// <summary>
        /// Property for price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property for calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property for ingredients
        /// </summary>
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

        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint)(59*nuggetCount);
        }

        /// <summary>
        /// Method to add a nugget which adds the nugget count, 
        /// price, and calories with it.
        /// </summary>
        public void AddNugget()
        {
            this.additionalNugget = true;
            nuggetCount++;
            Price = 4.25 + ((nuggetCount - 6) * 0.25);
            Calories = (uint)(59 * nuggetCount);
        }
    }
}
