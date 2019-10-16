/* Drink.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a drink. 
    /// </summary>
    public abstract class Drink: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private variables for size and ice
        protected Size size = Size.Small;
        private bool ice = true;
        private double price;
        private uint calories;

        /// <summary>
        /// Price of entree.
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Amount of calories in the entree.
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// List of ingredients in the entree.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Property for the size of the drink.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Property to get whether or not this drink has ice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Sets the private ice variable to false.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// String description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// String array of all specials added to drink.
        /// </summary>
        public abstract string[] Special { get; }

        protected List<string> specials = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName="")
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
    }
}
