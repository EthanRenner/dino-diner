/* SteakosaurusBurgerCustomization.xaml.cs
 * Author: Ethan Renner
 */
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
        private SteakosaurusBurger sb;
        private CretaceousCombo cc;
        public SteakosaurusBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                {
                    sb = steakosaurusburger;
                }
            }
        }
        public SteakosaurusBurgerCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.sb = cc.Entree as SteakosaurusBurger;
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
            if (cc != null)
            {
                sb.HoldKetchup();
                cc.Entree = sb;
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
            if (cc != null)
            {
                sb.HoldMustard();
                cc.Entree = sb;
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
            if (cc != null)
            {
                sb.HoldPickle();
                cc.Entree = sb;
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
            if (cc != null)
            {
                sb.HoldBun();
                cc.Entree = sb;
            }
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeComboSelection(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
