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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that navigates to the FlavorSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Event handler that enables Sweet/Decaf/Flavor button when Sodasaurus is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSodasaurus_Click(object sender, RoutedEventArgs e)
        {
            uxAddLemon.IsEnabled = false;
            uxSweetDecafFlavor.IsEnabled = true;
        }

        /// <summary>
        /// Event handler that enables Sweet/Decaf/Flavor button when JurassicJava is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxJurassicJava_Click(object sender, RoutedEventArgs e)
        {
            uxAddLemon.IsEnabled = false;
            uxSweetDecafFlavor.IsEnabled = true;
        }

        /// <summary>
        /// Event handler that enables the AddLemon button when Water is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWater_Click(object sender, RoutedEventArgs e)
        {
            uxAddLemon.IsEnabled = true;
            uxSweetDecafFlavor.IsEnabled = false;
        }

        /// <summary>
        /// Event handler that enables all buttons for the Tyrannotea being chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxTyrannotea_Click(object sender, RoutedEventArgs e)
        {
            uxAddLemon.IsEnabled = true;
            uxSweetDecafFlavor.IsEnabled = true;
        }
    }
}
