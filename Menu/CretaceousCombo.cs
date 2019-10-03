using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
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
                Drink.Size = size;
                Side.Size = size;
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
    }
}
