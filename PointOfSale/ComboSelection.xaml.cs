/* ComboSelection.xaml.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds Brontowurst to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnBrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new Brontowurst()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds DinoNuggets to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnDinoNuggetsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new DinoNuggets()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds PrehistoricPBJ to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnPrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds PterodactylWings to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnPterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new PterodactylWings()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds SteakosaurusBurger to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnSteakosaurusBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds TRexKingBurger to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnTRexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new TRexKingBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }

        /// <summary>
        /// Adds VelociWrap to order, selects it in the order control, and returns to menu category selection screen.
        /// </summary>
        /// <param name="sender">Unused sender.</param>
        /// <param name="args">Unused routed event args.</param>
        public void OnVelociWrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new VelociWrap()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection());
            }
        }
    }
}
