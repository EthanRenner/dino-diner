/* FlavorSelection.xaml.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public void OnCherryClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnChocolateClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnColaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnLimeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnOrangeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnRootBeerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void OnVanillaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
    }
}
