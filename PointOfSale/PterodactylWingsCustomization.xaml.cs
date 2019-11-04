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
    /// Interaction logic for PterodactylWingsCustomization.xaml
    /// </summary>
    public partial class PterodactylWingsCustomization : Page
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
        /// backing variable to create a new wings object.
        /// </summary>
        private PterodactylWings wings;

        /// <summary>
        ///  Constructor for the PterodactylWings customization page.
        /// </summary>
        /// <param name="wings"></param>
        public PterodactylWingsCustomization(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
            isCombo = false;
        }

        /// <summary>
        /// Constructor to implement if the entree is in a combo.
        /// </summary>
        /// <param name="combo"></param>
        public PterodactylWingsCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
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
