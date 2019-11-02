/* PrehistoricPBJCustomization.xaml.cs
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
    /// Interaction logic for PrehistoricPBJCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo cc;
        public PrehistoricPBJCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    this.pbj = pbj;
                }
            }
        }
        public PrehistoricPBJCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.pbj = cc.Entree as PrehistoricPBJ;
        }
        private void OnJellyClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    pbj.HoldJelly();
                }
            }
            if (cc != null)
            {
                pbj.HoldJelly();
                cc.Entree = pbj;
            }
        }
        private void OnPBClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    pbj.HoldPeanutButter();
                }
            }
            if (cc != null)
            {
                pbj.HoldPeanutButter();
                cc.Entree = pbj;
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
