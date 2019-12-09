/* Entree.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class to represent any Entree. 
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Gets the description.
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special preparation instructions.
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(new Brontowurst().Special.ToString());
                special.Add(new DinoNuggets().Special.ToString());
                special.Add(new PrehistoricPBJ().Special.ToString());
                special.Add(new PterodactylWings().Special.ToString());
                special.Add(new SteakosaurusBurger().Special.ToString());
                special.Add(new TRexKingBurger().Special.ToString());
                special.Add(new VelociWrap().Special.ToString());
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Property to get the category of your item.
        /// </summary>
        public string Category { get; set; }
    }
}
