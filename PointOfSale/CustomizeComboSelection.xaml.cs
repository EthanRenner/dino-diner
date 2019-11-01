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
        private CretaceousCombo cc;
        public CustomizeComboSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
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
            NavigationService.Navigate(new SideSelection(cc));
        }

        // Size methods
        private void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (cc != null)
                {
                    cc.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }
        private void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (cc != null)
                {
                    cc.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }
        private void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (cc != null)
                {
                    cc.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }
    }
}
