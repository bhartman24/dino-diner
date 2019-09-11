using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
            private bool bun = true;
            private bool onions = true;
            private bool peppers = true;

            public double Price { get; set; }
            public uint Calories { get; set; }

            public List<string> Ingredients
            {
                get
                {
                    List<string> ingredients = new List<string>() { "brautwurst" };
                    if (bun) ingredients.Add("whole-wheat bun");
                    if (onions) ingredients.Add("Onions");
                    if (peppers) ingredients.Add("Peppers");
                    return ingredients;
                }
            }

            public Brontowurst()
            {
                this.Price = 5.36;
                this.Calories = 498;
            }

            public void HoldBun()
            {
                this.bun = false;
            }

            public void HoldOnion()
            {
                this.onions = false;
            }

            public void HoldPeppers()
            {
                this.peppers = false;
            }
    }
}
