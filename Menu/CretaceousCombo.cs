using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Cretaceous combo.
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price,
        /// Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of property changes.
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Private backing variable for the entree.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Gets and sets the entree.
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange(args.PropertyName);
                };
            }
        }

        /// <summary>
        /// private backing variable for the drink.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set {
                drink = value;
                NotifyOfPropertyChange("Special");
                drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange(args.PropertyName);
                };
            }
        }

        /// <summary>
        /// private backing variable for the Side.
        /// </summary>
        private Side side;

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
        }

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
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
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
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
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
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.Description);
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.Description);
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
