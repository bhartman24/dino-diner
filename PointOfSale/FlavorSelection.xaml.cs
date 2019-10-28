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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Cherry button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddCherry(object sender, RoutedEventArgs args)
        {
            if(sender is Button button && DataContext is Order order)
            {
                if(order.Items[order.Items.Length-1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Cherry;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the Lime button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddLime(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Lime;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the Vanilla button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddVanilla(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Vanilla;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the Chocolate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddChocolate(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Chocolate;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the Orange button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddOrange(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Orange;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the Cola button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddCola(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Cola;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for the RootBeer button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddRootBeer(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.RootBeer;
                }
            }
            NavigationService.GoBack();
        }
    }
}
