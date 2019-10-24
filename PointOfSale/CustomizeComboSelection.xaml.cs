/* CustomizeComboSelection.xaml.cs
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
    /// Interaction logic for CustomizeComboSelection.xaml
    /// </summary>
    public partial class CustomizeComboSelection : Page
    {
        public CustomizeComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the drink selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToDrinks(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Navigates to the side selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        // Size methods
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }
    }
}
