/* VelociWrap.cs
 * Author: Ben Hartman
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the VelociWrap entree.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

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
                if (!cheese) special.Add("Hold Parmesan Cheese");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!dressing) special.Add("Hold Ceasar Dressing");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            Category = "Entree";
        }

        /// <summary>
        /// Method to implement no lettuce asked on meal
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no dressing asked on meal
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to implement no cheese asked on meal
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
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
                List<string> Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Parmesan Cheese", "Romaine Lettuce", "Ceasar Dressing",};
                if(cheese == false) { Ingredients.Remove("Parmesan Cheese"); }
                if (lettuce == false) { Ingredients.Remove("Lettuce"); }
                if (dressing == false) { Ingredients.Remove("Dressing"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
