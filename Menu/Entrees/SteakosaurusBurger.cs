/* SteakosaurusBurger.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the SteakosaurusBurger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;


        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Whole Wheat Bun", "Pickle", "Ketchup", "Mustard" };
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
        /// Method to implement no pickle asked on meal
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            Ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Method to implement no ketchup asked on meal
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            Ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Method to implement no mustard asked on meal
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            Ingredients.Remove("Mustard");
        }
    }
}
