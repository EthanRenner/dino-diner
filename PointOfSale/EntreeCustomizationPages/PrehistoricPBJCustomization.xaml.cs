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
        public PrehistoricPBJCustomization()
        {
            InitializeComponent();
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
        }
        public void OnReturnClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
