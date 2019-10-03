/* PterodactylWings.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the PterodactylWings entree.
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            this.Ingredients = new List<string>() { "Chicken", "Wing Sauce", };
        }

        public override string ToString()
        {
            return "PterodactylWings";
        }
    }
}
