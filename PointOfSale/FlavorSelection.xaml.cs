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
        private CretaceousCombo cc;
        private Sodasaurus soda;
        public FlavorSelection()
        {
            InitializeComponent();
        }
        public FlavorSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.soda = cc.Drink as Sodasaurus;
        }

        public void OnCherryClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Cherry);
        }
        public void OnChocolateClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Chocolate);
        }
        public void OnColaClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Cola);
        }
        public void OnLimeClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Lime);
        }
        public void OnOrangeClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Orange);
        }
        public void OnRootBeerClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.RootBeer);
        }
        public void OnVanillaClick(object sender, RoutedEventArgs args)
        {
            ClickGeneralized(SodasaurusFlavor.Vanilla);
        }

        private void ClickGeneralized(SodasaurusFlavor flavor)
        {
            if (cc != null)
            {
                soda.Flavor = flavor;
                cc.Drink = soda;
                NavigationService.Navigate(new DrinkSelection(cc, cc.Drink));
            }
            else if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = flavor;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }
    }
}
