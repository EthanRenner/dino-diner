/* MainWindow.xaml.cs
 * Author: Nathan Bean & Ethan Renner
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            if (order != null)
            {
                order.Add(new DinoNuggets());
                order.Add(new Sodasaurus());
                Triceritots tt = new Triceritots();
                tt.Size = DinoDiner.Menu.Size.Medium;
                order.Add(tt);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldBun();
                sb.HoldMustard();
                order.Add(sb);
            }
        }

        private void PassOnDataContext()
        {
            Page p = OrderUI.Content as Page;
            if (p != null)
            {
                p.DataContext = OrderUI.DataContext;
            }
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }
    }
}
