/* DrinkSelection.xaml.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Button HoldIceButton, AddIceButton, AddLemonButton, SweetButton, DecafButton, FlavorButton, RoomForCreamButton;
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
            InitializeButtons();
        }
        public DrinkSelection(Drink drink)
        {
            this.drink = drink;
            InitializeComponent();
            InitializeButtons();
        }

        // Initializes specialty buttons and their settings
        private void InitializeButtons()
        {
            List<Button> buttons = new List<Button>();
            HoldIceButton = new Button();
            buttons.Add(HoldIceButton);
            AddIceButton = new Button();
            buttons.Add(AddIceButton);
            AddLemonButton = new Button();
            buttons.Add(AddLemonButton);
            SweetButton = new Button();
            buttons.Add(SweetButton);
            DecafButton = new Button();
            buttons.Add(DecafButton);
            RoomForCreamButton = new Button();
            buttons.Add(RoomForCreamButton);
            FlavorButton = new Button();
            buttons.Add(FlavorButton);
            foreach (Button b in buttons)
            {
                b.Content = new TextBlock();
            }
            ((TextBlock)HoldIceButton.Content).Text = "Hold Ice";
            Grid.SetRow(HoldIceButton, 1);
            HoldIceButton.Click += OnIceClick;

            ((TextBlock)AddIceButton.Content).Text = "Add Ice";
            Grid.SetRow(AddIceButton, 1);
            AddIceButton.Click += OnIceClick;

            ((TextBlock)AddLemonButton.Content).Text = "Add Lemon";
            Grid.SetRow(AddLemonButton, 2);
            AddLemonButton.Click += OnLemonClick;

            ((TextBlock)SweetButton.Content).Text = "Sweeten";
            Grid.SetRow(SweetButton, 3);
            SweetButton.Click += OnSweetClick;

            ((TextBlock)DecafButton.Content).Text = "Decaf";
            Grid.SetRow(DecafButton, 2);
            DecafButton.Click += OnDecafClick;

            ((TextBlock)RoomForCreamButton.Content).Text = "Room For Cream";
            Grid.SetRow(RoomForCreamButton, 3);
            RoomForCreamButton.Click += OnRoomForCreamClick;

            ((TextBlock)FlavorButton.Content).Text = "Flavor";
            Grid.SetRow(FlavorButton, 2);
            FlavorButton.Click += OnFlavorsClick;
        }

        // Sets the special buttons according to what sodasaurus needs
        private void OnSodasaurusClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Sodasaurus());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                uxSpecialsGrid.Children.Clear();
                uxSpecialsGrid.Children.Add(uxSpecialsHeader);
                uxSpecialsGrid.Children.Add(HoldIceButton);
                uxSpecialsGrid.Children.Add(FlavorButton);
            }
        }

        // Sets the special buttons according to what tyrannotea needs
        private void OnTyrannoteaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Tyrannotea());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                // update specials
                uxSpecialsGrid.Children.Clear();
                uxSpecialsGrid.Children.Add(uxSpecialsHeader);
                uxSpecialsGrid.Children.Add(HoldIceButton);
                uxSpecialsGrid.Children.Add(AddLemonButton);
                uxSpecialsGrid.Children.Add(SweetButton);
            }
        }

        // Sets the special buttons according to what jurassic java needs
        private void OnJurassicJavaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new JurassicJava());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                uxSpecialsGrid.Children.Clear();
                uxSpecialsGrid.Children.Add(uxSpecialsHeader);
                uxSpecialsGrid.Children.Add(AddIceButton);
                uxSpecialsGrid.Children.Add(DecafButton);
                uxSpecialsGrid.Children.Add(RoomForCreamButton);
            }
        }

        // Sets the special buttons according to what water needs
        private void OnWaterClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                uxSpecialsGrid.Children.Clear();
                uxSpecialsGrid.Children.Add(uxSpecialsHeader);
                uxSpecialsGrid.Children.Add(HoldIceButton);
                uxSpecialsGrid.Children.Add(AddLemonButton);
            }
        }

        // Size methods
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        // Done methods
        public void OnDoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        // Specials methods
        public void OnIceClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Ice = !drink.Ice;
                }
            }
        }
        public void OnLemonClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water w)
                {
                    w.Lemon = !w.Lemon;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea t)
                {
                    t.Lemon = !t.Lemon;
                }
            }
        }
        public void OnSweetClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea t)
                {
                    t.Sweet = !t.Sweet;
                }
            }
        }
        public void OnDecafClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava jj)
                {
                    jj.Decaf = !jj.Decaf;
                }
            }
        }
        public void OnRoomForCreamClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava jj)
                {
                    jj.RoomForCream = !jj.RoomForCream;
                }
            }
        }
        public void OnFlavorsClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
