using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Cretaceous combo.
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Gets and sets the entree.
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Back Variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets or sets the size of the combo.
        /// </summary>
        public Size Size {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree.
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }


        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        /// <summary>
        /// Gets the Description.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special preparation instructions.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add(Entree.Special.ToString());
                ingredients.Add(Side.Description);
                ingredients.Add(Side.Special.ToString());
                ingredients.Add(Drink.Description);
                ingredients.Add(Drink.Special.ToString());
                return ingredients.ToArray();
            }
        }
    }
}
