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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        public BrontowurstCustomization()
        {
            InitializeComponent();
        }
        public BrontowurstCustomization(Brontowurst b)
        {
            InitializeComponent();
        }
        private void OnPeppersClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                {
                    brontowurst.HoldPeppers();
                }
            }
        }
        private void OnBunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                {
                    brontowurst.HoldBun();
                }
            }
        }
        private void OnOnionsClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                {
                    brontowurst.HoldOnion();
                }
            }
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
