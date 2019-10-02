/* DinoNuggets.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool additionalNugget = false;
        private int nuggetCount = 6;


        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint)(59*nuggetCount);
            this.Ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
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
            Ingredients.Add("Chicken Nugget");
        }
    }
}
