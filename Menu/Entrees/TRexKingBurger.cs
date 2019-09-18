﻿/* TRexKingBurger.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the TRexKingBurger entree.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;


        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie", "Whole Wheat Bun", "Lettuce", "Tomato", "Onion", "Pickle", "Ketchup", "Mustard", "Mayo" };
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
        /// Method to implement no lettuce asked on meal
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            Ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Method to implement no tomato asked on meal
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            Ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Method to implement no onion asked on meal
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            Ingredients.Remove("Onion");
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

        /// <summary>
        /// Method to implement no mayo asked on meal
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            Ingredients.Remove("Mayo");
        }
    }
}
