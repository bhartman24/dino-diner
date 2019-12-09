/* DinoNuggets.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing variables for the properties.
        /// </summary>
        private bool additionalNugget = false;
        private int nuggetCount = 6;

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
                if (additionalNugget)
                {
                    special.Add($"{nuggetCount-6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint)(59*nuggetCount);
            Category = "Entree";
        }

        /// <summary>
        /// Method to add a nugget which adds the nugget count, 
        /// price, and calories with it.
        /// </summary>
        public void AddNugget()
        {
            this.additionalNugget = true;
            nuggetCount++;
            Price = 4.25 + ((nuggetCount - 6) * 0.25);
            Calories = (uint)(59 * nuggetCount);
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Price");
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                
                if(additionalNugget == true) {
                    for (int i = 0; i < nuggetCount-6; i++)
                    {
                        Ingredients.Add("Chicken Nugget");
                    }
                }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
