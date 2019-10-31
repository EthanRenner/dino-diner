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
        }

        public void OnFryceritopsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        public void OnMeteorMacAndCheeseClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentTo(side);
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        public void OnMezzorellaSticksClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new MezzorellaSticks());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                EnableSizeButtons();
                DisableSideButtons();
            }
        }
        public void OnTriceritotsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Triceritots());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                EnableSizeButtons();
                DisableSideButtons();
            }
        }

        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                    NavigationService.Navigate(new MenuCategorySelection());
                    
                }
            }
        }
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        public void EnableSideButtons()
        {
            FryceritopsButton.IsEnabled = true;
            MeteorMacAndCheeseButton.IsEnabled = true;
            MezzorellaSticksButton.IsEnabled = true;
            TriceritotsButton.IsEnabled = true;
        }
        public void DisableSideButtons()
        {
            FryceritopsButton.IsEnabled = false;
            MeteorMacAndCheeseButton.IsEnabled = false;
            MezzorellaSticksButton.IsEnabled = false;
            TriceritotsButton.IsEnabled = false;
        }
        public void EnableSizeButtons()
        {
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }
        public void DisableSizeButtons()
        {
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
        }
    }
}
