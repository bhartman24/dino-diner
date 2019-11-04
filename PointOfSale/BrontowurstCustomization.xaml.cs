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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        /// <summary>
        /// private backing variable for the combo choice.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// backing variable to create a new bw object.
        /// </summary>
        private Brontowurst bw;

        /// <summary>
        /// private backing variable to see if this entree is being implemented as a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// Constructor for the Brontowurst customization page.
        /// </summary>
        /// <param name="bw"></param>
        public BrontowurstCustomization(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
            isCombo = false;
        }

        /// <summary>
        /// Constructor to implement if the entree is in a combo.
        /// </summary>
        /// <param name="combo"></param>
        public BrontowurstCustomization(CretaceousCombo combo)
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
            if (isCombo) {
                if (combo.Entree is Brontowurst bw) bw.HoldBun();
            }
            else this.bw.HoldBun();
        }

        /// <summary>
        /// Event handler for holding the onion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (isCombo) {
                if (combo.Entree is Brontowurst bw) bw.HoldOnion();
            }
            else this.bw.HoldOnion();
        }

        /// <summary>
        /// Event handler for holding the peppers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            if (isCombo) {
                if (combo.Entree is Brontowurst bw) bw.HoldPeppers();
            }
            else this.bw.HoldPeppers();
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
