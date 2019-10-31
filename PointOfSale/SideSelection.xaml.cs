/* SideSelection.xaml.cs
 * Author: Ethan Renner
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }
        public void OnFryceritopsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void OnMeteorMacAndCheeseClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new MeteorMacAndCheese());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void OnMezzorellaSticksClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new MezzorellaSticks());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void OnTriceritotsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Triceritots());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                    NavigationService.Navigate(new MenuCategorySelection());
                    
                }
            }
        }
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
    }
}
