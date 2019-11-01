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
        private CretaceousCombo cc;
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
                cc = new CretaceousCombo(new Brontowurst());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new DinoNuggets());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new PterodactylWings());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new TRexKingBurger());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
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
                cc = new CretaceousCombo(new VelociWrap());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeComboSelection(cc));
            }
        }
    }
}
