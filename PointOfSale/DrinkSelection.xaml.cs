using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// private boolean to see if we're implementing a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// Private backing variable to set combo size.
        /// </summary>
        private DinoDiner.Menu.Size comboSize;

        /// <summary>
        /// private backing variable for a combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// private backing variable for the Drink.
        /// </summary>
        private Drink drink;


        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contructor for the Drink Selection
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            if(drink is Drink d)
            {
                if(d is Sodasaurus s)
                {
                    flavor = true;
                }
                else
                {
                    flavor = false;
                }
            }
        }

        /// <summary>
        /// Constructor for the Drink Selection dealing with a combo
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="comboSize"></param>
        public DrinkSelection(CretaceousCombo combo, DinoDiner.Menu.Size comboSize)
        {
            InitializeComponent();
            this.combo = combo;
            this.comboSize = comboSize;
            isCombo = true;
        }

        /// <summary>
        /// private backing variable for the flavor.
        /// </summary>
        private bool flavor = false;

        /// <summary>
        /// Method to select the size for that drink.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (isCombo)
            {
                BtnSmall.IsEnabled = false;
                BtnMedium.IsEnabled = false;
                BtnLarge.IsEnabled = false;
            }
            
            else
            {
                if (drink != null)
                {
                    this.drink.Size = size;
                    comboSize = this.drink.Size;
                }
            }
        }

        /// <summary>
        /// Method that navigates to the FlavorSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChooseSweetDecafFlavor(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (flavor == true)
                {
                    NavigationService.Navigate(new FlavorSelection(combo));
                }
                else if (drink is Tyrannotea t)
                {
                    t.Sweet = true;
                    BtnAddSweetDecafFlavor.Content = "Add Sugar";
                }
                else if (drink is JurassicJava j)
                {
                    j.Decaf = true;
                    BtnAddSweetDecafFlavor.Content = "Decaf";
                }
            }
            else
            {
                if (flavor == true)
                {
                    NavigationService.Navigate(new FlavorSelection());
                }
                else if (drink is Tyrannotea t)
                {
                    t.Sweet = true;
                    BtnAddSweetDecafFlavor.Content = "Add Sugar";
                }
                else if (drink is JurassicJava j)
                {
                    j.Decaf = true;
                    BtnAddSweetDecafFlavor.Content = "Decaf";
                }
            }
            
        }

        /// <summary>
        /// Event handler that enables Sweet/Decaf/Flavor button when Sodasaurus is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSodasaurus(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                flavor = true;
                drink = new Sodasaurus();
                if (isCombo) {
                    combo.Drink = drink;
                    combo.Size = comboSize;
                } 
                else order.Add(drink);
                
                BtnAddSweetDecafFlavor.Content = "Flavor";
                BtnAddLemon.IsEnabled = false;
                BtnAddSweetDecafFlavor.IsEnabled = true;
                BtnHoldIce.Content = "Hold Ice";
            }
        }

        /// <summary>
        /// Event handler that enables Sweet/Decaf/Flavor button when JurassicJava is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJurassicJava(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                drink = new JurassicJava();
                if (isCombo) {
                    combo.Drink = drink;
                    combo.Size = comboSize;
                } 
                else order.Add(drink);
                flavor = false;
                BtnAddSweetDecafFlavor.Content = "Decaf";
                BtnAddLemon.IsEnabled = false;
                BtnAddSweetDecafFlavor.IsEnabled = true;
                BtnHoldIce.Content = "Add Ice";
            }
            
        }

        /// <summary>
        /// Event handler that enables the AddLemon button when Water is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                drink = new Water();
                if (isCombo) {
                    combo.Drink = drink;
                    combo.Size = comboSize;
                } 
                else order.Add(drink);
                flavor = false;
                BtnAddLemon.IsEnabled = true;
                BtnAddSweetDecafFlavor.IsEnabled = false;
                BtnHoldIce.Content = "Hold Ice";
            }
            
        }

        /// <summary>
        /// Event handler that enables all buttons for the Tyrannotea being chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTyrannotea(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                drink = new Tyrannotea();
                if (isCombo) {
                    combo.Drink = drink;
                    combo.Size = comboSize;
                } 
                else order.Add(drink);
                flavor = false;
                BtnAddSweetDecafFlavor.Content = "Add Sugar";
                BtnAddLemon.IsEnabled = true;
                BtnAddSweetDecafFlavor.IsEnabled = true;
            }
            
        }

        /// <summary>
        /// Event handler for the Add Lemon button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLemon(object sender, RoutedEventArgs e)
        {
            if (isCombo)
            {
                if (drink is Tyrannotea t) t.Lemon = true;
                else if (drink is Water w) w.Lemon = true;
            }
            else
            {
                if (drink is Tyrannotea t) t.Lemon = true;
                else if (drink is Water w) w.Lemon = true;
            }
        }

        /// <summary>
        /// Event handler for the Hold Ice button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldIce(object sender, RoutedEventArgs e)
        {
            if (isCombo)
            {
                if (drink is Drink) drink.HoldIce();
                if (drink is JurassicJava j) j.Ice = true;
            }
            else
            {
                if (drink is Drink) drink.HoldIce();
                if (drink is JurassicJava j) j.Ice = true;
            }
        }

        /// <summary>
        /// Event handler for the Done button to navigate back to main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the Large button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Event handler for the Medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Event handler for the Small button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
