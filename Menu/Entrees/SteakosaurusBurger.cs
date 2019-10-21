/* SteakosaurusBurger.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the SteakosaurusBurger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!pickle) special.Add("Hold Pickle");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no pickle asked on meal
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no ketchup asked on meal
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no mustard asked on meal
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
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
                List<string> Ingredients = new List<string>() { "Steakburger Pattie", "Whole Wheat Bun", "Ketchup", "Mustard", "Pickle" };
                if (bun == false) { Ingredients.Remove("Whole Wheat Bun"); }
                if (ketchup == false) { Ingredients.Remove("Ketchup"); }
                if(mustard == false) { Ingredients.Remove("Mustard"); }
                if(pickle == false) { Ingredients.Remove("Pickle"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
