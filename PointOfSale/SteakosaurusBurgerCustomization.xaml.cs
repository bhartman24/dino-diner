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
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        /// <summary>
        /// private backing variable for the combo choice.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// private backing variable to see if this entree is being implemented as a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// backing variable to create a new sb object.
        /// </summary>
        private SteakosaurusBurger sb;

        /// <summary>
        ///  Constructor for the SteakosaurusBurger customization page.
        /// </summary>
        /// <param name="sb"></param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
            isCombo = false;
        }

        /// <summary>
        /// Constructor to implement if the entree is in a combo.
        /// </summary>
        /// <param name="combo"></param>
        public SteakosaurusBurgerCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Event handler for holding the bun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldBun();
            }
            
            else this.sb.HoldBun();
        }

        /// <summary>
        /// Event handler for holding the pickle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldPickle();
            }
            
            else this.sb.HoldPickle();
        }

        /// <summary>
        /// Event handler for holding the ketchup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldKetchup();
            }
            
            else this.sb.HoldKetchup();
        }

        /// <summary>
        /// Event handler for holding the mustard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldMustard();
            }
            
            else this.sb.HoldMustard();
        }

        /// <summary>
        /// Event handler for the Done button to go back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
