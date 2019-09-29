/* Sodasaurus.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Sodasaurus class, inherits from the Drink class.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public Sodasaurus()
        {
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            Price = 1.50;
            this.Calories = 112;
            Ice = true;
        }

        /// <summary>
        /// Property for the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

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
            }
        }
    }
}
