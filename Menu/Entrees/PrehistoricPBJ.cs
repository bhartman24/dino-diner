/* PrehistoricPBJ.cs
 * Author: Ben Hartman
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the PrehistoricPBJ entree.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Gets and sets the description.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special preparation instructions.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no jelly asked on meal
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
                if (jelly == false) { Ingredients.Remove("Jelly"); }
                if(peanutButter == false) { Ingredients.Remove("Peanut Butter"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
