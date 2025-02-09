﻿using System;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Property for the NavigationService.
        /// </summary>
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// Contructor for the OrderControl class.
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the OnSelectionChanged event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if(OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
                OrderItems.SelectedItem = drink;
            }
            else if(OrderItems.SelectedItem is CretaceousCombo combo)
            {
                if (combo.Entree is Brontowurst) NavigationService.Navigate(new BrontowurstCustomization(combo));
                else if (combo.Entree is DinoNuggets) NavigationService.Navigate(new DinoNuggetsCustomization(combo));
                else if (combo.Entree is PrehistoricPBJ) NavigationService.Navigate(new PrehistoricPBJCustomization(combo));
                else if (combo.Entree is PterodactylWings) NavigationService.Navigate(new PterodactylWingsCustomization(combo));
                else if (combo.Entree is SteakosaurusBurger) NavigationService.Navigate(new SteakosaurusBurgerCustomization(combo));
                else if (combo.Entree is TRexKingBurger) NavigationService.Navigate(new TRexKingBurgerCustomization(combo));
                else if (combo.Entree is VelociWrap) NavigationService.Navigate(new VelociWrapCustomization(combo));
                NavigationService?.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Event handler for the OnRemoveItem event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
                }
                
            }
        }
    }
}
