using DinoDiner.Menu;
using PointOfSale.EntreeCustomizationPages;
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
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst b)
                {
                    NavigationService.Navigate(new BrontowurstCustomization());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets dn)
                {
                    NavigationService.Navigate(new DinoNuggetsCustomization());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    NavigationService.Navigate(new PrehistoricPBJCustomization());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger sb)
                {
                    NavigationService.Navigate(new SteakosaurusBurgerCustomization());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trex)
                {
                    NavigationService.Navigate(new TRexKingBurgerCustomization());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap vw)
                {
                    NavigationService.Navigate(new VelociWrapCustomization());
                }
            }
        }
        public NavigationService NavigationService { get; set; }
    }
}
