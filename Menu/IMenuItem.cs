/* IMenuItem.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the Menu.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get;  }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get;  }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients { get; }

        /// <summary>
        /// Property to get the category of your item.
        /// </summary>
        string Category { get; set; }
    }
}
