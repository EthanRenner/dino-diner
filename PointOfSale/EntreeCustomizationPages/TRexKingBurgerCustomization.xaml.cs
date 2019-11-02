/* TRexKingBurgerCustomization.xaml.cs
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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        private TRexKingBurger trex;
        private CretaceousCombo cc;
        public TRexKingBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trex = trexkingburger;
                }
            }
        }
        public TRexKingBurgerCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.trex = cc.Entree as TRexKingBurger;
        }
        private void OnKetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldKetchup();
                }
            }
            if (cc != null)
            {
                trex.HoldKetchup();
                cc.Entree = trex;
            }
        }
        private void OnMustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldMustard();
                }
            }
            if (cc != null)
            {
                trex.HoldMustard();
                cc.Entree = trex;
            }
        }
        private void OnPickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldPickle();
                }
            }
            if (cc != null)
            {
                trex.HoldPickle();
                cc.Entree = trex;
            }
        }
        private void OnBunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldBun();
                }
            }
            if (cc != null)
            {
                trex.HoldBun();
                cc.Entree = trex;
            }
        }
        private void OnOnionClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldOnion();
                }
            }
            if (cc != null)
            {
                trex.HoldOnion();
                cc.Entree = trex;
            }
        }
        private void OnMayoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldMayo();
                }
            }
            if (cc != null)
            {
                trex.HoldMayo();
                cc.Entree = trex;
            }
        }
        private void OnLettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldLettuce();
                }
            }
            if (cc != null)
            {
                trex.HoldLettuce();
                cc.Entree = trex;
            }
        }
        private void OnTomatoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                {
                    trexkingburger.HoldTomato();
                }
            }
            if (cc != null)
            {
                trex.HoldTomato();
                cc.Entree = trex;
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
