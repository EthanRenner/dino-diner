/* EntreeSelection.xaml.cs
 * Author: Ethan Renner
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
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
                order.Add(new Brontowurst());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new DinoNuggets());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new PrehistoricPBJ());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new PterodactylWings());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new SteakosaurusBurger());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new TRexKingBurger());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
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
                order.Add(new VelociWrap());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
