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
    public static class Menu
    {
        /// <summary>
        /// backing variables for the entree, combo, side, and drink
        /// </summary>
        public static List<IMenuItem> availableEntrees;
        public static List<IMenuItem> availableSides;
        public static List<IMenuItem> availableDrinks;
        public static List<IMenuItem> availableCombos;

        /// <summary>
        /// Property to return all of the available menu items.
        /// </summary>
        public static List<IMenuItem> AvailableMenuItems
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
        public static List<IMenuItem> AvailableEntrees
        {
            get
            {
                if(availableEntrees == null)
                {
                    availableEntrees = new List<IMenuItem>();
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
        }

        /// <summary>
        /// Property to return the available sides.
        /// </summary>
        public static List<IMenuItem> AvailableSides
        {
            get
            {
                if(availableSides == null)
                {
                    availableSides = new List<IMenuItem>();
                    availableSides.Add(new Fryceritops());
                    availableSides.Add(new MeteorMacAndCheese());
                    availableSides.Add(new MezzorellaSticks());
                    availableSides.Add(new Triceritots());
                }
                
                return availableSides;
            }
        }

        /// <summary>
        /// Property to return the available drinks.
        /// </summary>
        public static List<IMenuItem> AvailableDrinks
        {
            get
            {
                if(availableDrinks == null)
                {
                    availableDrinks = new List<IMenuItem>();
                    availableDrinks.Add(new JurassicJava());
                    availableDrinks.Add(new Sodasaurus());
                    availableDrinks.Add(new Water());
                    availableDrinks.Add(new Tyrannotea());
                }
                
                return availableDrinks;
            }
        }

        /// <summary>
        /// Property to return the available combos.
        /// </summary>
        public static List<IMenuItem> AvailableCombos
        {
            get
            {
                if(availableCombos == null)
                {
                    availableCombos = new List<IMenuItem>();
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
        }

        /// <summary>
        /// Method to return all AvailableMenuItems
        /// </summary>
        public static List<IMenuItem> All { get{ return AvailableMenuItems;  } }

        /// <summary>
        /// Method to return the results after searching for a word
        /// </summary>
        /// <param name="items"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> items, string searchString)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.ToString().Contains(searchString)) {
                    results.Add(item);
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
        public static List<IMenuItem> FilterByCategory(List<IMenuItem> items, List<string> menuCategory)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (menuCategory.Contains(item.Category))
                {
                    results.Add(item);
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
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float minimumPrice)
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
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float maximumPrice)
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
        public static List<string> AvailableIngredients
        {
            get
            {
                List<string> results = new List<string>();
                foreach (IMenuItem item in AvailableMenuItems)
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
        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            results.AddRange(items);
            foreach (IMenuItem item in items)
            {
                foreach(string s in ingredients)
                {
                    if (ingredients.Contains(s))
                    {
                        //flag = false;
                        results.Remove(item);
                    }
                }
            }
            return results;
        }
    }
}
