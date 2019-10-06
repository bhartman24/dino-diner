/* Brontowurst.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool bun = true;
        private bool onions = true;
        private bool peppers = true;
            
            
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Method to implement no bun asked on meal
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            Ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Method to implement no onion asked on meal
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            Ingredients.Remove("Onion");
        }

        /// <summary>
        /// Method to implement no pepper asked on meal
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            Ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Onion", "Peppers" };
                if (bun == false) { Ingredients.Remove("Whole Wheat Bun"); }
                if (onions == false) { Ingredients.Remove("Onion"); }
                if(peppers == false) { Ingredients.Remove("Peppers"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst" ;
        }
    }
}
