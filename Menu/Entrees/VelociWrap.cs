/* VelociWrap.cs
 * Author: Ben Hartman
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the VelociWrap entree.
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

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
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Method to implement no lettuce asked on meal
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to implement no dressing asked on meal
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to implement no cheese asked on meal
        /// </summary>
        public void holdCheese()
        {
            this.cheese = false;
        }
    }
}
