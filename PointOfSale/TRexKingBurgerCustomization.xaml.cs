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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
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
        /// backing variable to create a new trex object.
        /// </summary>
        private TRexKingBurger trex;

        /// <summary>
        ///  Constructor for the TRexKingBurger customization page.
        /// </summary>
        /// <param name="trex"></param>
        public TRexKingBurgerCustomization(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
            isCombo = false;
        }

        /// <summary>
        /// Constructor to implement if the entree is in a combo.
        /// </summary>
        /// <param name="combo"></param>
        public TRexKingBurgerCustomization(CretaceousCombo combo)
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
                if (combo.Entree is TRexKingBurger trex) trex.HoldBun();
            }
            
            else this.trex.HoldBun();
        }

        /// <summary>
        /// Event handler for holding the lettuce.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is TRexKingBurger trex) trex.HoldLettuce();
            }
            
            else this.trex.HoldLettuce();
        }

        /// <summary>
        /// Event handler for holding the tomato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is TRexKingBurger trex) trex.HoldTomato();
            }
            
            else this.trex.HoldTomato();
        }

        /// <summary>
        /// Event handler for holding the onion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is TRexKingBurger trex) trex.HoldOnion();
            }
            
            else this.trex.HoldOnion();
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
                if (combo.Entree is TRexKingBurger trex) trex.HoldPickle();
            }
            
            else this.trex.HoldPickle();
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
                if (combo.Entree is TRexKingBurger trex) trex.HoldKetchup();
            }
            
            else this.trex.HoldKetchup();
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
                if (combo.Entree is TRexKingBurger trex) trex.HoldMustard();
            }
            
            else this.trex.HoldMustard();
        }

        /// <summary>
        /// Event handler for holding the mayo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is TRexKingBurger trex) trex.HoldMayo();
            }
            
            else this.trex.HoldMayo();
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
