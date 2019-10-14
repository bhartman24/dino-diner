/* Menu.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that lists all available menu items and subclasses.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Property to return all of the available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }

        /// <summary>
        /// Property to return the available entrees.
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entree = new List<Entree>();
                return entree;
            }
        }

        /// <summary>
        /// Property to return the available sides.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> side = new List<Side>();
                return side;
            }
        }

        /// <summary>
        /// Property to return the available drinks.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drink = new List<Drink>();
                return drink;
            }
        }

        /// <summary>
        /// Property to return the available combos.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos { get; }


        /// <summary>
        /// Method to override ToString() to return name of item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<IMenuItem> menu = new List<IMenuItem>();
            List<string> menuList = new List<string>();
            foreach(IMenuItem item in menu)
            {
                menuList.Add(item.ToString());
                menuList.Add("\n");
            }
            return menuList.ToString();
        }
    }
}
