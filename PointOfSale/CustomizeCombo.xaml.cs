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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that navigates to the SideSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SideClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Method that navigates to the DrinkSelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void DrinkClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        private void OnSizeClicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {  
                
            }
        }
    }
}
