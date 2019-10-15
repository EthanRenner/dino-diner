/* Menu.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Property to get the list of all available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.AddRange(AvailableCombos);
                availableMenuItems.AddRange(AvailableDrinks);
                availableMenuItems.AddRange(AvailableEntrees);
                availableMenuItems.AddRange(AvailableSides);
                return availableMenuItems;
            }
        }

        /// <summary>
        /// Property to get the list of all available entrees.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
                availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                return availableCombos;
            }
        }

        /// <summary>
        /// Property to get the list of all available drinks.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>();
                availableDrinks.Add(new JurassicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());
                return availableDrinks;
            }
        }

        /// <summary>
        /// Property to get the list of all available entrees.
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> availableEntrees = new List<Entree>();
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
                return availableEntrees;
            }
        }

        /// <summary>
        /// Property to get the list of all available sides.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> availableSides = new List<Side>();
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());
                return availableSides;
            }
        }

        /// <summary>
        /// Overrides to string to print all menu items on their own lines.
        /// </summary>
        /// <returns>A string representation of the menu.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(IMenuItem menuItem in AvailableMenuItems)
            {
                sb.AppendLine(menuItem.ToString());
            }
            return sb.ToString();
        }
    }
}
