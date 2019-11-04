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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// boolean to see if we're implementing a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// private backing variable for a combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// private backing variable for a side.
        /// </summary>
        private Side side;

        /// <summary>
        /// Property for the Side.
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contructor for the SideSelection class.
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            
        }

        /// <summary>
        /// Constructor for dealing with a combo.
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Method to select your side.
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                if (isCombo)
                {
                    combo.Side = side;
                }
                order.Add(side);
                this.Side = side;
            }
        }

        /// <summary>
        /// Method to select your size for the side.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for the Fryceritops button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddFryceritops(object sender, RoutedEventArgs args)
        {
            
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.GoBack();
                }
                else
                {
                    order.Add(side);
                    BtnPickSmall.IsEnabled = true;
                    BtnPickMedium.IsEnabled = true;
                    BtnPickLarge.IsEnabled = true;
                }
            }
        }

        /// <summary>
        /// Event handler for the Triceritots button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.GoBack();
                }
                else
                {
                    order.Add(side);
                    BtnPickSmall.IsEnabled = true;
                    BtnPickMedium.IsEnabled = true;
                    BtnPickLarge.IsEnabled = true;
                }

            }
        }

        /// <summary>
        /// Event handler for the MeteorMacAndCheese button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.GoBack();
                }
                else
                {
                    order.Add(side);
                    BtnPickSmall.IsEnabled = true;
                    BtnPickMedium.IsEnabled = true;
                    BtnPickLarge.IsEnabled = true;
                }

            }
        }

        /// <summary>
        /// Event handler for the MezzorellaSticks button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.GoBack();
                }
                else
                {
                    order.Add(side);
                    BtnPickSmall.IsEnabled = true;
                    BtnPickMedium.IsEnabled = true;
                    BtnPickLarge.IsEnabled = true;
                }

            }
        }

        /// <summary>
        /// Event handler for the OnSelectLarge size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Event handler for the OnSelectMedium size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Event handler for the OnSelectSmall size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
