/* Menu.cs
 * Author: Ben Hartman
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that lists all available menu items and subclasses.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// backing variables for the entree, combo, side, and drink
        /// </summary>
        public List<Entree> availableEntrees;
        public List<Side> availableSides;
        public List<Drink> availableDrinks;
        public List<CretaceousCombo> availableCombos;

        /// <summary>
        /// Property to return all of the available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableCombos);
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
                if(availableEntrees == null)
                {
                    availableEntrees = new List<Entree>();
                    availableEntrees.Add(new Brontowurst());
                    availableEntrees.Add(new DinoNuggets());
                    availableEntrees.Add(new PrehistoricPBJ());
                    availableEntrees.Add(new PterodactylWings());
                    availableEntrees.Add(new SteakosaurusBurger());
                    availableEntrees.Add(new TRexKingBurger());
                    availableEntrees.Add(new VelociWrap());
                }
                
                return availableEntrees;
            }
            set
            {
                this.availableEntrees = value;
            }
        }

        /// <summary>
        /// Property to return the available sides.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                if(availableSides == null)
                {
                    availableSides = new List<Side>();
                    availableSides.Add(new Fryceritops());
                    availableSides.Add(new MeteorMacAndCheese());
                    availableSides.Add(new MezzorellaSticks());
                    availableSides.Add(new Triceritots());
                }
                
                return availableSides;
            }
            set
            {
                this.availableSides = value;
            }
        }

        /// <summary>
        /// Property to return the available drinks.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                if(availableDrinks == null)
                {
                    availableDrinks = new List<Drink>();
                    availableDrinks.Add(new JurassicJava());
                    availableDrinks.Add(new Sodasaurus());
                    availableDrinks.Add(new Water());
                    availableDrinks.Add(new Tyrannotea());
                }
                
                return availableDrinks;
            }
            set
            {
                this.availableDrinks = value;
            }
        }

        /// <summary>
        /// Property to return the available combos.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                if(availableCombos == null)
                {
                    availableCombos = new List<CretaceousCombo>();
                    availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                    availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                    availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                    availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                    availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                }
                
                return availableCombos;
            }
            set
            {
                this.availableCombos = value;
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

        /// <summary>
        /// Method to return all AvailableMenuItems
        /// </summary>
        public List<IMenuItem> All { get{ return AvailableMenuItems;  } }

        /// <summary>
        /// Method to return the results after searching for a word
        /// </summary>
        /// <param name="items"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> items, string searchString)
        {

            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if(item is Entree e)
                {
                    if (item.ToString().Contains(searchString))
                    {
                        results.Add(e);
                    }
                }
                if (item is CretaceousCombo c)
                {
                    if (item.ToString().Contains(searchString))
                    {
                        results.Add(c);
                    }
                }
                if (item is Drink d)
                {
                    if (item.ToString().Contains(searchString))
                    {
                        results.Add(d);
                    }
                }
                if (item is Side s)
                {
                    if (item.ToString().Contains(searchString))
                    {
                        results.Add(s);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Method to return a list after filtering by a specific category.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="menuCategory"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByCategory(List<IMenuItem> items, List<string> menuCategory)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (menuCategory.Contains("Combo"))
                {
                    if(item is CretaceousCombo c)
                    {
                        results.Add(c);
                    }
                }
                if (menuCategory.Contains("Entree"))
                {
                    if (item is Entree e)
                    {
                        results.Add(e);
                    }
                }
                 if (menuCategory.Contains("Drink"))
                {
                    if (item is Drink d)
                    {
                        results.Add(d);
                    }
                }
                 if (menuCategory.Contains("Side"))
                {
                    if (item is Side s)
                    {
                        results.Add(s);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Method to return a list after filtering by a specific minimum price.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="minimumPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float minimumPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (minimumPrice <= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        ///  Method to return a list after filtering by a specific paximum price.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="maximumPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float maximumPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (maximumPrice >= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Property to return the available ingredients.
        /// </summary>
        public List<string> AvailableIngredients
        {
            get
            {
                List<string> results = new List<string>();
                //Menu m = new Menu();
                foreach (IMenuItem item in All)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        if (!results.Contains(ingredient))
                        {
                            results.Add(ingredient);
                        }
                        
                    }
                }
                return results;
            }
        }

        /// <summary>
        /// Method to return a list after applying a filter to certain ingredients.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                bool flag = true;
                foreach(string s in ingredients)
                {
                    if (item.Ingredients.Contains(s))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) results.Add(item);
            }
            return results;
        }
    }
}
