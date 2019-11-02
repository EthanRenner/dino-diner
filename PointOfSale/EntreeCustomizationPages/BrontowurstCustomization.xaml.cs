/* BrontowurstCustomization.xaml.cs
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private CretaceousCombo cc;
        private Brontowurst b;
        public BrontowurstCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                {
                    b = brontowurst;
                }
            }
        }
        public BrontowurstCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.b = cc.Entree as Brontowurst;
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
            if (cc != null)
            {
                b.HoldPeppers();
                cc.Entree = b;
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
            if (cc != null)
            {
                b.HoldBun();
                cc.Entree = b;
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
            if (cc != null)
            {
                b.HoldOnion();
                cc.Entree = b;
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
