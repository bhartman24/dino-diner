/* JurassicJava.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents JurassicJava, inherits from Drink class.
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem
    {

        /// <summary>
        /// Gets and sets the description.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special preparation instructions.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (SpaceForCream) special.Add("Leave Space for Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Class constructor to set the price, calories, and ingredients.
        /// </summary>
        public JurassicJava()
        {
            this.Size = Size.Small;
            Ice = false;
            Price = 0.59;
            this.Calories = 2;
        }

        /// <summary>
        /// Property for the Room for the cream.
        /// </summary>
        public bool SpaceForCream { get; set; } = false;

        /// <summary>
        /// backing variable for the decaf.
        /// </summary>
        private bool decaf;

        /// <summary>
        /// Gets and sets if customer wants coffee decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Method to leave room for cream in their coffee.
        /// </summary>
        public void LeaveRoomForCream()
        {
            SpaceForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method to set the Ice property to true;
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
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
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Property to return a list of the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Decaf)
            {
                return size + " Decaf Jurassic Java";
            }
            else return size + " Jurassic Java";
        }
    }
}
