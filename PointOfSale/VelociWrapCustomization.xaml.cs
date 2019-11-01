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
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {
        /// <summary>
        /// backing variable to create a new vw object.
        /// </summary>
        private VelociWrap vw;

        public VelociWrapCustomization(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// Event handler for holding the lettuce.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        /// <summary>
        /// Event handler for holding the dressing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        /// <summary>
        /// Event handler for holding the cheese.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
