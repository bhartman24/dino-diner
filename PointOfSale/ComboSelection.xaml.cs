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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// private backing variable to use for the combo selection
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Method that implements the xaml page.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler if the Brontowurst option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                combo = new CretaceousCombo(bw);
                order.Add(combo);
            }
            NavigationService.Navigate(new BrontowurstCustomization(combo));
        }

        /// <summary>
        /// Event handler if the DinoNuggets option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                combo = new CretaceousCombo(dn);
                order.Add(combo);
            }
            NavigationService.Navigate(new DinoNuggetsCustomization(combo));
        }

        /// <summary>
        /// Event handler if the PrehistoricPBJ option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                combo = new CretaceousCombo(pbj);
                order.Add(combo);
            }
            NavigationService.Navigate(new PrehistoricPBJCustomization(combo));
        }

        /// <summary>
        /// Event handler if the PterodactylWings option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                combo = new CretaceousCombo(pw);
                order.Add(combo);
            }
            NavigationService.Navigate(new PterodactylWingsCustomization(combo));
        }

        /// <summary>
        /// Event handler if the SteakosaurusBurger option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                combo = new CretaceousCombo(sb);
                order.Add(combo);
            }
            NavigationService.Navigate(new SteakosaurusBurgerCustomization(combo));
        }

        /// <summary>
        /// Event handler if the TRexKingBurger option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                combo = new CretaceousCombo(trex);
                order.Add(combo);
            }
            NavigationService.Navigate(new TRexKingBurgerCustomization(combo));
        }

        /// <summary>
        /// Event handler if the VelociWrap option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                combo = new CretaceousCombo(vw);
                order.Add(combo);
            }
            NavigationService.Navigate(new VelociWrapCustomization(combo));
        }
    }
}
