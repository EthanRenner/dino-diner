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
            EnableDrinkButtons();
            DisableSpecialButtons();
        }
        public DrinkSelection(Drink drink)
        {
            this.drink = drink;
            InitializeComponent();
            InitializeButtons();
            DisableDrinkButtons();
            EnableSpecialButtons();
            if (drink is Sodasaurus)
            {
                AddSodasaurusButtons();
            }
            else if (drink is Tyrannotea)
            {
                AddTyrannoteaButtons();
            }
            else if (drink is JurassicJava)
            {
                AddJurassicJavaButtons();
            }
            else if (drink is Water)
            {
                AddWaterButtons();
            }
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
                drink = new Sodasaurus();
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                AddSodasaurusButtons();

                DisableDrinkButtons();
                EnableSpecialButtons();
            }
        }
        private void AddSodasaurusButtons()
        {
            uxSpecialsGrid.Children.Clear();
            uxSpecialsGrid.Children.Add(uxSpecialsHeader);
            uxSpecialsGrid.Children.Add(HoldIceButton);
            uxSpecialsGrid.Children.Add(FlavorButton);
        }

        // Sets the special buttons according to what tyrannotea needs
        private void OnTyrannoteaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                AddTyrannoteaButtons();

                DisableDrinkButtons();
                EnableSpecialButtons();
            }
        }
        private void AddTyrannoteaButtons()
        {
            uxSpecialsGrid.Children.Clear();
            uxSpecialsGrid.Children.Add(uxSpecialsHeader);
            uxSpecialsGrid.Children.Add(HoldIceButton);
            uxSpecialsGrid.Children.Add(AddLemonButton);
            uxSpecialsGrid.Children.Add(SweetButton);
        }

        // Sets the special buttons according to what jurassic java needs
        private void OnJurassicJavaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                AddJurassicJavaButtons();

                DisableDrinkButtons();
                EnableSpecialButtons();
            }
        }
        private void AddJurassicJavaButtons()
        {
            uxSpecialsGrid.Children.Clear();
            uxSpecialsGrid.Children.Add(uxSpecialsHeader);
            uxSpecialsGrid.Children.Add(AddIceButton);
            uxSpecialsGrid.Children.Add(DecafButton);
            uxSpecialsGrid.Children.Add(RoomForCreamButton);
        }

        // Sets the special buttons according to what water needs
        private void OnWaterClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                AddWaterButtons();

                DisableDrinkButtons();
                EnableSpecialButtons();
            }
        }
        private void AddWaterButtons()
        {
            uxSpecialsGrid.Children.Clear();
            uxSpecialsGrid.Children.Add(uxSpecialsHeader);
            uxSpecialsGrid.Children.Add(HoldIceButton);
            uxSpecialsGrid.Children.Add(AddLemonButton);
        }

        // Size methods
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (drink != null)
                drink.Size = DinoDiner.Menu.Size.Small;
        }
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (drink != null)
                drink.Size = DinoDiner.Menu.Size.Medium;
        }
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (drink != null)
                drink.Size = DinoDiner.Menu.Size.Large;
        }

        // Done methods
        public void OnDoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        // Specials methods
        public void OnIceClick(object sender, RoutedEventArgs args)
        {
            if (drink != null)
                drink.Ice = !drink.Ice;
        }
        public void OnLemonClick(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                if (drink is Water w)
                {
                    w.Lemon = !w.Lemon;
                }
                else if (drink is Tyrannotea t)
                {
                    t.Lemon = !t.Lemon;
                }
            }
        }
        public void OnSweetClick(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                if (drink is Tyrannotea t)
                {
                    t.Sweet = !t.Sweet;
                }
            }
        }
        public void OnDecafClick(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                if (drink is JurassicJava jj)
                {
                    jj.Decaf = !jj.Decaf;
                }
            }
        }
        public void OnRoomForCreamClick(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                if (drink is JurassicJava jj)
                {
                    jj.RoomForCream = !jj.RoomForCream;
                }
            }
        }
        public void OnFlavorsClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void EnableDrinkButtons()
        {
            SodasaurusButton.IsEnabled = true;
            JurassicJavaButton.IsEnabled = true;
            TyrannoteaButton.IsEnabled = true;
            WaterButton.IsEnabled = true;
        }
        private void DisableDrinkButtons()
        {
            SodasaurusButton.IsEnabled = false;
            JurassicJavaButton.IsEnabled = false;
            TyrannoteaButton.IsEnabled = false;
            WaterButton.IsEnabled = false;
        }
        private void EnableSpecialButtons()
        {
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            HoldIceButton.IsEnabled = true;
            AddIceButton.IsEnabled = true;
            AddLemonButton.IsEnabled = true;
            SweetButton.IsEnabled = true;
            DecafButton.IsEnabled = true;
            RoomForCreamButton.IsEnabled = true;
            FlavorButton.IsEnabled = true;
        }
        private void DisableSpecialButtons()
        {
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;

            HoldIceButton.IsEnabled = false;
            AddIceButton.IsEnabled = false;
            AddLemonButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            RoomForCreamButton.IsEnabled = false;
            FlavorButton.IsEnabled = false;
        }
    }
}
