using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// items to display on web page
        /// </summary>
        public IEnumerable<IMenuItem> items;

        /// <summary>
        /// string in search bar
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// list of categories that are checked
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// minimum filter price
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// maximum filter price
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// all of the possible ingredients
        /// </summary>
        public IEnumerable<string> ingredients;

        /// <summary>
        /// ingredients that are excluded
        /// </summary>
        [BindProperty]
        public List<string> excludeIngredients { get; set; } = new List<string>();

        /// <summary>
        /// when web page is open
        /// </summary>
        public void OnGet()
        {
            items = Menu.AvailableMenuItems.OrderBy(item => item.Category);
            ingredients = Menu.AvailableIngredients.OrderBy(ingredient => ingredient.ToString());
        }

        /// <summary>
        /// when page is filtered
        /// </summary>
        public void OnPost()
        {
            items = Menu.AvailableMenuItems;
            ingredients = Menu.AvailableIngredients;
            if (search != null)
            {
                items = items.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (menuCategory.Count > 0)
            {
                items = items.Where(item => menuCategory.Contains(item.Category));
            }
            if (minimumPrice != null)
            {
                items = items.Where(item => item.Price >= minimumPrice);
            }
            if (maximumPrice != null)
            {
                items = items.Where(item => item.Price <= maximumPrice);
            }
            if(excludeIngredients.Count > 0)
            {
                foreach(string ingr in excludeIngredients)
                {
                    items = items.Where(item => !item.Ingredients.Contains(ingr));
                }
            }
        }
    }
}