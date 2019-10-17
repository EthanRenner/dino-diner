using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a side. Requires price, calories, and ingredients.
    /// </summary>
    public abstract class Entree: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private double price;
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

        private uint calories;
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
        /// String description of the entree.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// String array of all specials added to entree.
        /// </summary>
        public abstract string[] Special { get; }

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
    }
}
