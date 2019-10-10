/* DrinkSelection.xaml.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Button HoldIceButton, AddIceButton, AddLemonButton, SweetButton, DecafButton, FlavorButton;
        public DrinkSelection()
        {
            InitializeComponent();
            InitializeButtons();
        }

        /// <summary>
        /// Navigates to the flavor selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToFlavors(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
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
            FlavorButton = new Button();
            buttons.Add(FlavorButton);
            foreach (Button b in buttons)
            {
                b.Width = 175;
                b.Height = 80;
                b.Margin = new System.Windows.Thickness(10);
                b.Content = new TextBlock();
            }
            ((TextBlock)HoldIceButton.Content).Text = "Hold Ice";
            ((TextBlock)AddIceButton.Content).Text = "Add Ice";
            ((TextBlock)AddLemonButton.Content).Text = "Add Lemon";
            ((TextBlock)SweetButton.Content).Text = "Sweeten";
            ((TextBlock)DecafButton.Content).Text = "Decaf";
            ((TextBlock)FlavorButton.Content).Text = "Flavor";
            FlavorButton.Click += NavToFlavors;
        }

        // Sets the special buttons according to what sodasaurus needs
        private void SpecialsForSodasaurus(object sender, RoutedEventArgs args)
        {
            uxSpecialStackpanel.Children.Clear();
            uxSpecialStackpanel.Children.Add(FlavorButton);
            uxSpecialStackpanel.Children.Add(AddLemonButton);
            uxSpecialStackpanel.Children.Add(HoldIceButton);
        }

        // Sets the special buttons according to what tyrannotea needs
        private void SpecialsForTyrannotea(object sender, RoutedEventArgs args)
        {
            uxSpecialStackpanel.Children.Clear();
            uxSpecialStackpanel.Children.Add(SweetButton);
            uxSpecialStackpanel.Children.Add(AddLemonButton);
            uxSpecialStackpanel.Children.Add(HoldIceButton);
        }

        // Sets the special buttons according to what jurassic java needs
        private void SpecialsForJurassicJava(object sender, RoutedEventArgs args)
        {
            uxSpecialStackpanel.Children.Clear();
            uxSpecialStackpanel.Children.Add(DecafButton);
            uxSpecialStackpanel.Children.Add(AddIceButton);
        }

        // Sets the special buttons according to what water needs
        private void SpecialsForWater(object sender, RoutedEventArgs args)
        {
            uxSpecialStackpanel.Children.Clear();
            uxSpecialStackpanel.Children.Add(AddLemonButton);
            uxSpecialStackpanel.Children.Add(HoldIceButton);
        }
    }
}
