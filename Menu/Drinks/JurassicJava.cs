/* JurassicJava.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents JurassicJava, inherits from Drink class.
    /// </summary>
    public class JurassicJava : Drink, IMenuItem
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public JurassicJava()
        {
            this.Ingredients = new List<string>() { "Water", "Coffee" };
            Ice = false;
            Price = 0.59;
            this.Calories = 2;
            SpaceForCream = false;
            Decaf = false;
        }

        /// <summary>
        /// Property for the Room for the cream.
        /// </summary>
        public bool SpaceForCream { get; set; }

        /// <summary>
        /// Gets and sets if customer wants coffee decaf.
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Method to leave room for cream in their coffee.
        /// </summary>
        public void LeaveRoomForCream()
        {
            SpaceForCream = true;
        }

        /// <summary>
        /// Method to set the Ice property to true;
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// Backing variable for the Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Property to get and set the sizes for the sides.
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        Price = .99;
                        this.Calories = 4;
                        break;
                    case Size.Small:
                        Price = .59;
                        this.Calories = 2;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return "JurassicJava";
        }
    }
}
