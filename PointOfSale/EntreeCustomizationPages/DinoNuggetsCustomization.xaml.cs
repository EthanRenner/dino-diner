/* DinoNuggetsCustomization.xaml.cs
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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        private DinoNuggets dn;
        private CretaceousCombo cc;
        public DinoNuggetsCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets dinonuggets)
                {
                    dn = dinonuggets;
                }
            }
        }
        public DinoNuggetsCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.dn = cc.Entree as DinoNuggets;
        }
        private void OnAddNuggetsClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets dinonuggets)
                {
                    dinonuggets.AddNugget();
                }
            }
            if (cc != null)
            {
                dn.AddNugget();
                cc.Entree = dn;
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
