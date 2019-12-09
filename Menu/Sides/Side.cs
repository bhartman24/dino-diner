/* Side.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class for the side 
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Gets and sets the description.
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
                special.Add(new Fryceritops().Special.ToString());
                special.Add(new MeteorMacAndCheese().Special.ToString());
                special.Add(new MezzorellaSticks().Special.ToString());
                special.Add(new Triceritots().Special.ToString());
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
        public virtual List<string> Ingredients { get;}

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

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
