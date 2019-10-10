/* ComboSelection.xaml.cs
 * Author: Ethan Renner
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the customize combo selection page.
        /// </summary>
        /// <param name="sender">Unused information about sender.</param>
        /// <param name="args">Unused arguments about event.</param>
        public void NavToCustomizeCombos(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeComboSelection());
        }
    }
}
