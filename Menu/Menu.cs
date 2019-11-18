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
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableDrinks);
                items.AddRange(AvailableSides);
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
                entree.Add(new Brontowurst());
                entree.Add(new DinoNuggets());
                entree.Add(new PrehistoricPBJ());
                entree.Add(new PterodactylWings());
                entree.Add(new SteakosaurusBurger());
                entree.Add(new TRexKingBurger());
                entree.Add(new VelociWrap());
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
                side.Add(new Fryceritops());
                side.Add(new MeteorMacAndCheese());
                side.Add(new MezzorellaSticks());
                side.Add(new Triceritots());
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
                drink.Add(new JurassicJava());
                drink.Add(new Sodasaurus());
                drink.Add(new Water());
                drink.Add(new Tyrannotea());
                return drink;
            }
        }

        /// <summary>
        /// Property to return the available combos.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
                availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                return availableCombos;
            }
        }


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
