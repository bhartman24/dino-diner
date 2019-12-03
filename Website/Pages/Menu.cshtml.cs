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

        public Menu Menu = new Menu();

        public List<IMenuItem> items { get; set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();


        public void OnGet()
        {
            items = Menu.All;
        }

        public void OnPost()
        {
            items = Menu.All;
            if (search != null)
            {
                items = Menu.Search(items, search);
            }
            if (menuCategory.Count != 0)
            {
                items = Menu.FilterByCategory(items, menuCategory);
            }
            if (minimumPrice != null)
            {
                items = Menu.FilterByMinPrice(items, (float)minimumPrice);
            }
            if (maximumPrice != null)
            {
                items = Menu.FilterByMaxPrice(items, (float)maximumPrice);
            }
            if(ingredients.Count != 0)
            {
                items = Menu.FilterByIngredients(items, ingredients);
            }
        }
    }
}