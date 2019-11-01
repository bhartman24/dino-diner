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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        /// <summary>
        /// backing variable to create a new pbj object.
        /// </summary>
        private DinoNuggets dn;

        public DinoNuggetsCustomization(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        /// <summary>
        /// Event handler for adding a nugget.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
        }

        /// <summary>
        /// Event handler for the Done button to go back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
