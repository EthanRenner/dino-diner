/* CrestaceousCombo.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables
        private Size size;
        private Entree entree;
        private Side side = new Fryceritops();
        private Drink drink = new Sodasaurus();

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                NotifyOfPropertyChanged("Entree");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                NotifyOfPropertyChanged("Side");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Drink");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        
        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// String description of this entree order.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// String array of all specials added to this combo order.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> tempSpecials = new List<string>(specials);
                tempSpecials.AddRange(Entree.Special);
                tempSpecials.Add(Side.Description);
                tempSpecials.AddRange(Side.Special);
                tempSpecials.Add(Drink.Description);
                tempSpecials.AddRange(Drink.Special);
                return tempSpecials.ToArray();
            }
        }

        protected List<string> specials = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds the special to the specials list.
        /// </summary>
        /// <param name="special">Special to add to list.</param>
        public void AddSpecial(string special)
        {
            specials.Add(special);
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this combo.</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
    }
}
