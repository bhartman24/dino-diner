using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<Drink> drink = new List<Drink>();
                drink.AddRange(drink);
                List<Entree> entree = new List<Entree>();
                entree.AddRange(entree);
                List<Side> side = new List<Side>();
                side.AddRange(side);
                
            }
        }

        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entree = new List<Entree>();
                entree.AddRange(entree);
                return entree;
            }
        }

        public List<Side> AvailableSides
        {
            get
            {
                List<Side> side = new List<Side>();
                side.AddRange(side);
                return side;
            }
        }

        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drink = new List<Drink>();
                drink.AddRange(drink);
                return drink;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
