/* OrderControl.xaml.cs
 * Author: Ethan Renner
 */
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
                        NavigationService.Navigate(new MenuCategorySelection());
                    }
                }
            }
        }

        public void OnSelectionChange(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                IOrderItem item = CollectionViewSource.GetDefaultView(order.Items).CurrentItem as IOrderItem;
                if (item is Side side)
                {
                    NavigationService.Navigate(new SideSelection(side));
                }
                else if (item is Drink drink)
                {
                    NavigationService.Navigate(new DrinkSelection(drink));
                }
                else if (item is CretaceousCombo cc)
                {
                    NavigationService.Navigate(new CustomizeComboSelection(cc));
                }
                else if (item is Brontowurst b)
                {
                    NavigationService.Navigate(new BrontowurstCustomization());
                }
                else if (item is DinoNuggets dn)
                {
                    NavigationService.Navigate(new DinoNuggetsCustomization());
                }
                else if (item is PrehistoricPBJ pbj)
                {
                    NavigationService.Navigate(new PrehistoricPBJCustomization());
                }
                else if (item is SteakosaurusBurger sb)
                {
                    NavigationService.Navigate(new SteakosaurusBurgerCustomization());
                }
                else if (item is TRexKingBurger trex)
                {
                    NavigationService.Navigate(new TRexKingBurgerCustomization());
                }
                else if (item is VelociWrap vw)
                {
                    NavigationService.Navigate(new VelociWrapCustomization());
                }
            }
        }
        public NavigationService NavigationService { get; set; }
    }
}
