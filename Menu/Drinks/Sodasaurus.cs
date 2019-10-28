/* Sodasaurus.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus class, inherits from the Drink class.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets a description of this order item.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special instructions for this order item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            this.Calories = 112;
            Ice = true;
        }

        /// <summary>
        /// backing variable for the flavor.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Property for the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Backing variable for the Size property.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Property to get or set the size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch(size)
                {
                    case Size.Large:
                        Price = 2.50;
                        this.Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        this.Calories = 112;
                        break;
                }
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }


        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
