/* CustomizeComboSelection.xaml.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using PointOfSale.EntreeCustomizationPages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeComboSelection.xaml
    /// </summary>
    public partial class CustomizeComboSelection : Page
    {
        private CretaceousCombo cc;
        public CustomizeComboSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            SetPictures();
        }

        /// <summary>
        /// Navigates to the drink selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToDrinks(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(cc));
        }

        /// <summary>
        /// Navigates to the side selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(cc));
        }

        /// <summary>
        /// Navigates to the entree customization page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToEntrees(object sender, RoutedEventArgs args)
        {
            if (cc.Entree is Brontowurst)
            {
                NavigationService.Navigate(new BrontowurstCustomization(cc));
            }
            else if (cc.Entree is DinoNuggets)
            {
                NavigationService.Navigate(new DinoNuggetsCustomization(cc));
            }
            else if (cc.Entree is PrehistoricPBJ)
            {
                NavigationService.Navigate(new PrehistoricPBJCustomization(cc));
            }
            else if (cc.Entree is PterodactylWings)
            {
                //NavigationService.Navigate(new DinoNuggetsCustomization(cc));
            }
            else if (cc.Entree is SteakosaurusBurger)
            {
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(cc));
            }
            else if (cc.Entree is TRexKingBurger)
            {
                NavigationService.Navigate(new TRexKingBurgerCustomization(cc));
            }
            else if (cc.Entree is VelociWrap)
            {
                NavigationService.Navigate(new VelociWrapCustomization(cc));
            }
        }

        // Size methods
        private void SizeChangeGeneralized(DinoDiner.Menu.Size size)
        {
            if (cc != null)
            {
                cc.Size = size;
            }
        }
        private void MakeSmall(object sender, RoutedEventArgs args)
        {
            SizeChangeGeneralized(DinoDiner.Menu.Size.Small);
        }
        private void MakeMedium(object sender, RoutedEventArgs args)
        {
            SizeChangeGeneralized(DinoDiner.Menu.Size.Medium);
        }
        private void MakeLarge(object sender, RoutedEventArgs args)
        {
            SizeChangeGeneralized(DinoDiner.Menu.Size.Large);
        }
        private void OnDoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SetPictures()
        {
            string stringpath = "";
            if (cc.Entree is Brontowurst)
                stringpath = "Assets/DinoDiner - 01.png";
            else if (cc.Entree is DinoNuggets)
                stringpath = "Assets / DinoDiner - 02.png";
            else if (cc.Entree is PrehistoricPBJ)
                stringpath = "Assets / DinoDiner - 03.png";
            else if (cc.Entree is PterodactylWings)
                stringpath = "Assets/DinoDiner - 04.png";
            else if (cc.Entree is SteakosaurusBurger)
                stringpath = "Assets / DinoDiner - 05.png";
            else if (cc.Entree is TRexKingBurger)
                stringpath = "Assets / DinoDiner - 06.png";
            else if (cc.Entree is VelociWrap)
                stringpath = "Assets / DinoDiner - 07.png";
            //EntreeImage.Source = new BitmapImage(new System.Uri(stringpath, relativeUri:));

            stringpath = "";
            if (cc.Side is Fryceritops)
                stringpath = "Assets / DinoDiner - 08.png";
            else if (cc.Side is MeteorMacAndCheese)
                stringpath = "Assets / DinoDiner - 09.png";
            else if (cc.Side is MezzorellaSticks)
                stringpath = "Assets / DinoDiner - 10.png";
            else if (cc.Side is Triceritots)
                stringpath = "Assets / DinoDiner - 11.png";
            //SideImage.Source = new BitmapImage(new System.Uri(stringpath, false));

            stringpath = "";
            if (cc.Drink is Tyrannotea)
                stringpath = "Assets / DinoDiner - 12.png";
            else if (cc.Drink is JurassicJava)
                stringpath = "Assets / DinoDiner - 13.png";
            else if (cc.Drink is Sodasaurus)
                stringpath = "Assets / DinoDiner - 14.png";
            else if (cc.Drink is Water)
                stringpath = "Assets / DinoDiner - 15.png";
            //DrinkImage.Source = new BitmapImage(new System.Uri(stringpath, false));
        }
    }
}
