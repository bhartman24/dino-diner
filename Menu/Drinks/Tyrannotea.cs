/* Tyrannotea.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea class, inherits from the Drink class.
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            this.Calories = 8;
            Sweet = false;
            Ice = true;
            Lemon = false;
        }


        /// <summary>
        /// Property for the Sweetener.
        /// </summary>
        public bool Sweet { get; set; }

        /// <summary>
        /// Property for the Lemon.
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Method to set the Lemon to true.
        /// </summary>
        public void AddLemon()
        {
            Ingredients.Add("Lemon");
            Lemon = true;
        }

        /// <summary>
        /// Method to set the Sweet property to true.
        /// </summary>
        public void AddSweetener()
        {
            Sweet = true;
            Ingredients.Add("Cane Sugar");
            this.Calories = 2 * Calories;
        }

        /// <summary>
        /// Backing variable for the Size
        /// </summary>
        protected Size size;

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
                        Price = 1.99;
                        this.Calories = 32;
                        if (Sweet == true)
                        {
                            this.Calories = 64;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        this.Calories = 16;
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
                List<string> Ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) { Ingredients.Add("Lemon"); }
                if (Sweet) { Ingredients.Add("Cane Sugar"); }
                return Ingredients;
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Sweet== true)
            {
                return size + " Sweet Tyrannotea";
            }
            else return size + " Tyrannotea";
        }
    }
}
