/* PterodactylWings.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the PterodactylWings entree.
    /// </summary>
    public class PterodactylWings
    {
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
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
