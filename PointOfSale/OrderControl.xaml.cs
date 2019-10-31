using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        public void OnRemoveClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        public void OnSelectionChange(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    NavigationService.Navigate(new SideSelection(side));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    NavigationService.Navigate(new DrinkSelection(drink));
                }
            }
        }
        public NavigationService NavigationService { get; set; }
    }
}
