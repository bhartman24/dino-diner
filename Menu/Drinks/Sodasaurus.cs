/* Sodasaurus.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public Sodasaurus()
        {
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
        }

        /// <summary>
        /// backing variable.
        /// </summary>
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// Property for the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                }
                if(size == Size.Medium)
                {
                    Price = 2.00;
                }
            }
        }

        public double Price = 1.50;
    }
}
