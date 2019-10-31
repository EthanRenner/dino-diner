using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.EntreeCustomizationPages
{
    /// <summary>
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        public SteakosaurusBurgerCustomization()
        {
            InitializeComponent();
        }
        private void OnKetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                {
                    steakosaurusburger.HoldKetchup();
                }
            }
        }
        private void OnMustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                {
                    steakosaurusburger.HoldMustard();
                }
            }
        }
        private void OnPickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                {
                    steakosaurusburger.HoldPickle();
                }
            }
        }
        private void OnBunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                {
                    steakosaurusburger.HoldBun();
                }
            }
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
