/* SideSelection.xaml.cs
 * Author: Ethan Renner
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo cc;
        public SideSelection()
        {
            InitializeComponent();
            EnableSideButtons();
            DisableSizeButtons();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            EnableSizeButtons();
            DisableSideButtons();
            this.side = side;
        }
        public SideSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            EnableSideButtons();
            DisableSizeButtons();
            this.cc = cc;
        }

        private void OnFryceritopsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (cc == null)
                {
                    order.Add(side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    cc.Side = side;
                }
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        private void OnMeteorMacAndCheeseClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (cc == null)
                {
                    order.Add(side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    cc.Side = side;
                }
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        private void OnMezzorellaSticksClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (cc == null)
                {
                    order.Add(side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    cc.Side = side;
                }
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        private void OnTriceritotsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (cc == null)
                {
                    order.Add(side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    cc.Side = side;
                }
                EnableSizeButtons();
                DisableSideButtons();
            }
        }

        private void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Small;
            }
            if (cc != null)
            {
                cc.Side = side;
                NavigationService.Navigate(new CustomizeComboSelection(cc));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        private void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Medium;
            }
            if (cc != null)
            {
                cc.Side = side;
                NavigationService.Navigate(new CustomizeComboSelection(cc));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        private void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Large;
            }
            if (cc != null)
            {
                cc.Side = side;
                NavigationService.Navigate(new CustomizeComboSelection(cc));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void EnableSideButtons()
        {
            FryceritopsButton.IsEnabled = true;
            MeteorMacAndCheeseButton.IsEnabled = true;
            MezzorellaSticksButton.IsEnabled = true;
            TriceritotsButton.IsEnabled = true;
        }
        private void DisableSideButtons()
        {
            FryceritopsButton.IsEnabled = false;
            MeteorMacAndCheeseButton.IsEnabled = false;
            MezzorellaSticksButton.IsEnabled = false;
            TriceritotsButton.IsEnabled = false;
        }
        private void EnableSizeButtons()
        {
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }
        private void DisableSizeButtons()
        {
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
        }
    }
}
