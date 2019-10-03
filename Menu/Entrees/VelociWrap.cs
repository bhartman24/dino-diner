/* VelociWrap.cs
 * Author: Ben Hartman
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the VelociWrap entree.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;


        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
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
        /// Method to implement no dressing asked on meal
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            Ingredients.Remove("Dressing");
        }

        /// <summary>
        /// Method to implement no cheese asked on meal
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            Ingredients.Remove("Parmesan Cheese");
        }

        public override string ToString()
        {
            return "VelociWrap";
        }
    }
}
