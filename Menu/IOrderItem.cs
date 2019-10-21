using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the Order item.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// Gets the Special string array.
        /// </summary>
        string[] Special { get; }
    }
}
