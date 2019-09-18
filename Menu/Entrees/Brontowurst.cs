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
    public class Brontowurst
    {
            /// <summary>
            /// backing variables for the properties.
            /// </summary>
            private bool bun = true;
            private bool onions = true;
            private bool peppers = true;
            
            /// <summary>
            /// Property for price
            /// </summary>
            public double Price { get; set; }

            /// <summary>
            /// Property for calories
            /// </summary>
            public uint Calories { get; set; }

            /// <summary>
            /// Property for ingredients
            /// </summary>
            public List<string> Ingredients
            {
                get
                {
                    List<string> ingredients = new List<string>() { "Brautwurst" };
                    if (bun) ingredients.Add("Whole Wheat Bun");
                    if (onions) ingredients.Add("Onion");
                    if (peppers) ingredients.Add("Peppers");
                    return ingredients;
                }
            }
            
            /// <summary>
            /// Class constructor to set the price and calories.
            /// </summary>
            public Brontowurst()
            {
                this.Price = 5.36;
                this.Calories = 498;
            }
            
            /// <summary>
            /// Method to implement no bun asked on meal
            /// </summary>
            public void HoldBun()
            {
                this.bun = false;
            }

            /// <summary>
            /// Method to implement no onion asked on meal
            /// </summary>
            public void HoldOnion()
            {
                this.onions = false;
            }

            /// <summary>
            /// Method to implement no pepper asked on meal
            /// </summary>
            public void HoldPeppers()
            {
                this.peppers = false;
            }
    }
}
