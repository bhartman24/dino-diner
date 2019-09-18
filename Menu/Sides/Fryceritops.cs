﻿/* Fryceritops.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class to represent the Fryceritops side.
    /// </summary>
    public class Fryceritops : Side
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
                switch(size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
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
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
