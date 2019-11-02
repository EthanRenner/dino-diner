/* VelociWrapCustomization.xaml.cs
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
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {
        private VelociWrap vw;
        private CretaceousCombo cc;
        public VelociWrapCustomization()
        {
            InitializeComponent();

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                {
                    vw = velociwrap;
                }
            }
        }
        public VelociWrapCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.vw = cc.Entree as VelociWrap;
        }
        private void OnLettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                {
                    velociwrap.HoldLettuce();
                }
            }
            if (cc != null)
            {
                vw.HoldLettuce();
                cc.Entree = vw;
            }
        }
        private void OnCheeseClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                {
                    velociwrap.HoldCheese();
                }
            }
            if (cc != null)
            {
                vw.HoldCheese();
                cc.Entree = vw;
            }
        }
        private void OnDressingClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                {
                    velociwrap.HoldDressing();
                }
            }
            if (cc != null)
            {
                vw.HoldDressing();
                cc.Entree = vw;
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
