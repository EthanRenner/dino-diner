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
        public VelociWrapCustomization()
        {
            InitializeComponent();
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
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
