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
        public TRexKingBurgerCustomization()
        {
            InitializeComponent();
        }
        public TRexKingBurgerCustomization(TRexKingBurger trex)
        {
            InitializeComponent();
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
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
