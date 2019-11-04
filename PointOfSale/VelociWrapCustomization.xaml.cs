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
        /// private backing variable for the combo choice.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// private backing variable to see if this entree is being implemented as a combo.
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// backing variable to create a new vw object.
        /// </summary>
        private VelociWrap vw;

        /// <summary>
        ///  Constructor for the VelociWrap customization page.
        /// </summary>
        /// <param name="vw"></param>
        public VelociWrapCustomization(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
            isCombo = false;
        }

        /// <summary>
        /// Constructor to implement if the entree is in a combo.
        /// </summary>
        /// <param name="combo"></param>
        public VelociWrapCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Event handler for holding the lettuce.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw) vw.HoldLettuce();
            else this.vw.HoldLettuce();
        }

        /// <summary>
        /// Event handler for holding the dressing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw) vw.HoldDressing();
            else this.vw.HoldDressing();
        }

        /// <summary>
        /// Event handler for holding the cheese.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw) vw.HoldCheese();
            else this.vw.HoldCheese();
        }

        /// <summary>
        /// Event handler for the Done button to go back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
