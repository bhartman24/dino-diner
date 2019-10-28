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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Private backing variable for the entree.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Brontowurst button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the Dino Nuggets button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the PrehistoricPBJ button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the PterodactylWings button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the SteakosaurusBurger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddSteakosaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the TRexKingBurger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddTrexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the VelociWrap button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
