/* Water.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water class, inherits from the Drink class.
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients. 
        /// </summary>
        public Water()
        {
            Price = .10;
            this.Calories = 0;
            Lemon = false;
            Ice = true;
        }

        /// <summary>
        /// Property for the Lemon.
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Method to set the Lemon property to true.
        /// </summary>
        public void AddLemon()
        {
            Ingredients.Add("Lemon");
            Lemon = true;
        }

        /// <summary>
        /// Backing variable for the Size
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
                        Price = .10;
                        this.Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .10;
                        this.Calories = 0;
                        break;
                    case Size.Small:
                        Price = .1;
                        this.Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Water"};
                if (Lemon) { Ingredients.Add("Lemon"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Water";
        }
    }
}
