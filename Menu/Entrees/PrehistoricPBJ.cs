/* PrehistoricPBJ.cs
 * Author: Ben Hartman
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the PrehistoricPBJ entree.
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor to set the price and calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Method to implement no peanut butter asked on meal
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Method to implement no jelly asked on meal
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
