/* Brontowurst.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree
    {
            /// <summary>
            /// backing variables for the properties.
            /// </summary>
            private bool bun = true;
            private bool onions = true;
            private bool peppers = true;
            
            
            /// <summary>
            /// Class constructor to set the price and calories.
            /// </summary>
            public Brontowurst()
            {
                this.Price = 5.36;
                this.Calories = 498;
                this.Ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Onion", "Peppers" };
        }

            /// <summary>
            /// Method to implement no bun asked on meal
            /// </summary>
            public void HoldBun()
            {
                this.bun = false;
                Ingredients.Remove("Whole Wheat Bun");
            }

            /// <summary>
            /// Method to implement no onion asked on meal
            /// </summary>
            public void HoldOnion()
            {
                this.onions = false;
                Ingredients.Remove("Onion");
            }

            /// <summary>
            /// Method to implement no pepper asked on meal
            /// </summary>
            public void HoldPeppers()
            {
                this.peppers = false;
                Ingredients.Remove("Peppers");
            }
    }
}
