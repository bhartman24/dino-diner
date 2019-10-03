/* MeteorMacAndCheese.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the MeteorMacAndCheese side.
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        /// <summary>
        /// backing variable for the Size property.
        /// </summary>
        protected Size size;

        /// <summary>
        /// Property to get and set the sizes for the sides.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
        }

        public override string ToString()
        {
            return "MeteorMacAndCheese";
        }
    }
}
