/* PrehistoricPBJ.cs
 * Author: Ben Hartman
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the PrehistoricPBJ entree.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }

        /// <summary>
        /// Method to implement no peanut butter asked on meal
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            Ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Method to implement no jelly asked on meal
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            Ingredients.Remove("Jelly");
        }

        public override string ToString()
        {
            return "PrehistoricPBJ";
        }
    }
}
