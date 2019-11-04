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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
            Order order = (Order)DataContext;
        }

        /// <summary>
        /// Event handler to set the Frame Data context.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// Event handler to set the frame data context.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// Event handler for the done button to go back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            OrderInterface.NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Method to set the frame data context.
        /// </summary>
        private void SetFrameDataContext()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }
    }
}
