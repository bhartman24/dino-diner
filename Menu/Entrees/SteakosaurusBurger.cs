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
    public class SteakosaurusBurger
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");

                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Method to implement no bun asked on meal
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to implement no pickle asked on meal
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to implement no ketchup asked on meal
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to implement no mustard asked on meal
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
