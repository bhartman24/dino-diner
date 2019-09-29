/* Drink.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Abstract class to represent any drink.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets and sets whether customer wants ice.
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Method that sets the Ice property to false;
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Gets or sets the size. Taken from the Size Class.
        /// </summary>
        public abstract Size Size { get; set; }
    }
}
