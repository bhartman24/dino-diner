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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// private backing variable for the combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// private backing variable to initialize the size
        /// </summary>
        private DinoDiner.Menu.Size comboSize = DinoDiner.Menu.Size.Small;

        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Method that navigates to the SideSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SideClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Method that navigates to the DrinkSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void DrinkClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo, comboSize));
        }

        /// <summary>
        /// Event handler for the Size small button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSizeSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Event handler for the size medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSizeMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Event handler for the size large button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSizeLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
